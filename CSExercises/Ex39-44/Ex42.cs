using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            string first, second;
            Console.WriteLine("enter first string: ");
            first = Console.ReadLine();
            Console.WriteLine("enter second string: ");
            second = Console.ReadLine();
            Console.WriteLine(FindWord(first, second));
        }
        public static int FindWord(string s1, string s2)
        {
            int l = 0;
            int k = 0;
            int count = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                for (int j = k; j < s1.Length; j++)
                {
                    if (s1[j] == s2[i])
                    {   
                        k = j + 1;
                        count++;
                        if(count == 1)
                        {
                            l = j;
                        }
                        break;
                    }
                }
            }
            if (count == s2.Length)
            {
                return l;
            }
            else
            {
                return -1;
            }
        }
    }
}
