namespace FactoryExampleTests
{
    public static class Utility
    {
        /// <summary>
        /// Checks if an input string is the same as a constant string.
        /// </summary>
        /// <param name="inputString">String to be tested.</param>
        /// <param name="constantString">String that the inputString should be tested against.</param>
        /// <returns>A bool that tells if the two strings are equal.</returns>
        public static bool AreEqual(string inputString, string constantString)
        {
            return inputString == constantString;
        }
    }
}