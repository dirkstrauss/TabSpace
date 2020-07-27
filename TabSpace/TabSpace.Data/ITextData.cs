using System;
using System.Collections.Generic;

namespace TabSpace.Data
{
    public interface ITextData
    {
        string ReadTextData();
        void WriteTextData(IEnumerable<string> text);
    }
}
