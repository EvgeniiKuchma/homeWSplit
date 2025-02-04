using System;

namespace homeWSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = "Дана строка с текстом, используя метод строки String.Split() " +
                  "получить массив слов, которые разделены пробелом " +
                  "в тексте и вывести массив, каждое слово с новой строки.";
            
            string[] substringArray = originalString.Split(' ');

            foreach (string substring in substringArray)
            {
                Console.WriteLine($"subs = {substring}");
            }
        }
    }
}
