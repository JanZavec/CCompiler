using CCompiler.Lexer.Entities;
using System.Text.RegularExpressions;

namespace CCompiler.Lexer
{
    public class Tokenizer : ITokenizer
    {
        private List<Token> _tokens = new();

        public IReadOnlyList<Token> Tokenize(string[] text)
        {
            Regex regex;
            foreach (var line in text)
            {
                var line_ = line;
                if (line_.Length == 0) { continue; }
                while (line_.Length != 0)
                {
                    line_ = line_.TrimStart();
                    var (value, pattern) = line_.RegexStartsWithOneOf(CommonLexerPatterns.All);
                    line_ = line_.Substring(value.Length);
                    _tokens.Add(ConvertPatternToToken(pattern, value));
                }
            }
            return _tokens.AsReadOnly();
        }

        private Token ConvertPatternToToken(string pattern, string value)
        {
            return pattern switch
            {
                CommonLexerPatterns.Identifier => new IdentifierSymbol(value),
                CommonLexerPatterns.Constant => new ConstantSymbol(value),
                CommonLexerPatterns.OpenBrace => new OpenBraceSymbol(value),
                CommonLexerPatterns.CloseBrace => new CloseBraceSymbol(value),
                CommonLexerPatterns.OpenParenthesis => new OpenParenthesisSymbol(value),
                CommonLexerPatterns.CloseParenthesis => new CloseParenthesisSymbol(value),
                CommonLexerPatterns.Semicolon => new SemicolonSymbol(value),
                CommonLexerPatterns.VoidKeyword or
                CommonLexerPatterns.IntKeyword or
                CommonLexerPatterns.ReturnKeyword => new IdentifierSymbol(value),
                _ => throw new InvalidOperationException()

            };
        }
    }
}
