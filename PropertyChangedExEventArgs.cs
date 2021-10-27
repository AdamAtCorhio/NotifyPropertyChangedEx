namespace ComponentModelEx
{
    public class PropertyChangedExEventArgs : PropertyChangedEventArgs
    {
        public object OldValue { get; private set; }
        public object NewValue { get; private set; }

        public PropertyChangedExEventArgs(object oldValue, object newValue, string propertyName)
            : base(propertyName)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
