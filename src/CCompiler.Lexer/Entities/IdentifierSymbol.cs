
namespace CCompiler.Lexer.Entities;

public sealed record IdentifierSymbol(string Value) :  Keyword(Value)
{
}
