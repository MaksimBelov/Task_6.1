using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.");
            Console.WriteLine();
            string text = Console.ReadLine();
            text = text.Trim();
            string[] wordsArray = text.Split();
            string maxWord = "";
            int maxWordLength = 0;
            if (text.Length == 0)
                Console.WriteLine("Предложение не введено");
            else
            {
                foreach (string word in wordsArray)
                {
                    if (word.Length == maxWordLength)
                    {
                        maxWord = maxWord.Insert(maxWord.Length, ", ");
                        maxWord = maxWord.Insert(maxWord.Length, word);
                    }
                    else
                    {
                        if (word.Length > maxWordLength)
                        {
                            maxWordLength = word.Length;
                            maxWord = word;
                        }
                    }

                }
                Console.WriteLine();
                Console.WriteLine("Самое длинное слово/слова в предложении:");
                Console.WriteLine("{0}", maxWord);
            }
            Console.ReadLine();
        }
    }
}
