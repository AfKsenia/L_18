using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_18
{
    class Program
    {
        static void Main(string[] args)

        {
            Stack<char> Chars = new Stack<char>();

            Console.WriteLine("Введите символы");
            string strChars = Console.ReadLine();

            foreach (char item in strChars)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    Chars.Push(item);
                }
                if (item == ')' && Chars.Contains('('))
                {
                    Chars.Pop();
                }
                if (item == '}' && Chars.Contains('{'))
                {
                    Chars.Pop();
                }
                if (item == ']' && Chars.Contains('['))
                {
                    Chars.Pop();
                }
            }
                if (Chars.Count==0)
                {
                    Console.WriteLine("Скобки расставлены корректно");
                }
                else
                {
                    Console.WriteLine("Скобки расставлены некорректно");
                }
                Console.ReadKey();
            
        }
    }
}
