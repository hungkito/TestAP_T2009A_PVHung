using System;
using System.Text.RegularExpressions;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           SearchWord(); 
        }

        private static void SearchWord()
        {
            string str;
            string word;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            word = Console.ReadLine();
            if (str.Contains(word))
            {
                string myString = str;
                string seachWord = word;
                int count = Regex.Matches(myString, seachWord, RegexOptions.IgnoreCase).Count;
                Console.WriteLine("Word found " + count + " times in the string");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
        }
    }
}