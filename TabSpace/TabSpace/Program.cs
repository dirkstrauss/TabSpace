using System;
using TabSpace.Data;

namespace TabSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToFile = @"C:\temp\";
            var inputFileName = "tabtest.txt";
            var outputFileName = "tabtest_tospaces.txt";

            var data = new FileData(pathToFile, outputFileName, inputFileName);

            var tabProcessor = new TabSpaceProcessor(data);
            tabProcessor.ProcessText();
        }
    }
}
