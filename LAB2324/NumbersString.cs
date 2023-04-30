using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2324
{
    internal class NumbersString : IChangingSymbol
    {
        protected string Line;
        public int GetLineLength => Line.Length;
        public string GetLine => Line;
        public NumbersString(string Line)
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
        public NumbersString()
        {

        }
        public void ChangeSymbol(char OldChar, char NewChar)
        {
            try
            {
                if (CheckIfDigit(OldChar) && CheckIfDigit(NewChar))
                {
                    Line = Line.Replace(OldChar, NewChar);
                }
            }
            catch (Exception)
            {
                throw new Exception("\nНекоректні дані!");
            }
        }
        private void InitLine(string Line)
        {
            try
            {
                Line = Line.Replace(" ", "");
                string result = "";
                for (int i = 0; i < Line.Length; i++)
                {
                    if (char.IsDigit(Line[i]))
                    {
                        result += Line[i];
                    }
                }
                this.Line = result;
            }
            catch (Exception)
            {
                throw new Exception("\nНекоректні дані!");
            }
        }
        private bool CheckIfDigit(char ch)
        {
            if (char.IsDigit(ch)) return true;
            return false;
        }
    }
}
