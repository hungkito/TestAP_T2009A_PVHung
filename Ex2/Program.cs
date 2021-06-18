using System;

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
            int count = 0;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            word = Console.ReadLine();
            if (str.Contains(word))
            {
                string myString = str.Contains(word).ToString();

                for (int i = 0; i < myString.Length; i++)
                {
                    if (!char.IsWhiteSpace(myString[i]))
                    {
                        count++;
                    }
                }

                Console.WriteLine("Word found" + count + "times in the string");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
        }
    }
}