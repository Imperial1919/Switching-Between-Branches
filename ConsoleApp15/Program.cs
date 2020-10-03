using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            string day;

            switch (num)
            {
                case 1:
                    day = "Monday";
                    break;

                case 2:
                    day = "Tuesday";
                    break;

                case 3:
                    day = "Wednesday";
                    break;

                case 4:
                    day = "Thursday";
                    break;

                case 5:
                    day = "Friday";
                    break;

                case 6:
                    day = "Saturday";
                    break;

                case 7:
                    day = "Friday";
                    break;

                default:
                    day = "Unknown, ERROR!";
                    break;
            }


            Console.WriteLine("Hello Sir! It is June the 26th, 1945 today! The Current day of the week is " + day + " and it is 6:38 PM.");
            Console.ReadLine();
            Console.WriteLine("Thanks for visitng sir! :D");

        }
    }
}
