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

            string str;
            int flag = 0;
            Console.WriteLine("Enter Any String to Know It is Palindrome or not");
            str = Console.ReadLine();
            string[] words = str.Split(new char[] { ',', '|', '!', '?', '.', ' ' });
            //string words = str.Replace(" ", "");
            //char[] a = words.ToCharArray();
           // string[] combineWords = new string[] {" "};
           // for (int i = 0; i <= words.Length - 1; i++)
          //  {
          //      combineWords[i] = words[i];
         //   }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == words[words.Length - i - 1])
                    flag = flag + 1;
            }

            if (flag == words.Length)
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
