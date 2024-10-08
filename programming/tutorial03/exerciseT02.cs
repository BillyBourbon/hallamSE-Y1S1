// Write a class Point which stores x and y position as floats.
// Write a function bool IsOnLine(Point start, Point end, Point p)
// which tests if the Point p lies on the line formed by Points start and end.
// You can test this by checking if the length from start to end is roughly
// the same as (let’s say ±0.01f) the length from start to p,
// plus the length of p to end.
// A diagram demonstrating this is shown below.
// The length between two points is the difference in the x values squared,
// plus the difference in the y values squared, all square rooted, i.e. sqrt dx2+dy2

main();

void main()
{
    Point p = new Point();
    p.x = 5.6f;
    p.y = 5.6f;

    Point start = new Point();
    start.x = 0;
    start.y = 0;

    Point end = new Point();
    end.x = 12.4f;
    end.y = 12.4f;

    bool isOnLineBool = IsOnLine(start, end, p);

    Console.WriteLine(isOnLineBool);
}
bool IsOnLine(Point start, Point end, Point p)
{
    double lengthStartToEnd = lengthOfTheLine(start, end);
    double lengthSeg1 = lengthOfTheLine(start, p);
    double lengthSeg2 = lengthOfTheLine(p, end);
    double lengthPoint = lengthSeg1 + lengthSeg2;

    if (lengthPoint >= lengthStartToEnd - 0.01f && lengthPoint <= lengthStartToEnd + 0.01f) return true;

    return false;
}

double lengthOfTheLine( Point point1, Point point2 )
{
    double lengthXcomp, lengthYcomp = 0;

    lengthXcomp = point1.x - point2.x;
    lengthYcomp = point1.y - point2.y;

    double length = Math.Sqrt((lengthXcomp * lengthXcomp) + (lengthYcomp * lengthYcomp));

    return length;
}
class Point
{
    public float x; 
    public float y;
}
