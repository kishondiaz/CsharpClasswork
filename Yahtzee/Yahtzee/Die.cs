using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Die
    {
        static Random rndGen = new Random();
        private int value;
        private int sides;

        public Die(int numOfSize)
        {
            sides = numOfSize;
        }
   

        public int Sides
        {
            get { return sides; }
            set { sides = value; }
        }



        public int Value
        {
            get { return value; }
           

        }


        public int roll()
        {
            
            value = rndGen.Next(1, sides + 1);
    
            return value;
        }

    }
}
