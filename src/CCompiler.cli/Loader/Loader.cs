using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCompiler.cli.Loader
{
    public static class Loader
    {
        public static string[] Load(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
