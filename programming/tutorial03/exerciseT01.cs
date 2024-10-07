//Write a class called Point which stores an x and y position as floats.
//Write another class called Rectangle which stores a Point object
//representing the top left corner of the rectangle,
//and a width and height stored as floats.
//Create the function bool Inside(Rectangle r, Point p).
//It receives a Rectangle and a Point as parameters and should
//return true if the point is inside the rectangle,
//or false otherwise. By the way,
//this is the basics of how using a mouse / touchscreen works -
//how do you think programs know what you just clicked on?

main();

void main()
{
    Rectangle r = new Rectangle();
    r.height = 10;
    r.width = 7.5f;
    Point corner = new Point();
    corner.x = 2;
    corner.y = 5;
    r.corner = corner;

    Point p = new Point();
    //p.x = 10.350f;p.y = 7.575f;//Point 1, isInside: False
    p.x = 5;p.y = 5;//Point 2, isInside: True
    //p.x = 5;p.y = 100;//Point 3, isInside: False
    //p.x = 50; p.y = 5;//Point 2, isInside: False

    bool isInside = Inside(r, p);
    Console.WriteLine($"isInside: {isInside}");
}

bool Inside(Rectangle r, Point p)
{
    bool inside = false;

    float maxY = r.corner.y;
    float minY = r.height - r.corner.y;
    float maxX = r.width + r.corner.x;
    float minX = r.corner.x;

    if ( p.x >= minX && p.x <= maxX   &&   p.y >= minY && p.y <= maxY )
    {
        inside = true;
    }
    
    return inside;
}

class Point
{
    public float x; 
    public float y;
}

class Rectangle
{
    public Point corner;
    public float width;
    public float height;
}



//bool Inside(Rectangle r, Point p)
//{
//    bool inside = false;
//
//    Console.WriteLine($"Rect Coords Height: {r.height}");
//    Console.WriteLine($"Rect Coords Width: {r.width}");
//    Console.WriteLine($"Rect Coords Corner - x: {r.corner.x}, y: {r.corner.y}");
//    Console.WriteLine($"Rect Coords =====");
//    Console.WriteLine($"Rect Coords topL: {r.corner.x}, {r.corner.y}");
//    Console.WriteLine($"Rect Coords btmL: {r.corner.x}, {r.corner.y - r.height}");
//    Console.WriteLine($"Rect Coords topR: {r.corner.x + r.width}, {r.corner.y}");
//    Console.WriteLine($"Rect Coords btmR: {r.corner.x + r.width}, {r.corner.y - r.height}");
//    Console.WriteLine($"X Range: [{r.corner.x}, {r.corner.x + r.width}]");
//    Console.WriteLine($"Y Range: [{r.corner.y - r.height}, {r.corner.y} ]");
//    Console.WriteLine($"Point Coord: [{p.x}, {p.y} ]");
//
//    int counter = 0;
//
//    if (p.x >= r.corner.x && p.x <= r.corner.x + r.width)
//    {
//        Console.WriteLine("Point X Inline");
//        counter++;
//    }
//    else
//    {
//        Console.WriteLine("Point X NOT Inline");
//    }
//
//    if (p.y >= r.corner.y - r.height && p.y <= r.corner.y)
//    {
//        Console.WriteLine("Point Y Inline");
//        counter++;
//    }
//    else
//    {
//        Console.WriteLine("Point Y NOT Inline");
//    }
//
//    if (counter == 2) inside = true;
//
//    return inside;
//}
