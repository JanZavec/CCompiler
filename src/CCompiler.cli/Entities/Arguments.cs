
namespace CCompiler.cli.Entities;

public sealed record Arguments(string PathToSourceFile)
{
    public bool LexOnly { get; set; } = false;

    public bool FileExists() => File.Exists(PathToSourceFile);
}
