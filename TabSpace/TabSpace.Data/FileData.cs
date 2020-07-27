using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TabSpace.Data
{
    public class FileData : ITextData
    {
        private readonly string _filePath;
        private readonly string _outputFileName;
        private readonly string _inputFileName;



        private string InputFilePath => Path.Combine(_filePath, _inputFileName);
        private string OutputFilePath => Path.Combine(_filePath, _outputFileName);


        public FileData(string filePath, string outputFileName, string inputFileName)
        {
            _filePath = filePath;
            _outputFileName = outputFileName;
            _inputFileName = inputFileName;
        }

        public string ReadTextData()
        {
            return File.Exists(InputFilePath) ? File.ReadAllText(InputFilePath) : throw new FileNotFoundException($"File at {InputFilePath} not found"); 
        }

        public void WriteTextData(string[] lines)
        {
            using (var fs = File.Create(OutputFilePath))
            {
                using (var outputfile = new StreamWriter(fs))
                {
                    foreach (var line in lines)
                        outputfile.WriteLine(line);
                }
            }
        }        
    }
}
