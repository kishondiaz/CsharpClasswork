using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileAccess
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/

            
            Console.WriteLine("Current Directory:");
           // Directory.SetCurrentDirectory(@"c:\");
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine();



            DirectoryInfo dir = new DirectoryInfo(".");
            foreach (FileInfo file in dir.GetFiles())
            {
                string fileName = file.Name;
                DateTime fileCreationDate = file.CreationTime;
                long fileSize = file.Length;
                Console.WriteLine(fileName.PadRight(40) + fileSize + "\t" + fileCreationDate);
            }
            Console.WriteLine();


            StreamWriter outfile = new StreamWriter("data.txt");

            string strData = "The quick brown fox jumps over the lazy dog.";
            outfile.WriteLine(strData);
            strData = "Hello World";
            outfile.WriteLine(strData);
            outfile.Close();

            StreamReader infile = new StreamReader("data.txt");
            string strReadData = infile.ReadToEnd();
            Console.WriteLine(strReadData);


            Console.ReadLine();
        }
    }
}
