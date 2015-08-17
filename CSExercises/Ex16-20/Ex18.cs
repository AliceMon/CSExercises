namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            int mark;
            System.Console.WriteLine("Enter your mark: ");
            mark = int.Parse(System.Console.ReadLine());
            if(mark >= 80 && mark <=100)
            {
                System.Console.WriteLine("Your scored " + mark + " marks which is A grade");
            }
            else if (mark >= 60 && mark <= 79)
            {
                System.Console.WriteLine("Your scored " + mark + " marks which is B grade");
            }
            else if (mark >= 40 && mark <= 59)
            {
                System.Console.WriteLine("Your scored " + mark + " marks which is C grade");
            }
            else if (mark >= 0 && mark <= 39)
            {
                System.Console.WriteLine("Your scored " + mark + " marks which is F grade");
            }
            else
            {
                System.Console.WriteLine("**Error**");
            }
        }
    }
}