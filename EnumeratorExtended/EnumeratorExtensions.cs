using System.Collections.Generic;

public static class EnumeratorExtensions
{
    public static IEnumerator<T> GetEnumerator<T>(this IEnumerator<T> enumerator) => enumerator;

    public static IEnumerator<int> GetEnumerator(this int input)
    {
        if (input >= 0)
        {
            for (int i = 0; i <= input; i++)
            {
                yield return i;
            }
        }
        else
        {
            for (int i = input; i <= 0; i++)
            {
                yield return i;
            }
        }
    }

    public static IEnumerator<int> GetEnumerator(this (int from, int to) range)
    {
        for (int i = range.from; i < range.to; i++)
        {
            yield return i;
        }
    }

    public static IEnumerator<int> GetEnumerator(this (int from, int to, int step) range)
    {
        for (int i = range.from; i < range.to; i += range.step)
        {
            yield return i;
        }
    }
}
