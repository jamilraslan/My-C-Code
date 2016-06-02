using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RectangleSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            // change the title
            Console.Title = "Rectangle App";
            StartAPP();
        }

        static void StartAPP()
        {
            lbllength:  // label, allows us to go to a particular point can only be used inside methods
                        // ask the user for the length
            Console.WriteLine("What is the length of your rectangle ?");

            double length = 0.0;
            try
            {
                // Save the length
                length = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers for length e.g. 5.6");

                Console.WriteLine();

                goto lbllength; // jump statement go to the label
            }
            catch (Exception)
            {

                Console.WriteLine("Error Occurred, Please contact IT support");
            }

            lblwidth:
            // ask the user for the width
            Console.WriteLine("What is the width of your rectangle ?");

            double width = 0.0;

            try
            {
                // Save the width
                width = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("Please enter numbers for width e.g. 5.6");

                Console.WriteLine();

                goto lblwidth;
            }

            catch (Exception)
            {

                Console.WriteLine("Error Occurred, Please contact IT support");
            }


            // create an instance of rectangle class
            Rectangle rect = new Rectangle();

            // set the length and width
            rect.Length = length;
            rect.Width = width;

            // display the area and perimeter
            Console.WriteLine("Area of your rectangle is {0}cm^2", rect.Area());
            Console.WriteLine("Perimeter of your rectangle is {0}cm", rect.Perimeter());

            Console.WriteLine();

            Console.WriteLine("Method Overload");

            Console.WriteLine("Area of your rectangle is {0}cm^2", rect.Area(length, width));
            Console.WriteLine("Perimeter of your rectangle is {0}cm", rect.Perimeter(length, width));

            // add a line space
            Console.WriteLine();

            // recursion is a method that calls itself
            StartAPP();




        }
    }
}

