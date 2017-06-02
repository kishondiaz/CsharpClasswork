using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            try
            {
                Console.Write("Please enter the name (first, space, and last): ");
                cust.FullName = Console.ReadLine();
                Console.Write("\nPlease enter the postal zip code: ");
                cust.ZipCode = int.Parse(Console.ReadLine());
                Console.Write("\nPlease enter the birth date (mm/dd/yyyy): ");
                cust.BirthDate = Console.ReadLine();
                Console.Write("\nPlease enter the month you purchased the subscription (mm): ");
                cust.SubscptionMonth = int.Parse(Console.ReadLine());
                cust.createCode();
                cust.ToString();
            }
            catch (Exception e)
            {
               
                Console.WriteLine("Invalid Input");
            }

            Console.ReadLine();

        }
    }
}
