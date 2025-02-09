using CCompiler.Lexer.Entities;

namespace CCompiler.Lexer
{
    public interface ITokenizer
    {
        IReadOnlyList<Token> Tokenize(string[] text);
    }
}
