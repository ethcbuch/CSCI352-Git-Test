//Ethan Buchanan
//1/17/22
//Getting into Git

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1._1
{
    class Program
    {
        Random rnd = new Random();

        private int randomNumber;
        private string userNumberToConvert;
        private int userNumber;
        private int attemptsCount;
        private string lowerBoundToConvert;
        private string upperBoundToConvert;
        private int lowerBound;
        private int upperBound;

        public void inputUserBounds()
        {
            Console.WriteLine("Imput a lower bound to guess between: ");
            lowerBoundToConvert = Console.ReadLine();
            lowerBound = Convert.ToInt32(lowerBoundToConvert);

            Console.WriteLine("Imput a upper bound to guess between: ");
            upperBoundToConvert = Console.ReadLine();
            upperBound = Convert.ToInt32(upperBoundToConvert);
        }
        public void inputUserNumber()
        {
            Console.WriteLine("Guess a Number: ");
            userNumberToConvert = Console.ReadLine();
            userNumber = Convert.ToInt32(userNumberToConvert);

            while (getUserNumber() > upperBound || getUserNumber() < lowerBound)
            {
                Console.WriteLine("Please choose a number between " + getLowerBound() +  " and " + getUpperBound() + "!");
                Console.WriteLine("Guess a Number: ");
                userNumberToConvert = Console.ReadLine();
                userNumber = Convert.ToInt32(userNumberToConvert);
            }
        }

        public void findRandomNumber()
        {
            randomNumber = rnd.Next(lowerBound, upperBound);
        }

        public int getRandomNumber()
        {
            return randomNumber;
        }

        public int getUserNumber()
        {
            return userNumber;
        }
        public int getLowerBound()
        {
            return lowerBound;
        }

        public int getUpperBound()
        {
            return upperBound;
        }

        public void attemptsCounter()
        {
            attemptsCount++;
        }

        public int getAttemptsCount()
        {
            return attemptsCount;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter a lower and upper bound to guess a number between!");
            p.inputUserBounds();

            Console.WriteLine("I am thinking of a number between " + p.getLowerBound() +  "-" + p.getUpperBound() + " Guess the correct number to escape this program!");
            p.inputUserNumber();
            p.findRandomNumber();

            while (p.getRandomNumber() != p.getUserNumber())
            {
                if (p.getUserNumber() < p.getRandomNumber())
                {
                    Console.WriteLine("Aim Higher!");
                    p.inputUserNumber();
                    p.attemptsCounter();
                }
                else
                {
                    Console.WriteLine("Aim Lower!");
                    p.inputUserNumber();
                    p.attemptsCounter();
                }

            }
            Console.WriteLine("You Won!");
            Console.WriteLine("It took you " + p.getAttemptsCount() + " attempt(s) to guess the right number!");
            Console.ReadKey();
        }
    }
}
