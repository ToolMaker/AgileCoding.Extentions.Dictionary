namespace AgileCoding.Extentions.Dictionaries
{
    using System;
    using System.Collections.Generic;
    using AgileCoding.Extentions.Activators;

    public static class DictioaryExtentions
    {
        public static void ThrowsIfKeyDoesNotExist<IKeyType, IValueType, IExceptionType>(this Dictionary<IKeyType, IValueType> self, IKeyType lookupKey, string errorMessage = null)
            where IExceptionType : Exception
        {
            errorMessage = errorMessage == null
                ? $"Key {lookupKey} not found in Dictinary"
                : errorMessage;

            if (!self.ContainsKey(lookupKey))
            {
                throw typeof(IExceptionType).CreateInstanceWithoutLogging<IExceptionType>(errorMessage);
            }
        }
    }
}
