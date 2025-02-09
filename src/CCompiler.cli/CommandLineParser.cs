using CCompiler.cli.Entities;

namespace CCompiler.cli
{
    public static class CommandLineParser
    {
        public static int Parse(string[] arguments)
        {
            if (arguments.Contains("--path"))
            {
                Arguments args = new(arguments[0]);
                return 0;
            }
            return 1;
        }
    }
}
