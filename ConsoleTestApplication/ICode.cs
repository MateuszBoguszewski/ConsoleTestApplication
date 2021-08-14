using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApplication
{
    public interface ICode
    {
        string GenerateCode(bool extraversion, bool sensing, bool thinking, bool judging);
    }
}
