namespace AgileCoding.Extentions.Dictionaries
{
    using System;
    using System.Collections.Generic;
    using AgileCoding.Extentions.Activators;

    public static class DictioaryExtentions
    {
        public static void ThrowsIfKeyDoesNotExist<IKeyType, IValueType, IExceptionType>(this Dictionary<IKeyType, IValueType> self, IKeyType lookupKey, string? errorMessage = null)
            where IExceptionType : Exception
            where IKeyType : notnull
        {
            errorMessage = errorMessage == null
                ? $"Key {lookupKey} not found in Dictinary"
                : errorMessage;

            if (!self.ContainsKey(lookupKey))
            {
                var exception = typeof(IExceptionType).CreateInstanceWithoutLogging<IExceptionType>(errorMessage);
                if (exception != null)
                {
                    throw exception;
                }
                else
                {
                    throw new InvalidOperationException("Could not create exception of type " + typeof(IExceptionType).FullName);
                }
            }
        }
    }
}
