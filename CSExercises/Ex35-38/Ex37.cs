using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a sentence: ");
            str = Console.ReadLine();
            string[] arr = str.Split(new char[] {' '});
            string b = "";
            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i] + " ";

                if (word.Length > 1)
                {
                    word = word.ToUpper().Substring(0, 1)
                        + word.Substring(1, word.Length - 1);

                    b = b + word;
                }
            }
            Console.WriteLine(b);

        }
    }
}
