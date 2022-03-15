using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String());
        }
        public static string String()
        {
            string sentence = "bU tasKI metHodla yAzmAliSiz";
            sentence = sentence.ToLower();
            sentence = sentence.Replace("b", "B");
            sentence = sentence.Replace("ta", "Ta");
            sentence = sentence.Replace("me", "Me");
            sentence = sentence.Replace("y", "Y");

            return sentence;
        }
    }
}
