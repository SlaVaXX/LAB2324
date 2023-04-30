using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2324
{
    internal class NonAlphabetSymbolsString : IChangingSymbol
    {
        protected string Line;
        public string GetLine => Line;
        public int GetLineLength => Line.Length;
        public NonAlphabetSymbolsString(string Line)
        {
            try
            {
                InitLine(Line);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public NonAlphabetSymbolsString()
        {

        }
        public void ChangeSymbol(char OldChar, char NewChar)
        {
            try
            {
                if(CheckIfSpecialSymbol(OldChar) && CheckIfSpecialSymbol(NewChar))
                {
                    Line = Line.Replace(OldChar, NewChar);
                }    
            }
            catch (Exception)
            {
                throw new Exception("\nНекоректні дані");
            }
        }
        private void InitLine(string NewLine)
        {
            NewLine = NewLine.Replace(" ", "");
            string result = "";
            string SpecialSymbols = "!@#$%^&*()_+-={}[];':\",./<>?|\\`~";
            
            try
            {
                for (int i = 0; i < NewLine.Length; i++)
                {
                    foreach (var item in SpecialSymbols)
                    {
                        if (item == NewLine[i])
                        {
                            result += NewLine[i];
                        }
                    }
                }
                Line = result;
            }
            catch (Exception)
            {
                throw new Exception("\nНекоректні дані!");
            }
        }
        private bool CheckIfSpecialSymbol(char ch)
        {
            string SpecialSymbols = "!@#$%^&*()_+-={}[];':\",./<>?|\\`~";
            foreach (var item in SpecialSymbols)
            {
                if(item == ch)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
