





This package enables new capabilities on `Enumerators` as follows:

### [Nuget]()

```

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
foreach (var x in 1..10)
```

**Attention:** All extensions are implemented inside `global` namespace it means you don't need to `using` any namespaces, these features add to you project just by installing.
