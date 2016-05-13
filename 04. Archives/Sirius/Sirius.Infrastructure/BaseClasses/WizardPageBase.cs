using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Equistat.Infrastructure.Attributes;
using Equistat.Infrastructure.Services;
using Equistat.Infrastructure.UI;
using Equistat.Infrastructure.UI.Wrappers;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Presentation.Events;
using Microsoft.Practices.Unity;
using WpfExtensions.Util;

namespace Equistat.Infrastructure.BaseClasses
{
    public class WizardPageBase : ObservableObject
    {
        public IUnityContainer UnityContainer { get; set; }
        public IEventAggregator EventAggregator { get; set; }
        public IApp App { get; set; }
        public string Header { get; set; }

        public WizardPageBase(IUnityContainer container)
        {
            this.UnityContainer = container;
            this.EventAggregator = container.Resolve<IEventAggregator>();
            this.App = container.Resolve<IApp>();

            this.InitializeServices();
            //this.InitializeSelections();
            this.InitializeEventHandlers();
        }

        private void InitializeServices()
        {
            Type t = this.GetType();
            var properties = t.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
            var serviceProps = properties.Where(o => o.IsDefined(typeof(ServiceAttribute), false));

            foreach (var prop in serviceProps)
            {
                var srv = this.UnityContainer.Resolve(prop.PropertyType);
                prop.GetSetMethod(true).Invoke(this, new object[] { srv });
            }
        }

        private void InitializeEventHandlers()
        {
            Type t = this.GetType();
            var methods = t.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
            var handlers = methods.Where(o => o.IsDefined(typeof(HandlesAttribute), false));
            var evtAggregator = this.UnityContainer.Resolve<IEventAggregator>();

            foreach (var evtHandler in handlers)
            {
                var handlerMethod = typeof(HandlerProxy).GetMethod("Handler");

                var attrs = evtHandler.GetCustomAttributes(typeof(HandlesAttribute), false).OfType<HandlesAttribute>();
                var parameters = evtHandler.GetParameters();
                if (parameters.Length > 1)
                {
                    throw new ArgumentException("Methods marked with EventHandler attribute must have one parameter");
                }

                foreach (var attr in attrs)
                {
                    var eventObj = this.GetEvent(evtAggregator, attr.EventType);
                    var payLoadType = this.GetPayloadType(attr.EventType);

                    var eventDelegateType = typeof(Action<>).MakeGenericType(payLoadType);
                    Delegate delegateHandler;

                    if (parameters.Length == 0)
                    {
                        Delegate realDelegateHandler = evtHandler.IsStatic ?
                           Delegate.CreateDelegate(typeof(Action), null, evtHandler) :
                           Delegate.CreateDelegate(typeof(Action), this, evtHandler);

                        var proxy = new HandlerProxy(new DelegateReference(realDelegateHandler, false));
                        var proxyHandlerMethod = handlerMethod.MakeGenericMethod(payLoadType);
                        delegateHandler = Delegate.CreateDelegate(eventDelegateType, proxy, proxyHandlerMethod);
                    }
                    else
                    {
                        //if (!CheckDelegateCompatibility(eventDelegateType, evtHandler))
                        //{
                        //   throw new Exception("The method " + evtHandler.Name + " of type " + type.Name + " is not compatible with event type " + attr.EventType.Name);
                        //}
                        delegateHandler = evtHandler.IsStatic ?
                           Delegate.CreateDelegate(eventDelegateType, null, evtHandler) :
                           Delegate.CreateDelegate(eventDelegateType, this, evtHandler);
                    }
                    this.Subscribe(eventObj, eventDelegateType, new DelegateReference(delegateHandler, false));
                }
            }
        }

        private Type GetPayloadType(Type type)
        {
            while (type != typeof(object))
            {
                if (type.IsGenericType)
                {
                    var genericBaseType = type.GetGenericTypeDefinition();
                    //if (genericBaseType == typeof(SelectionBase<>))
                    //{
                    //    return type;
                    //}
                    //else 
                    if (genericBaseType == typeof(CompositePresentationEvent<>))
                    {
                        return type.GetGenericArguments()[0];
                    }
                }
                type = type.BaseType;
            }
            throw new NotSupportedException();
        }

        private MethodInfo getEventMethod = typeof(IEventAggregator).GetMethod("GetEvent");
        private object GetEvent(IEventAggregator evtAggregator, Type eventType)
        {
            return this.getEventMethod.MakeGenericMethod(eventType).Invoke(evtAggregator, new object[] { });
        }

        private void Subscribe(object @event, Type delegateType, IDelegateReference delegateReference)
        {
            var subscribeMethod = @event.GetType().GetMethod("Subscribe", new Type[] { typeof(IDelegateReference) });

            if (subscribeMethod != null)
            {
                subscribeMethod.Invoke(@event, new object[] { delegateReference });
            }
        }

        public virtual bool IsValid()
        {
            return true;
        }

        private bool isSelected;
        public bool IsSelected
        {
            get { return this.isSelected; }
            set
            {
                this.isSelected = value;
                this.RaisePropertyChanged(() => this.IsSelected);
            }
        }

        public virtual WizardOption SelectedOption { get; protected set; }

        public virtual IEnumerable<WizardOption> SelectedOptions { get; protected set; }

        public virtual int Decrement { get; set; }
    }
}
