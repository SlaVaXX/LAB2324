namespace LAB2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            string Temp, CurrentString = "";
            NonAlphabetSymbolsString NonAlphabet = new NonAlphabetSymbolsString();
            NumbersString Numbers = new NumbersString();
            for (int i = 0; ;)
            {
                Console.WriteLine("\nВведіть доступну команду:\n(new - створити рядок)\n(end - завершити виконання програми)");
                if (i > 0)
                {
                    Console.Write("(length - довжина рядка)\n(line - вивести рядок в консоль)\n(change - заміна символу на інший)\n");
                }
                Temp = Console.ReadLine().ToLower();

                if (Temp == "new")
                {
                    string NewLine = "", StringType;
                    try
                    {
                        Console.WriteLine("\nВведіть який рядок хочете створити:\n(NonAlphabet - рядок в яком збережуться лише \"спеціальні\" символи\n(NumbersString - рядок в якому збережуться лише цифри)");
                        StringType = Console.ReadLine();
                        if (StringType != "NonAlphabet" && StringType != "NumbersString")
                        {
                            throw new Exception("\nНекоректний тип рядка!");
                        }
                        else CurrentString = StringType;
                        Console.Write("\nВведіть рядок: ");
                        NewLine = Console.ReadLine();

                        if (CurrentString == "NonAlphabet")
                        {
                            NonAlphabet = new NonAlphabetSymbolsString(NewLine);
                            i++;
                        }
                        else if (CurrentString == "NumbersString")
                        {
                            Numbers = new NumbersString(NewLine);
                            i++;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (Temp == "length" && i > 0)
                {
                    if (CurrentString == "NonAlphabet")
                    {
                        Console.WriteLine($"\nДовжина рядка = {NonAlphabet.GetLineLength}");
                    }
                    else if (CurrentString == "NumbersString")
                    {
                        Console.WriteLine($"\nДовжина рядка = {Numbers.GetLineLength}");
                    }
                }
                else if (Temp == "line" && i > 0)
                {
                    if (CurrentString == "NonAlphabet")
                    {
                        Console.WriteLine($"\nРядок = \"{NonAlphabet.GetLine}\"");
                    }
                    else if (CurrentString == "NumbersString")
                    {
                        Console.WriteLine($"\nРядок = \"{Numbers.GetLine}\"");
                    }
                }
                else if (Temp == "change" && i > 0)
                {
                    try
                    {
                        char OldChar, NewChar;
                        if (CurrentString == "NonAlphabet")
                        {
                            Console.Write("\nВведіть символ, який хочете замінити: ");
                            OldChar = char.Parse(Console.ReadLine());
                            Console.Write("\nВведіть новий символ: ");
                            NewChar = char.Parse(Console.ReadLine());
                            NonAlphabet.ChangeSymbol(OldChar, NewChar);
                        }
                        else if (CurrentString == "NumbersString")
                        {
                            Console.Write("\nВведіть символ, який хочете замінити: ");
                            OldChar = char.Parse(Console.ReadLine());
                            Console.Write("\nВведіть новий символ: ");
                            NewChar = char.Parse(Console.ReadLine());
                            Numbers.ChangeSymbol(OldChar, NewChar);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nНекоректні дані!");
                    }
                }
                else if (Temp == "clear")
                {
                    Console.Clear();
                }
                else if (Temp == "end")
                {
                    break;
                }
            }
        }
    }
}