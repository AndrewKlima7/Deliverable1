using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool one = false;
            while (one == false)
            {

                string userMeasure;
                bool three = false;
                while (three == false)
                {
                    Console.WriteLine("Hello, please input a measuring type: ");
                    userMeasure = Console.ReadLine();
                    if (userMeasure.ToLower() == "fidget spinners" || userMeasure.ToLower().Contains("fidget") || userMeasure.ToLower() == "memes" || userMeasure.ToLower().Contains("meme") || userMeasure.ToLower() == "inches" || userMeasure.ToLower().Contains("inch") || userMeasure.ToLower() == "feet" || userMeasure.ToLower() == "foot") {
                        three = true;
                        Console.WriteLine("What is the number amount?: ");
                        string userAmount = Console.ReadLine();
                        double amount1 = double.Parse(userAmount);
                        if (userMeasure.ToLower() == "fidget spinners" || userMeasure.ToLower().Contains("fidget"))
                        {
                            double conversionInch = amount1 / 3.5;
                            Console.WriteLine($"{amount1} fidget spinners is converted to {conversionInch} inches.");
                        }
                        else if (userMeasure.ToLower() == "memes" || userMeasure.ToLower().Contains("meme"))
                        {
                            double conversionFoot = amount1 / 5;
                            Console.WriteLine($"{amount1} memes is converted to {conversionFoot} feet.");
                        }
                        else if (userMeasure.ToLower() == "inches" || userMeasure.ToLower().Contains("inch"))
                        {
                            double conversionFidget = amount1 * 3.5;
                            Console.WriteLine($"{amount1} inches is converted to {conversionFidget} fidget spinners.");
                        }
                        else if (userMeasure.ToLower() == "feet" || userMeasure.ToLower() == "foot")
                        {
                            double conversionMeme = amount1 * 5;
                            Console.WriteLine($"{amount1} feet is converted to {conversionMeme} memes.");
                        }
                       
                    } else
                    {
                        Console.WriteLine("you must input a correct measurement try again.");
                        three = false;
                    }
                   

                }
                bool two = false;
                while (two == false)
                {
                    Console.WriteLine("Would like you like to do another conversion? (Y/N): ");
                    string again = Console.ReadLine();
                    if (again.ToLower() == "yes" || again.ToLower().Contains("y"))
                    {
                        Console.WriteLine("Again it is.");
                        one = false;
                        two = true;
                    }
                    else if (again.ToLower() == "no" || again.ToLower().Contains("n"))
                    {
                        Console.WriteLine("Goodbye");
                        one = true;
                        two = true;
                    }
                    else
                    {
                        Console.WriteLine("Please select either 'y' or 'n'");
                        two = false;
                    }
                }
            }
                
           

        }
    }
}
