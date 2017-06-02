using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01Prob1
{
    class Customer
    {
        private string fullName;
        private int subscriptionMonth;
        private string birthDate;
        private string fullCode;
        private int zip;
        

        public Customer()
        {
            fullName = "Joe James";
            subscriptionMonth = 10;
            birthDate = "10/20/1985";
            zip = 33311;
        }
        

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        

        public int ZipCode
        {
            get { return zip; }
            set { zip = value; }
        }


        public int SubscptionMonth
        {
            get { return subscriptionMonth; }
            set { subscriptionMonth = value; }
        }
        private string whichSubMonth()
        {
            string whichMon = "";
            switch (subscriptionMonth)
            {
                case 01:
                {
                    whichMon = "Jan";
                    break;
                }
                case 02:
                {
                    whichMon = "Feb";
                    break;
                }
                case 03:
                {
                    whichMon = "Mar";
                    break;
                }
                case 04:
                {
                    whichMon = "Apr";
                    break;
                }
                case 05:
                {
                    whichMon = "May";
                    break;
                }
                case 06:
                {
                    whichMon = "Jun";
                    break;
                }
                case 07:
                {
                    whichMon = "Jul";
                    break;
                }
                case 08:
                {
                    whichMon = "Aug";
                    break;
                }
                case 09:
                {
                    whichMon = "Sep";
                    break;
                }
                case 10:
                {
                    whichMon = "Nov";
                    break;
                }
                case 11:
                {
                    whichMon = "Oct";
                    break;
                }
                case 12:
                {
                    whichMon = "Dec";
                    break;
                }
                default:
                {
                    
                    Console.WriteLine("Invalid subscription month");
                    break;
                }
                
             }
            return whichMon;
        }

        public void createCode()
        {
            
            var names =  fullName.Split(' ');
            var bDate = birthDate.Split('/');
            string firstName = names[0];
            string lastname = names[1];
            string lastYear = birthDate.Substring(birthDate.Length - 2);
            string mixDate = (bDate[0].Last()+""+bDate[1].First());
            string subMonth = whichSubMonth();
            string strZip = zip.ToString();
            string lastZip = strZip.Substring(strZip.Length - 2);
            fullCode = lastname + lastYear + mixDate + subMonth + lastZip;
        }

        public override string ToString()
        {
            Console.WriteLine("\nMail Label Code: " + fullCode);
            return base.ToString();
        }



    }
}
