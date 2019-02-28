using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your first name" ); 
            string fname = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string Lname = Console.ReadLine();
            Console.WriteLine("{0} {1}", fname, Lname);
            Console.ReadLine(); */

            Console.WriteLine("Please write your name");
            string fname = Console.ReadLine();
            Console.WriteLine("please write your last name");
            string lname = Console.ReadLine();
            Console.WriteLine("please write your adress");
            string adress = Console.ReadLine();
            Console.WriteLine("what is your age");
            string age = Console.ReadLine();
            Console.WriteLine("what is your email addy");
            string addy = Console.ReadLine();
            Console.WriteLine("{0} {1} {2} {3} {4}", fname, lname, adress, age, addy);
            Console.ReadLine();
            

        }
    }
}
