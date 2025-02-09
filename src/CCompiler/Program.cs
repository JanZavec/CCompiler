using CCompiler.cli;

namespace ccompiler;

class Program {

    static int Main(String[] args)
    {
        return CommandLineParser.Parse(args);
    }
}