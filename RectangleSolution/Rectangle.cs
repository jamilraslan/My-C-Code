using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleSolution
{
    class Rectangle
    {
        private double length; // attribute

        public double Length // property provides a way for users to get and set the attribute
        {
            get { return length; }
            set { length = value; }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double CalculateArea(double length, double width)
        {
            return length * width;
        }

        /// <summary>
        /// Returns Area of Rectangle
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            // return length * width;
            return CalculateArea(length, width);
        }

        public double Area(double length, double width)
        {
            // return length * width;

            return CalculateArea(length, width);
        }

        private double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        public double Perimeter()
        {
            //return 2*(length + width);
            return CalculatePerimeter(length, width);
        }

        public double Perimeter(double length, double width)
        {
            // return 2 * (length + width);
            return CalculatePerimeter(length, width);

        }
    }
}
