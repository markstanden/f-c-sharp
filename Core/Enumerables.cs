namespace F;

public class Enumerables
{
    /// <summary>
    /// Returns an updated IEnumerable without the first occurrence of the item.
    /// </summary>
    /// <param name="sequence">The sequence to remove the item from</param>
    /// <param name="item">The item to be excluded from the sequence</param>
    /// <typeparam name="T">The Type of the items in the sequence</typeparam>
    /// <returns>A new, ordered sequence that doesn't contain the first occurrence of item</returns>
    private static IEnumerable<T> Without<T>(this IEnumerable<T> sequence, T item)
    {
        var copy = sequence.ToList();
        copy.Remove(item);
        return copy;
    }

}