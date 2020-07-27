using System;
using TabSpace.Data;

namespace TabSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToFile = @"C:\temp\";
            var inputFilePath = "tabtestz.txt";
            var outputFilePath = "tabtest_tospaces.txt";

            var data = new FileData(pathToFile, outputFilePath, inputFilePath);

            var tabProcessor = new TabSpaceProcessor(data);
            tabProcessor.ProcessText();
        }
    }
}
