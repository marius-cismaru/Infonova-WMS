using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace WpfExtensions.Util
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) { }

        public void RaisePropertyChanged<T>(Expression<Func<T>> expr)
        {
            var args = new PropertyChangedEventArgs(GetPropertyName(expr));
            this.RaisePropertyChanged(args);
        }

        public void RaisePropertyChanged(string propName)
        {
            var args = new PropertyChangedEventArgs(propName);
            this.RaisePropertyChanged(args);
        }

        public void RaisePropertyChanged(PropertyChangedEventArgs propArgs)
        {
            this.OnPropertyChanged(propArgs);
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, propArgs);
            }
        }

        public static string GetPropertyName<TResult>(Expression<Func<TResult>> expr)
        {
            var memberAccess = expr.Body as MemberExpression;
            var propertyInfo = memberAccess.Member as PropertyInfo;
            if (propertyInfo != null)
                return propertyInfo.Name;
            else return null;
        }

        public static string GetPropertyName<T, TResult>(Expression<Func<T, TResult>> expr)
        {
            var memberAccess = expr.Body as MemberExpression;
            var propertyInfo = memberAccess.Member as PropertyInfo;
            return propertyInfo.Name;
        }
    }
}
