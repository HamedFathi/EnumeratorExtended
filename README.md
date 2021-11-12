![steps](https://user-images.githubusercontent.com/8418700/141453907-33af8015-a3ad-4f32-b5ae-992b98aa098b.png)

### [Nuget](https://www.nuget.org/packages/EnumeratorExtended)

```
Install-Package EnumeratorExtended

dotnet add package EnumeratorExtended
```

### Usage

```cs
// int
foreach (var item in 10) // 0 to 10
foreach (var item in -10) // -10 to 0

// Tuple
foreach (var item in (4, 10)) // (from, to)
foreach (var item in (from: 4, to: 10))

foreach (var x in (4, 10, 2)) // (from, to, step)
foreach (var x in (from: 4, to: 10, step: 2))

// Range
// Available on '.NETStandard 2.1' only.
foreach (var x in 1..10)
```

**Attention:** All extensions are implemented inside `global` namespace it means you don't need to `using` any namespaces, these features add to you project just by installing.

<hr/>
<div>Icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>

