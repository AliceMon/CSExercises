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
            string str;
            int flag = 0;
            Console.WriteLine("Enter Any String to Know It is Palindrome or not");
            str = Console.ReadLine();
            char[] a = str.ToCharArray();
            for (int i = 0; i< a.Length; i++)
            {
                if (a[i] == a[a.Length - i - 1])
                    flag = flag + 1;
            }
            if (flag == a.Length)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
