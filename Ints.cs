namespace F;

public class Ints
{
    /// <see href="https://github.com/markstanden/f-c-sharp"/>
    ///
    /// <summary>
    /// Cleanly divides two integers and
    /// returns the 'rounded up' ceiling value.
    /// Takes two integers and returns an int.
    ///
    /// <para>Removes the need to cast doubles when working with Math.Ceiling.</para>
    ///
    /// </summary>
    /// <example>
    /// <para>How many boxes are needed for x (nominator) items when each box stores y (denominator) items?</para>
    /// <c>IntCeiling(x, y)</c>
    /// </example>
    ///
    /// <example>
    /// <para>How many boxes are needed for 10 items when each box stores 3 (denominator) items?</para>
    /// <c>IntCeiling(10, 3) = 4</c>
    /// </example>
    /// <param name="nominator">The number to be divided.</param>
    /// <param name="denominator">The number to divide by.</param>
    /// <returns>The rounded up integer value</returns>
    private static int IntCeiling(int nominator, int denominator)
        => (nominator + denominator - 1) / denominator;

}