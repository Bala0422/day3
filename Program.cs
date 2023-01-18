using day3;

namespace day3;
class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome To Employee Wage Computation");
        Class1 Employee = new Class1();

        Employee.AddEmployee("GE-DIgital", 20, 30);
        Employee.AddEmployee("TCS", 20, 19);

        Employee.ComputeAllWage();

        Employee.ComputeEmployeeWage("TCS");
        Employee.ComputeEmployeeWage("GE-DIgital");


        // Below part is for Line comparision it will take user inputs and compute the equality of the lines
                     
        /*        Console.WriteLine("Welcome To Line Comparision Computation");
                LineComparision lineComparision = new LineComparision();

                Console.WriteLine();
                Console.WriteLine("Enter 1 for Length of a line " +
                    "Enter 2 to know equality of two lines");
                int method = Convert.ToInt32(Console.ReadLine());    

                if (method == 1)
                {
                    Console.WriteLine("Enter the coordinates of Line in the given order (x1, x2, y1, y2)");
                    Line line = new Line();
                    line.x1 = Convert.ToInt32(Console.ReadLine());
                    line.x2 = Convert.ToInt32(Console.ReadLine());
                    line.y1 = Convert.ToInt32(Console.ReadLine());
                    line.y2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(lineComparision.LengthOfLine(line));

                }
                else if (method == 2)
                {
                    Line line1 = new Line();
                    Line line2 = new Line(); 
                    Console.WriteLine("Enter the coordinates of Line1 in the given order (x1, x2, y1, y2)");
                    line1.x1 = Convert.ToInt32(Console.ReadLine());
                    line1.x2 = Convert.ToInt32(Console.ReadLine());
                    line1.y1 = Convert.ToInt32(Console.ReadLine());
                    line1.y2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Enter the coordinates of Line2 in the given order (x1, x2, y1, y2)");
                    line2.x1 = Convert.ToInt32(Console.ReadLine());
                    line2.x2 = Convert.ToInt32(Console.ReadLine());
                    line2.y1 = Convert.ToInt32(Console.ReadLine());
                    line2.y2 = Convert.ToInt32(Console.ReadLine());
                    lineComparision.Equality(line1 ,line2); 
                }
                else
                {
                    Console.WriteLine("Give the corect input!!! \n");
                    Main(args);
                }*/





    }
}