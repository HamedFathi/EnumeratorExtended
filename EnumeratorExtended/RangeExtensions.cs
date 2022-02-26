#if NETSTANDARD2_1_OR_GREATER
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class RangeExtensions
{
    public static IEnumerator<int> GetEnumerator(this Range range)
    {
        if (range.Start.IsFromEnd)
        {
            for (int i = range.Start.Value; i >= range.End.Value; i--)
            {
                yield return i;
            }
        }
        else
        {
            for (int i = range.Start.Value; i <= range.End.Value; i++)
            {
                yield return i;
            }
        }
    }
}
#endif