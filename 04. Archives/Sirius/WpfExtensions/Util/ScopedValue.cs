using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfExtensions.Util
{
    public class ScopedValue<T>
    {
        public T Value { get; private set; }
        public ScopedValue()
            : this(default(T))
        { }

        public ScopedValue(T defaultValue)
        {
            this.Value = defaultValue;
        }

        public IDisposable BeginValueScope(T value)
        {
            return new ScopedValueHelper<T>(this, value);
        }

        public event Action<ScopedValue<T>, T> OnScopeBegin;
        public event Action<ScopedValue<T>, T> OnScopeEnd;

        private class ScopedValueHelper<TInner> : IDisposable
        {
            ScopedValue<TInner> parent;
            TInner originalValue;
            public ScopedValueHelper(ScopedValue<TInner> parent, TInner value)
            {
                this.parent = parent;
                originalValue = parent.Value;
                parent.Value = value;
                var onScopeBeginEvent = this.parent.OnScopeBegin;
                if (onScopeBeginEvent != null)
                {
                    onScopeBeginEvent(this.parent, originalValue);
                }
            }

            public void Dispose()
            {
                var endingValue = this.parent.Value;
                this.parent.Value = this.originalValue;
                var onScopeEndEvent = this.parent.OnScopeEnd;
                if (onScopeEndEvent != null)
                {
                    onScopeEndEvent(this.parent, endingValue);
                }
            }
        }
    }
}
