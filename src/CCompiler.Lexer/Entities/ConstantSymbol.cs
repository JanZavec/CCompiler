
namespace CCompiler.Lexer.Entities
{
    internal sealed record ConstantSymbol(string Value) : Keyword(Value)
    {
        public int ConstantValue => Int32.Parse(Value);
    }
}
