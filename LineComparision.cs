using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{

    // Created a Line Class 
    public class Line
    {
        public double x1, x2;
        public double y1, y2;
    }
    public class LineComparision
    {

        // Used to find the Length of a single line
        public double LengthOfLine(Line l)
        {
            double x1 = l.x1;
            double y1 = l.y1;
            double x2 = l.x2;
            double y2 = l.y2;

            double Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return Length;

        }

        // Used to check the Equality of two lines uses the help of LengthOfLine method
        public void Equality(Line l1, Line l2)
        {
            double LengthOfLine1 = LengthOfLine(l1);
            double LengthOfLine2 = LengthOfLine(l2);

            if (LengthOfLine1 == LengthOfLine2)
            {
                Console.WriteLine("Both The Lines are EQUAL");
            }
            else if (LengthOfLine1 > LengthOfLine2)
            {

                Console.WriteLine("Line 1 is GREATER than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is LESSER than Line 2");
            }

        }
    }
}
