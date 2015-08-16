using System;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double area, s, a, b, c;
            System.Console.Write("Enter value of a: ");
            a = double.Parse(System.Console.ReadLine());
            System.Console.Write("Enter value of b: ");
            b = double.Parse(System.Console.ReadLine());
            System.Console.Write("Enter value of c: ");
            c = double.Parse(System.Console.ReadLine());
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            System.Console.WriteLine(area);
        }
    }
}