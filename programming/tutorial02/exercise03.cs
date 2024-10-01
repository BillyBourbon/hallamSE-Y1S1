//Write some code to ask for an age and classify it into a certain bracket.
//Up to 12 should be “child”,
//up to 20 should be “teenager”,
//up to 65 should be “adult”,
//over is “senior”.
//An example run of the program would look something like this:

main();
static void main()
{
    int number = getNumber();
    string bracket = ageBracketByAge(number);
    Console.WriteLine($"Your Aged {number} So Must Be A {bracket}");
}

static string ageBracketByAge( int age )
{
    string ageBracket = "Unkown";
    if (age >= 65) return ageBracket = "Senior";
    if (age >= 20 && age < 65) return ageBracket = "Adult";
    if (age >= 12 && age < 20) return ageBracket = "Teenager";
    if (age < 12) return ageBracket = "Child";
    return ageBracket;
}
static int getNumber()
{
    Console.WriteLine("Enter a Number");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}
