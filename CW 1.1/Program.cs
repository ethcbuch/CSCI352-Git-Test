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
        private string userNumber;

        public int inputUserNumber()
        {
            userNumber = Console.ReadLine();
            int a = Convert.ToInt32(userNumber);

            return a;
        }

        public void findRandomNumber()
        {
                randomNumber = rnd.Next(0,100);
        }

        public int getRandomNumber()
        {
            return randomNumber;
        }

        public string getUserNumber()
        {
            return userNumber;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Input a number from 1-100: ");
            p.inputUserNumber();

            Console.WriteLine("User number is " + p.getUserNumber());
            Console.ReadKey();

            p.findRandomNumber();
            Console.WriteLine("The random number is: " + p.getRandomNumber());
            Console.ReadKey();
        }
    }
}
