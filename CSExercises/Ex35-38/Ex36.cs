using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string delete = sentence.ToLower();
            string palindrome = "";
            char[] punctuation = new char[] { '\'', '\\', '.', '?', '!', ',', ';', ':', '-', '_', '(', ')', '{', '}', '"', '*', ' ' };
            for (int i = 0; i < punctuation.Length; i++)
            {
                delete = delete.Replace(punctuation[i].ToString(), "");
            }
            for (int j = delete.Length - 1; j >= 0; j--)
            {
                palindrome += delete[j];
            }
            if (delete == palindrome)
            {
                Console.WriteLine("This is Palindrome");
            }
            else
            {
                Console.WriteLine("This is not Palindrome");
            }
        }
    }
}
