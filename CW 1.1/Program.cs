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
        private int bob;
        public void setBob(int a)
        {
            bob = a;
        }

        public int getBob()
        {
            return bob;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.ReadKey();
            Console.WriteLine("Setting Bob: ");
            Console.ReadKey();
            Program p = new Program();
            p.setBob(19);
            Console.WriteLine("Setting Bob to 19!");

            Console.WriteLine("BOb is: " + p.getBob());
            Console.ReadKey();
        }
    }
}
