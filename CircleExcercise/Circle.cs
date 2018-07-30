using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExcercise
{
    public class Circle
    {
        public int Radius { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Circle():this(1,2,2)
        {
           
        }

        public  Circle(int radius, int x, int y)
        {
            this.Radius = radius;
            this.X = x;
            this.Y = y;
        }

        public void GetLocation()
        {

            Console.WriteLine("Circle[centre=("+X+","+Y+") ,radius=" +Radius+"]");

        }

    }
}
