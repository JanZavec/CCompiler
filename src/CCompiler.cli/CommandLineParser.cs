using CCompiler.cli.Entities;

namespace CCompiler.cli
{
    public class CommandLineParser
    {
        public static Arguments Parse(string[] arguments)
        {
            return new(arguments[0]);
            throw new ArgumentException("edawda");
        }
    }
}
