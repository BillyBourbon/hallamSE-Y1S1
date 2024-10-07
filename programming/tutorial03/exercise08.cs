//Write a function with the signature int CalculateCentury(int year).
//Given a year, it should return what century that was in.
//The first century is from 1 up to and including the year 100.
//The second century is from 101 up to and including 200, and so on.
//Using / 100 and % 100 may be useful.
//Here some examples you can use to test your function:

Console.WriteLine($"{CalculateCentury(1601)}th Centuary"); // prints 17
Console.WriteLine($"{CalculateCentury(1705)}th Centuary"); // prints 18
Console.WriteLine($"{CalculateCentury(1900)}th Centuary"); // prints 19

int CalculateCentury(int year)
{
    int yearHund = year / 100;
    int yearTens = year % 100;
    if (yearTens >= 1) yearHund++;
    return yearHund;
}
