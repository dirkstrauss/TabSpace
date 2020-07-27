using System;
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
                var text = _textData.ReadTextData();

                var arrTxt = text.ToNewlineArray();
                var arrOut = new string[arrTxt.Length];
                var counter = 0;

                var tabStop = 4;
                foreach (var line in arrTxt)
                {

                    var lstTxt = line.ToSpaces(tabStop);
                    arrOut[counter] = lstTxt;

                    counter += 1;
                }

                _textData.WriteTextData(arrOut);
            }
            catch (System.Exception ex)
            {

                WriteLine(ex.Message);
                _ = ReadLine();
            }            
        }
    }
}
