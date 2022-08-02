using System;

namespace daysfmnth
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "august";
            switch (month)
            {
                case "january":
                case "march":
                case "may":
                case "july":
                case "august":
                case "october":
                case "december":
                    Console.WriteLine("ay 31dendir");
                    break;
                case "april":
                case "june":
                case "september":
                case "november":
                    Console.WriteLine("ay 30dandir");
                    break;
                case "february":
                    Console.WriteLine("ay 28den yaxud 29dandir");
                    break;
                    Console.ReadLine();
            }
        }
    }
}
