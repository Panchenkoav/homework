using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Car
    {
        private string name;
        private string color;
        private int price;
        public const string companyName = "SS";

        public Car()
        {

        }
        public Car(string c, int p)
        {
            color = c;
            price = p;
        }

        public string Color
        {
            set
            {
                color = value;
            }
            get
            {
                return color;
            }
        }
        public void Input()
        {
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the color");
            color = Console.ReadLine();
            Console.WriteLine("Enter the price");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Car name is {0} and color is {1}. It's price is {2}", name, color, price);
        }
        public int ChangePrice(int x)
        {
            price += price * x / 100;
            return price;
        }
    }
}
