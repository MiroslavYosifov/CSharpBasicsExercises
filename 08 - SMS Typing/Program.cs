using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dataLetters = new List<char>();
            var patternMessage = string.Empty;
            StringBuilder message = new StringBuilder(patternMessage);

            for (char i = 'a'; i <= 'z'; i++)
            {
                dataLetters.Add(i);                
            }

            for (int i = 0; i < n; i++)
            {

                var inputLetter = Console.ReadLine();
                var digit = int.Parse(inputLetter[0].ToString());

                TypingMessage(dataLetters, message, inputLetter, digit);
            }
            Console.WriteLine(message);

        }

        private static void TypingMessage(List<char> dataLetters, StringBuilder message, string inputLetter, int digit)
        {
            if (digit == 0)
            {
                message.Append(" ");
            }

            else if (digit == 8 || digit == 9)
            {
                var offset = (digit - 2) * 3;
                var indexOfLetters = offset + inputLetter.Length;
                message.Append(dataLetters[indexOfLetters]);
            }

            else
            {
                var offset = ((digit - 2) * 3) + 1;
                var indexOfLetters = offset + inputLetter.Length - 2;
                message.Append(dataLetters[indexOfLetters]);
            }
        }
    }
}
