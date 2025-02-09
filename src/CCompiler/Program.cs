using CCompiler.cli;
using CCompiler.cli.Entities;
using CCompiler.cli.Loader;
using CCompiler.Lexer;

namespace ccompiler;

class Program {

    static int Main(String[] args)
    {
        Arguments arguments;
        try
        {
            arguments = CommandLineParser.Parse(args);

            if (!arguments.FileExists())
            {
                return 1;
            }

        }
        catch (Exception)
        {
            return 2;
        }

        Console.WriteLine(PerfromLexing(arguments));
        return PerfromLexing(arguments);

    }

    private static int PerfromLexing(Arguments arguments)
    {
        try
        {
            ITokenizer tokenizer = new Tokenizer();
            tokenizer.Tokenize(Loader.Load(arguments.PathToSourceFile));
            return 0;
        }
        catch (Exception e)
        {
            return 2;
        }
    }
}