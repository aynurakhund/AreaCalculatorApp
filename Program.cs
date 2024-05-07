
using AreaCalculator.Classes;

Console.WriteLine("Area Calculator");
Console.WriteLine("1. Calculate The area of Triangle");
Console.WriteLine("2. Calculate The area of Circle");
Console.WriteLine("3. Calculate The area of Rectangle");
Console.Write("Please Enter your choice: ");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
	case 1:
        Console.Write("Enter the first side of Triangle: ");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second side of Triangle: ");
        int side2 = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Enter the third side of Triangle: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        Triangle triangle1 = new Triangle();
        triangle1.Side1 = side1;
        triangle1.Side2 = side2;
        triangle1.Side3 = side3;

        Console.WriteLine(triangle1.CalcAreaOfTriangle());

        break;
    case 2:
        Console.Write("Enter the radius of Circle: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        Circle circle1 = new Circle();
        circle1.Radius= radius;

        Console.WriteLine(circle1.CalcAreaOfCircle());


        break;

        case 3:
        Console.Write("Enter the first side of Rectangle: ");
        int rSide1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second side of Rectangle: ");
        int rSide2 = Convert.ToInt32(Console.ReadLine());

        Rectangle rectangle1 = new Rectangle();
        rectangle1.Side1 = rSide1;
        rectangle1.Side2 = rSide2;

        Console.WriteLine(rectangle1.CalcAreaOfRectangle());


        break;
    default:
        Console.WriteLine("This Type of operation does not exist.");
        break;
}