using System;


namespace Task

{
    public class Doctor
    {
        private string name;
        private double salary = 100;
        private int expYear;
        public static string Title = "Doctor";
        public const int Month = 12;
        public readonly int MyNumber = 7;

        public Doctor(string n, double s, int exp)
        {
            name = n;
            salary = s;




            expYear = exp;
        }

        public Doctor(string n)
        {
            name = n;
        }

        public Doctor()
        {

        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }

        }

        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }

        }

        public int ExpYear
        {
            set
            {
                expYear = value;
            }
            get
            {
                return expYear;
            }
        }
        public void Output()
        {
            Console.WriteLine("Doctor{0} with experience {1} and salary {2}", name, expYear, salary);
        }

        public double SalaryChange(double many)
        {
            salary += many;
            return salary;
        }
        public static bool operator ==(Doctor first, Doctor second)
        {
            return first.name == second.name;
        }
        public static bool operator !=(Doctor first, Doctor second)
        {
            return first.name != second.name;
        }
        public static explicit operator Doctor(string newName)
        {
            Doctor temp = new Doctor();
            temp.name = newName;
            return temp;
        }

        public static implicit operator string(Doctor doc)
        {
            return doc.ToString();
        }
    }
}
