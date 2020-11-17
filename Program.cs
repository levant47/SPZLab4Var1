using System.IO;
using System.Linq;

namespace SPZLab4Var1
{
    class Program
    {
        private const string _inputFileName = "text.txt";

        static void Main() => File.WriteAllText(
            _inputFileName + ".out",
            File.ReadAllText(_inputFileName)
                .Split(", ")
                .GroupBy(character => character)
                .Max(grouping => grouping.Count())
                .ToString()
        );
    }
}

