using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            Console.WriteLine("Количество знаков препинания в тексте:");
            Console.WriteLine(text.Count(Char.IsPunctuation));

            Console.WriteLine("Текст разбитый на предложения:");
            string[] sentences = text.Split(new Char[] {'!', '?', '.'});

            foreach (string s in sentences)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine("Самое длинное слово:");

            string LongestWord = string.Empty;
            string[] words = text.Split(' ', '!', '?', ':', ';', ',', '.');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > LongestWord.Length)
                    LongestWord = words[i];
            Console.WriteLine(LongestWord);

            Console.WriteLine("Вывод первой части слова или постановка знака *");

            if (LongestWord.Length % 2 == 0)
            {
                string a = LongestWord.Substring(0, LongestWord.Length / 2);
                Console.WriteLine(a);
            }
            else if (LongestWord.Length % 2 != 0)
            {
                string Star = "* " ; 
                string b = LongestWord.Substring(0, LongestWord.Length / 2);
                string c = LongestWord.Substring(LongestWord.Length / 2, LongestWord.Length - LongestWord.Length / 2);
                string d = c.Remove(0, 1).Insert(0, Star);
                string result = b + " " + d;

                Console.WriteLine(result);
            }
        }
    }
}
