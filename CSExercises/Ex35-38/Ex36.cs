using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //36(a)
            /*
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
             */
            ////////////////////////////////
            //36(b)
            int i = 0;
            Console.WriteLine("Enter a String");
            string s = Console.ReadLine();
            string words = s.ToLower();
            string[] hasil = words.Split(' ');
            foreach (string temp in hasil)
            {
                string str = string.Empty;
                int x = temp.Length;

                for (int y = x - 1; y >= 0; y--)
                {
                    str = str + temp[y];
                }

                int count = 0;
                if (str == temp)
                {
                    count++;
                    Console.WriteLine(temp + " is palindrome = " + count);
                }
                i++;
            }
        }
    }
}
