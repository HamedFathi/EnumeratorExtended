![steps](https://user-images.githubusercontent.com/8418700/141453907-33af8015-a3ad-4f32-b5ae-992b98aa098b.png)

### [Nuget](https://www.nuget.org/packages/EnumeratorExtended)

[![Open Source Love](https://badges.frapsoft.com/os/mit/mit.svg?v=102)](https://opensource.org/licenses/MIT)
![Nuget](https://img.shields.io/nuget/v/EnumeratorExtended)
![Nuget](https://img.shields.io/nuget/dt/EnumeratorExtended)

```
Install-Package EnumeratorExtended

dotnet add package EnumeratorExtended
```

### Usage

```cs
// Only available on 'int' type.
foreach (var item in 10) // 0 to 10
foreach (var item in -10) // -10 to 0

foreach (var item in (4, 10)) // (from, to)
foreach (var item in (from: 4, to: 10))

foreach (var x in (4, 10, 2)) // (from, to, step)
foreach (var x in (from: 4, to: 10, step: 2))

// Loop on values of a tuple
// The type of 'item' is 'object'.
var numbers = (1, 2, 3.0f, 4.0f, 5.0, 6.0, "7");
foreach (var item in numbers) // 1, 2, 3.0, 4.0, 5.0, 6.0, 7

// Range 
// Available on '.NETStandard 2.1' only.
foreach (int x in 1..10) // 1 to 10
foreach (int x in ..10) // 0 to 10
foreach (int x in ^10..) // 10 to 0
```

* This feature ([Extension GetEnumerator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/extension-getenumerator)) only available on `C# 9.0` and above.

* All extensions are implemented inside `global` namespace it means you don't need to `using` any namespaces, these features add to you project just by installing.

<hr/>
<div>Icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>

