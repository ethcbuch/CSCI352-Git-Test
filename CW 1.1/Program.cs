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

        public int inputUserNumber()
        {
            Console.WriteLine("Guess a Number: ");
            userNumberToConvert = Console.ReadLine();
            userNumber = Convert.ToInt32(userNumberToConvert);

            while (getUserNumber() > 100 || getUserNumber() < 0)
            {
                Console.WriteLine("Please choose a number between 0 and 100!");
                Console.WriteLine("Guess a Number: ");
                userNumberToConvert = Console.ReadLine();
                userNumber = Convert.ToInt32(userNumberToConvert);
            }

            return userNumber;
        }

        public void findRandomNumber()
        {
            randomNumber = rnd.Next(0, 100);
        }

        public int getRandomNumber()
        {
            return randomNumber;
        }

        public int getUserNumber()
        {
            return userNumber;
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

            Console.WriteLine("I am thinking of a number between 0-100. Guess the correct number to escape this program!");
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
