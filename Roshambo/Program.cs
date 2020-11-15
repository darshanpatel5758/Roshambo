using System;

namespace Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 4);
            Console.WriteLine("Please select one of the following \n1 for paper \n2 for stone \n3 for scissors");
            int userInput = Int32.Parse(Console.ReadLine());


            // using Switch case  First way
            switch (userInput)
            {
                case 1:
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Your paper, Computer paper. it is Draw :");
                            break;
                        case 2:
                            Console.WriteLine("Your paper, Computer stone. you won!");
                            break;
                        case 3:
                            Console.WriteLine("Your paper, Computer scissors. you lost!");
                            break;
                    }
                    break;
                case 2:
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Your stone, Computer paper. you lost!");
                            break;
                        case 2:
                            Console.WriteLine("Your stone, Computer stone. Draw");
                            break;
                        case 3:
                            Console.WriteLine("Your stone, Computer scissors. you won!");
                            break;
                    }
                    break;
                case 3:
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Your scissors, Computer paper. you won!");
                            break;
                        case 2:
                            Console.WriteLine("Your scissors, Computer stone. you lost!");
                            break;
                        case 3:
                            Console.WriteLine("Your scissors, Computer scissors. draw");
                            break;
                    }
                    break;


            }

            //using If condition Secound way

            if (userInput.Equals(1) && number.Equals(1))
                Console.WriteLine("Your paper, Computer paper. it is Draw :");
            else if(userInput.Equals(1) && number.Equals(2))
                Console.WriteLine("Your paper, Computer stone. you won!");
            else if(userInput.Equals(1) && number.Equals(3))
                Console.WriteLine("Your paper, Computer scissors. you lost!");
            else if(userInput.Equals(2) && number.Equals(1))
                Console.WriteLine("Your stone, Computer paper. you lost!");
            else if(userInput.Equals(2) && number.Equals(2))
                Console.WriteLine("Your stone, Computer stone. Draw");
            else if(userInput.Equals(2) && number.Equals(3))
                Console.WriteLine("Your stone, Computer scissors. you won!");
            else if(userInput.Equals(3) && number.Equals(1))
                Console.WriteLine("Your scissors, Computer paper. you won!");
            else if(userInput.Equals(3) && number.Equals(2))
                Console.WriteLine("Your scissors, Computer stone. you lost!");
            else if(userInput.Equals(3) && number.Equals(3))
                Console.WriteLine("Your scissors, Computer scissors. draw");



        }
    }
}
