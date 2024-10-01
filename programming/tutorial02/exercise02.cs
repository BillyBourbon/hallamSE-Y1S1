//Ask the user to input 3 numbers.
//Output which are even and which are odd,
//and how many of them are greater than 10.
//An example run of the program would look something like this:

















main();

static void main()
{
    int[] numbers = { getNumber(), getNumber(), getNumber() };
    foreach (int number in numbers)
    {
        if (number > 10)
        {
            Console.WriteLine($"Number {number} Is Greater Than 10");
        }
        Console.WriteLine($"Number {number} is an {isNumberEvenOrOdd(number)} Number");
    }
}
static string isNumberEvenOrOdd( int number )
{
    string evenOrOdd = "Even";
    int eod = number % 2;
    if(eod == 1) {  evenOrOdd = "Odd"; }
    return evenOrOdd;
}
static int getNumber()
{
    Console.WriteLine("Enter a Number");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}
