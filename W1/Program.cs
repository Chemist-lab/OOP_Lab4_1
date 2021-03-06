﻿using System;
using System.Linq;
using System.Text;
namespace W1
{
    class Student
    {
        private string name;
        private string lastName;
        private string group;
        private string year;
        private string adress;
        private string passport;
        private string age;
        private string telehone;
        private string rating;

        public string Name
        {
            get { return name; }
            set {name = value; }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }
        public string Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }
        public string Passport
        {
            get
            {
                return passport;
            }
            set
            {
                passport = value;
            }
        }
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Telehone
        {
            get
            {
                return telehone;
            }
            set
            {
                telehone = value;
            }
        }
        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Raiting is : ");
            string Raiting = Console.ReadLine();
            Console.WriteLine();

            Student student = new Student();

            student.Name = "Andrew";
            student.LastName = "Pryhoda";
            student.Group = "IK-11";
            student.Year = "2019";
            student.Adress = "Lviv, Ukraine";
            student.Passport = "G8764612A";
            student.Age = "18";
            student.Telehone = "3809598879";
            student.Rating = Raiting;

            Console.WriteLine("|     Name      |     LastName      |   Group   | Year |     Adress    |    Passport   | Age | Telephone | Rating |");
            Console.WriteLine("|    "+ student.Name + "     |      "+ student.LastName + "      |   "+ student.Group + "   | "+ student.Year +
                " | "+ student.Adress + " |   "+ student.Passport + "   |  "+ student.Age + " | "+ student.Telehone + "|   "+ student.Rating + "   |");
            Console.WriteLine();

            int sr = StudentRating(Convert.ToInt32(Raiting));
            if (sr == 1)
            {
                Console.WriteLine("Варто більше уваги приділяти навчанню");
            }
            if (sr == 2 )
            {
                Console.WriteLine("Можна вчитися краще");
            }
            if (sr == 3)
            {
                Console.WriteLine("Вітаємо відмінника");
            }
        }
        public static int StudentRating(int R)
        {
            if(R < 75)
            {
                return 1;
                
            }
            if (R >= 75 && R < 90)
            {
                return 2;
                
            }
            if (R >= 90)
            {
                return 3;
            }
            return 0;
        }
    }
}
