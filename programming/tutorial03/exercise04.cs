//Write a program using 3 functions:
//one which asks the user for their height in feet and inches and
//returns them as an ImperialHeight object
//(you’ll need to define that class to store the two integers);
//another function which receives an ImperialHeight object as a parameter,
//converts it to a float representing metres, and returns it;
//and finally a function which receives a float representing metres as
//a parameter and outputs it nicely to two decimal places

main();

void main()
{
    ImperialHeight userHeight = getHeightInFt();

    float userHeightAsMetres = imperialHeightToMetres(userHeight);

    Console.WriteLine($"User Height In Feet/inches: {userHeight.feet}ft {userHeight.inches}\"\nUser Height In Meters: {userHeightAsMetres}m");
}
float floatTo2Dp(float numberToDecimalize, int decimalPlaces = 2)
{
    int multiplier = 10;
    int counter = 1;
    while(counter < decimalPlaces)
    {
        multiplier *= multiplier;
        counter++;
    }

    float numberMultied = numberToDecimalize * multiplier;
    float trailingPlaces = numberMultied % 1;
    float decimalNumber = ( numberMultied - trailingPlaces ) / multiplier;

    if (trailingPlaces >= 0.5) decimalNumber += 0.01f;

    return decimalNumber;
}
ImperialHeight getHeightInFt()
{
    ImperialHeight userHeight = new ImperialHeight();

    Console.WriteLine("Enter Feet");
    userHeight.feet = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Inches");
    userHeight.inches = Convert.ToInt32(Console.ReadLine());
    
    return userHeight;
}

float imperialHeightToMetres(ImperialHeight height)
{
    const float inch = 0.0254f; // 1inch = 0.0254meter

    int inches = height.inches;
    inches += (height.feet * 12); // 1foot = 12inch

    float meters = inches * inch;
    float metersDecimal = floatTo2Dp(meters);
    return metersDecimal;
}

class ImperialHeight
{
    public int feet;
    public int inches;
}
