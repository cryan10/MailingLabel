using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();


            Console.WriteLine("Address: ");
            string address = Console.ReadLine();


            Console.WriteLine("City: ");
            string city = Console.ReadLine();


            Console.WriteLine("State: ");
            string state = Console.ReadLine();


            Console.WriteLine("Zip code: ");
            string zipcode = Console.ReadLine();

            LabelMaker(name, address, city, state, zipcode);


        }

        static void LabelMaker(string name, string address, string city, string state, string zipcode)
        {

            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(city);
            Console.WriteLine(state);
            Console.WriteLine(zipcode);
        }
    }
}