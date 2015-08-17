namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string name;
            char gender;
            System.Console.WriteLine("Please enter your name: ");
            name = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your gender(M/F): ");
            gender = char.Parse(System.Console.ReadLine());
            if ( gender == 'M' || gender == 'm')
            {
                System.Console.WriteLine("Good Morning Mr." + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                System.Console.WriteLine("Good Morning Ms." + name);
            }
            else
            {
                System.Console.WriteLine("Warning!!!!!!!!!!Something wrong with your gender");
            }
        }
    }
}