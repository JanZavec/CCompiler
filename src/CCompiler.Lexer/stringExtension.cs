using System.Text.RegularExpressions;

namespace CCompiler.Lexer
{
    internal static class stringExtension
    {
        public static (string, string) RegexStartsWithOneOf(this string line, string[] patterns)
        {
            foreach (var pattern in patterns)
            {
                var match = Regex.Match(line, $"^(" + pattern + ")");
                if (match.Success)
                {
                    return (match.Value, pattern);
                }
            }

            return (string.Empty, string.Empty);
        }
    }
}
