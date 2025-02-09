using CCompiler.cli;

namespace CCompiler.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CCompiler_successfullyCalledTheParserWithValidArguments_NoExceptionThrown()
        {
            string[] args = ["--path", "/path/to/program"];

            var returnCode = CommandLineParser.Parse(args);

            Assert.Equal(0, returnCode);
        }

        [Fact]
        public void CCompiler_TooManyArguments_ExceptionThrown()
        {
            string[] args = ["/path/to/program"];

            var returnCode = CommandLineParser.Parse(args);

            Assert.Equal(1, returnCode);
        }
    }
}