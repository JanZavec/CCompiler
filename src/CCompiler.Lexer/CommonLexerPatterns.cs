
namespace CCompiler.Lexer
{
    internal static class CommonLexerPatterns
    {
        public const string Identifier = @"[a-zA-Z_]\w*\b";
        public const string Constant = @"[0-9]+\b";
        public const string IntKeyword = @"int\b";
        public const string VoidKeyword = @"void\b";
        public const string ReturnKeyword = @"return\b";
        public const string OpenParenthesis = @"\(";
        public const string CloseParenthesis = @"\)";
        public const string OpenBrace = @"\{";
        public const string CloseBrace = @"\}";
        public const string Semicolon = @"\;";

        public static string[] All => [Identifier, Constant, IntKeyword, VoidKeyword, ReturnKeyword, OpenParenthesis, CloseParenthesis, OpenBrace, CloseBrace, Semicolon];
    }
}
