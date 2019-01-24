using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730256
{
    public class customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 1");

            }
            else { Console.WriteLine("Promoted to level 2"); }
        }
        public int CalculateRating()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dog_cat = new car();
            var bowling = new car();
            Console.WriteLine("how many cars :{0}", Vehicle.howmanyCars);
            Console.ReadLine();

            Book myBook = new Book();
            myBook.SetTitle("A seperate Peace");

            var customer = new customer();
            customer();
        }
    }


    class Vehicle
    {
        public static int howmanyCars = 3;
        public String color = "blue";
    }

    class car : Vehicle
    {
        public String color = "red";
        public car()
        {
            Vehicle.howmanyCars++;
            Console.WriteLine("my color is" + color);
        }
    }
    class BookCollection
    {

    }
    class Book : BookCollecion
    {
        private String Title;
        public void SetTitle(String aTitle) { this.Title = aTitle; }
        public String GetTitle() { return this.Title; }
    }


}

