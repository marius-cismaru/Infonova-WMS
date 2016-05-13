using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Presentation.Events;

namespace Equistat.Infrastructure.Attributes
{
    //[AttributeUsage(AttributeTargets.Property)]
    //public class SelectionAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Property)]
    public class ServiceAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Method)]
    public class HandlesAttribute : Attribute
    {
        public ThreadOption ThreadOption { get; private set; }
        public Type EventType { get; private set; }

        public HandlesAttribute(Type eventType)
            : this(eventType, ThreadOption.UIThread)
        {
        }

        public HandlesAttribute(Type eventType, ThreadOption threadOption)
        {
            this.EventType = eventType;
            this.ThreadOption = threadOption;
        }
    }
}
