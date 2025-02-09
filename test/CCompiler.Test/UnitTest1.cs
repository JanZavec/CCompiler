using CCompiler.cli;
using CCompiler.cli.Entities;

namespace CCompiler.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CCompiler_successfullyCalledTheParserWithValidArguments_NoExceptionThrown()
        {
            string[] args = ["--path", "/path/to/program"];
            Arguments expectedArguments = new(args[1]);

            var actualArguments = CommandLineParser.Parse(args);

            Assert.Equal(expectedArguments, actualArguments);
        }

        [Fact]
        public void CCompiler_TooManyArguments_ExceptionThrown()
        {
            string[] args = ["/path/to/program"];
            var expectedException = new ArgumentException();

            var actualException = Assert.Throws<ArgumentException>(() => CommandLineParser.Parse(args));

            Assert.NotNull(actualException);
        }
    }
}