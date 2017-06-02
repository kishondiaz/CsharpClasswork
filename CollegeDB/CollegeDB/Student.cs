using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDB
{
    class Student
    {

        private string major;
        private int score1;
        private int score2;
        private int score3;
        private double gpa;
        private string studentName;
        private int studentNumber;


        public Student()
        {
            studentName = "Undefined";
        }
        public Student(string stuName)
        {
            studentName = stuName;
        }
        public Student(int stuNum,string stuName) 
        {
           
            studentNumber = stuNum;
            studentName = stuName;
        }

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public string Major
        {
            get{return major;}
            set{major = value;}
        }

        public int Score1
        {
            get{return score1;}
            set{score1 = value;}
        }

        public int Score2
        {
            get{ return score2;}
            set{score2 = value;}
        }
        public int Score3
        {
            get{ return score3; }
            set{ score3 = value; }
        }
        

        public string StudentName
        {
            get{return studentName;}
            set{studentName = value;}
        }

        public int StudentNumber
        {
            get{return studentNumber;}
            set{studentNumber = value;}
        }

        public decimal calcuateAverage()
        {
            return Math.Round((score1 + score2 + score3) / Convert.ToDecimal(3.0),2);
        }
    }
}
