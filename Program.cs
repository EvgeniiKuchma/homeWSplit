﻿using System;

namespace homeWSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char separator = ' ';
            
            string originalString = "Дана строка с текстом, используя метод строки String.Split() " +
                  "получить массив слов, которые разделены пробелом " +
                  "в тексте и вывести массив, каждое слово с новой строки.";
            
            string[] substringArray = originalString.Split(separator);

            foreach (string substring in substringArray)
            {
                Console.WriteLine($"subs = {substring}");
            }
        }
    }
}
