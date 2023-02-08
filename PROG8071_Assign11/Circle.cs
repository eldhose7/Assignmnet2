using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Circle
    {
        private int radius;



        public Circle()
        {
            this.radius = 1;
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int GetRadius()
        {


            return this.radius;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * this.radius;
        }

        public double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }
    }
}
