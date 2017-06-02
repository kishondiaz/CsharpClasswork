using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalc
    {
        class Program
        {

            static void Main(string[] args)
            {
                const int SQ_FT_PER_SQ_YARD = 9;
                const int INCHES_PER_FOOT = 12;
                const string BEST_CARPET = "Berber";
                const string ECONOMY_CARPET = "Pile";

                int roomLenFeet = 12,roomLenInch= 2,roomWidthFeet=14,roomWidthInch=7;
                double roomLength, roomWidth;
                decimal carpetPrice, totalCost;
                double numOfSquareFeet, numOfSquareYards;


                Console.Write("Please enetr the room length (feet portion):");
                roomLenFeet = Convert.ToInt16(Console.ReadLine());

                Console.Write("Please enetr the room length (inches portion):");
                roomLenInch = Convert.ToInt16(Console.ReadLine());

                Console.Write("Please enetr the room width (feet portion):");
                roomWidthFeet = Convert.ToInt16(Console.ReadLine());

                Console.Write("Please enetr the room width (inches portion):");
                roomLenInch = Convert.ToInt16(Console.ReadLine());


                roomLength = roomLenFeet +(double)roomLenInch / INCHES_PER_FOOT;
                roomWidth = roomWidthFeet +(double)roomWidthInch / INCHES_PER_FOOT;
                numOfSquareFeet = roomLength * roomWidth;
                numOfSquareYards = numOfSquareFeet / SQ_FT_PER_SQ_YARD;

            
                carpetPrice = 27.95m;
                totalCost = Convert.ToDecimal(numOfSquareYards) * carpetPrice;

                Console.WriteLine("The cost of "+ BEST_CARPET + 
                    "is "+totalCost.ToString("c"));

              /*  Console.WriteLine("The cost of " + BEST_CARPET +
                    "is {0:c} " + totalCost);
                */

                carpetPrice = 15.95m;
                totalCost = Convert.ToDecimal(numOfSquareYards) * carpetPrice;
                Console.WriteLine("The cost of  {0} is {1:c}" , ECONOMY_CARPET , totalCost);

                Console.ReadLine();

        
            }
        }
    }
