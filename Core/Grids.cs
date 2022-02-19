namespace F;

public class Grids
{
    /// <see href="https://github.com/markstanden/f-c-sharp"/>
    ///
    /// <summary>
    /// Transposes a nested IEnumerable grid
    /// </summary>
    ///
    /// <param name="gridEnumerable">The nested IEnumerable grid to transpose</param>
    /// <typeparam name="T"></typeparam>
    /// <returns>A new Transposed nested IEnumerable grid</returns>
    public static IEnumerable<IEnumerable<T>> Transpose<T>(this IEnumerable<IEnumerable<T>> gridEnumerable)
    {
        var grid = gridEnumerable.Select(row => row.ToArray())
                                 .ToArray();
        return Enumerable.Range(0, grid[0]
                                   .Length)
                         .Select(col => grid.GetColumn(col));
    }

    /// <see href="https://github.com/markstanden/f-c-sharp"/>
    /// <summary>
    /// Returns a single column from a nested IEnumerable
    /// Expects a complete grid, with all rows having identical numbers of columns
    /// </summary>
    /// <param name="grid">The nested IEnumerable to get columns from</param>
    /// <param name="colNumber">The required column number from the grid</param>
    /// <typeparam name="T">The type of the actual contents of the grid</typeparam>
    /// <returns>An enumerable of the requested column.</returns>
    public static IEnumerable<T> GetColumn<T>(this IReadOnlyList<T[]> grid, int colNumber)
        => Enumerable.Range(0, grid.Count)
                     .Select(row => grid[row][colNumber]);
}