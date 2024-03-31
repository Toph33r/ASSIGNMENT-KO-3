namespace ASSIGNMENT_KO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Time Convertion (1-4);" +
               "\n1. seconds to minutes " +
               "\n2.  minutes to hour " +
               "\n3.  hour to days " +
               "\n4.  days to months " +
               "\nSelect 1-4");
            String User = Console.ReadLine();

            if (User == "1")
            {
                Console.Write("Enter the second/s to convert: ");
                double UserNum = Convert.ToInt32(Console.ReadLine());
                double Output;
                Output = UserNum / 60;

                Console.WriteLine(UserNum + " second/s in minute/s is " + Output + "minute/s");
            }
            else
            {
                if (User == "2")
                {
                    Console.Write("Enter the minutes to convert: ");
                    double UserNum = Convert.ToInt32(Console.ReadLine());
                    double Output;
                    Output = UserNum / 60;

                    Console.WriteLine(UserNum + " minute/s to hour/s is " + Output + "hour/s");
                }
                else
                {
                    if (User == "3")
                    {
                        Console.Write("Enter the hours to convert: ");
                        double UserNum = Convert.ToInt32(Console.ReadLine());
                        double Output;
                        Output = UserNum / 60;

                        Console.WriteLine(UserNum + " hour/s to day/s is " + Output + "day/s");
                    }
                    else
                    {
                        if (User == "4")
                        {
                            Console.Write("Enter the day/s to convert: ");
                            double UserNum = Convert.ToInt32(Console.ReadLine());
                            double Output;
                            Output = UserNum / 60;

                            Console.WriteLine(UserNum + " day/s to mths/s is " + Output + "mths/s");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option, input ONLY 1-4.");
                            return;
                        }
                    }
                }
            }

        }
    }
}
