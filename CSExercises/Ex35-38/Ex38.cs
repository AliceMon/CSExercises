using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[,] student = new string[,] {{"John","63"},
                                               {"Venkat","29"},
                                               {"Mary","75"},
                                               {"Victor","82"},
                                               {"Betty","55"},
                                              };
            Console.WriteLine("Name \t Mark");
            for (int i = 0; i < student.GetLength(0); i++) //Array.Sort(names, (x,y) => String.Compare(x.Name, y.Name));
            {
                Array.Sort(student);
            }
        }
    }
}
