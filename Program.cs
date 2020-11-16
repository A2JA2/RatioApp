using System;

namespace ratioAppReal
{
    class Program
    {
        private static int Gcd(int a, int b)
        {
            if (a == 0)
                return b;
            else
                return Gcd(b % a, a);
        }
        static void Main(string[] args)
        {
            string restart;
            do // a Do while loop used to either restart the program or exit.
            {
                Console.WriteLine("\n######Ratio App######");
                bool numberValidation = false;
                while (numberValidation == false)
                {
                    Console.WriteLine("\nPlease input the numerator");
                    string numerator = Console.ReadLine();
                    int numeratorValid;

                    if (!int.TryParse(numerator, out numeratorValid))
                    {
                        Console.WriteLine("\nTry again, please input the numerator as an integer");
                    }
                    else
                    {
                        numberValidation = true;
                        bool denominatorValidation = false;
                        while (denominatorValidation == false)
                        {
                            Console.WriteLine("\nPlease input the denominator");
                            string denominator = Console.ReadLine();
                            int denominatorValid;
                            if(!int.TryParse(denominator, out denominatorValid)) // TryParse method used for data validation, if the user inputs anything other than an integar the program shows an errror message.
                            {
                                Console.WriteLine("\nTry again, please input the denominator as an integer");
                            }
                            else
                            {
                                denominatorValidation = true;
                                int gcd = Gcd(numeratorValid, denominatorValid);
                                Console.WriteLine("\n" + numeratorValid + ":" + denominatorValid + " = " + numeratorValid / gcd + ":" + denominatorValid / gcd);
                            }

                        }
                    }
                }      
                Console.WriteLine("\nPress 'Y' to restart. \nPress any other key to exit.");
                restart = Console.ReadLine().ToUpper();
            } while (restart == "Y");
        }
    }
}
