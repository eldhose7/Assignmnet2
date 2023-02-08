using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;


namespace Assignment2
{
    class program
    {
        static void Main(string[] args)
        {

            int option;
            Console.WriteLine("enter the radius");
            //circle.SetRadius(Convert.ToInt32(Console.ReadLine()));
            int radius;
            while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Invalid input. Please enter an integer greater than zero:");
            }
            Circle circle = new Circle(radius);
            do
            {


                Console.WriteLine("enter your option");

                Console.WriteLine("1.get circle Radius");

                Console.WriteLine("2.Change Circle Radius");

                Console.WriteLine("3.get circle circumference");

                Console.WriteLine("4.get circle area");

                Console.WriteLine("5.Exit");





                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("The radius is" + circle.GetRadius());

                }
                if (option == 2)
                {
                    Console.WriteLine("Please enter the radius you want to set");
                    circle.SetRadius(Convert.ToInt32(Console.ReadLine()));
                }
                if (option == 3)
                {
                    Console.WriteLine("the Circumference is" + circle.GetCircumference());
                }
                if (option == 4)
                {
                    Console.WriteLine("the area is" + circle.GetArea());
                }


            } while (option != 5);
        }
    }
}
