using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeDB
{
    class Program
    {
        private static string[] arg;
        static void Main(string[] args)
        {
            if (!args.Equals(null))
            {
                arg = args;
            }
            Student myStudent = new Student();
            myStudent.StudentName = "Kishon Diaz";
            myStudent.StudentNumber = 2340;
            myStudent.Major = "Comptuer Science";
            myStudent.Score1 = 100;
            myStudent.Score2 = 95;
            myStudent.Score3 = 82;
            Console.WriteLine(myStudent.StudentName);
            Console.WriteLine(myStudent.StudentNumber);
            Console.WriteLine(myStudent.Major);
            Console.WriteLine(myStudent.calcuateAverage());
            Console.ReadLine();

            Application.EnableVisualStyles();
            Application.Run(new Form1());
 
        }
        public static string getArgs()
        {
            return arg[0];
        }
    }
}
