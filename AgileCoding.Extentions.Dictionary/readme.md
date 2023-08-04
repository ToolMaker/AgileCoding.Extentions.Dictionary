AgileCoding.Extensions.Dictionary
=================================

Overview
--------

The AgileCoding.Extensions.Dictionary is a .NET library that provides an extension method for the `System.Collections.Generic.Dictionary` class. It introduces a convenient way of throwing an exception if a specified key does not exist in the dictionary.

Installation
------------

This library is available as a NuGet package. You can install it using the NuGet package manager console:

bashCopy code

`Install-Package AgileCoding.Extensions.Dictionary -Version 2.0.5`

Features
--------

The library introduces the following method for `Dictionary`:

1.  ThrowsIfKeyDoesNotExist: An extension method that throws an exception if a certain key does not exist in the dictionary.

Usage
-----

Here's a brief example of how to use this feature in your code:

```csharp
using AgileCoding.Extentions.Dictionaries;
using System.Collections.Generic;

// Suppose 'myDict' is a Dictionary<TKeyType, TValueType>.

myDict.ThrowsIfKeyDoesNotExist<TKeyType, TValueType, KeyNotFoundException>(lookupKey, "Custom error message");
```

In the above example, replace `TKeyType`, `TValueType`, and `lookupKey` with your actual types and key respectively. The third type parameter `KeyNotFoundException` is the exception that would be thrown if the key does not exist. This can be replaced with any other Exception type.

Documentation
-------------

For more detailed information about the usage of this library, please refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.Dictionary/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, see the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.Dictionary/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.Dictionary/blob/main/CONTRIBUTING.md) for more details.