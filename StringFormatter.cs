using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        // Code to improve
        /// <summary>
        /// Joins an array of strings into a single comma-separated list,
        /// wrapping each item in the provided quote character (if any).
        /// 
        /// Note: Escaping is not handled to match the original logic.
        /// </summary>
        /// <param name="items">The array of strings to format</param>
        /// <param name="quote">The quote character(s) to wrap each item</param>
        /// <returns>A single formatted string</returns>
        public static string JoinWithQuotes(string?[]? items, string? quote)
        {
            // Return early if items is null or empty
            if (items == null || items.Length == 0)
                return string.Empty;

            // Default to no wrapping if quote is null
            quote ??= string.Empty;

            // Trim and replace nulls, then quote and join
            return string.Join(", ",
                items.Select(item =>
                {
                    var trimmed = (item ?? string.Empty).Trim();
                    return $"{quote}{trimmed}{quote}";
                }));
        }
    }
}
