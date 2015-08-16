using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double salary, housingAllowance, transportAllowance;
            System.Console.Write("Enter Salary: ");
            salary = Double.Parse(Console.ReadLine());
            housingAllowance = salary * 0.1;
            transportAllowance = salary * 0.03;
            salary = salary + housingAllowance + transportAllowance;
            Console.WriteLine("Your salary is: ${0}", salary); 
        }
    }
}
