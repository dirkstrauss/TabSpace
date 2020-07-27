using System;

namespace TabSpace.Data
{
    public interface ITextData
    {
        string ReadTextData();
        void WriteTextData(string[] text);
    }
}
