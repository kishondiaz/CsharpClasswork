using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01Prob2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] val = new int[10];
            string output = "";
     
            Random rand = new Random();
            output += "Value\tDoubled\n\n";
            for (int i = 0; i < val.Length; i++)
            {
                val[i] += rand.Next(0,100);

                output += (val[i] + "\t" + Math.Pow(val[i], 2));
                output += "\n";
        
            }

            
            Console.WriteLine("\nMax: "+val.Max() +" Row: "+ (Array.IndexOf(val,val.Max())+1));
            Console.WriteLine("\nMin: "+val.Min()+" Row: "+ (Array.IndexOf(val,val.Min())+1));
            MessageBox.Show(output, "", MessageBoxButtons.OK);
     
            Console.ReadLine();
        }
    }
}
