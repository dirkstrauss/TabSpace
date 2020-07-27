using System;
using System.Collections.Generic;
using System.Linq;
using TabSpace.Data;
using static System.Console;
using static TabSpace.Core.ExtensionMethods;

namespace TabSpace
{
    public class TabSpaceProcessor
    {
        private readonly ITextData _textData;

        public TabSpaceProcessor(ITextData textData)
        {
            _textData = textData;
        }

        public void ProcessText()
        {
            try
            {
                var lstOutput = new List<string>();
                var text = _textData.ReadTextData();
                var arrTxt = text.ToNewlineArray();
                                
                var tabStop = 4;
                lstOutput.AddRange(arrTxt.Select(line => line.ToSpaces(tabStop)));
                _textData.WriteTextData(lstOutput);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                _ = ReadLine();
            }            
        }
    }
}
