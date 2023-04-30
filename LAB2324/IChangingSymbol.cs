using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB2324
{
    internal interface IChangingSymbol
    {
        abstract public int GetLineLength { get; }
        abstract public void ChangeSymbol(char OldChar, char NewChar);
    }
}
