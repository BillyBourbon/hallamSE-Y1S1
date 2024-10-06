//Write a function called Clamp.
//It takes in 3 numbers: the value, the minimum, and the maximum.
//It returns the value but clamped to be in the specified range.
//Do not use the built in Clamp function,
//write if statements to compare value,minimum, and maximum.
//Test your function like this:

main();
//testingClasses();

void main()
{
    //int value, min, max;

    //value = 10;
    //min = 5;
    //max = 14;
    float value, min, max;
    value = 7.89f;
    min = 2.1f;
    max = 7.9f;

    Console.WriteLine($"valueInput: {value}");
    //value = clampInt(value, min, max);
    value = clampFloat(value, min, max);
    Console.WriteLine($"valueClamped: {value}");
}

void testingClasses()
{
    Clamp clamp = new Clamp();
    
    int intClamp = clamp.clampInt(1, 2, 3);
    float floatClamp = clamp.clampFloat(3.4f, 4.7f, 11.8f);

    Console.WriteLine(intClamp);
    Console.WriteLine(floatClamp);
}

int clampInt(int value, int min, int max)
{
    if (value < min) value = min; 
    if (value > max) value = max;
    return value;
}

float clampFloat(float value, float min, float max)
{
    if(value < min) value = min; 
    if (value > max) value = max; 
    return value;
}

class Clamp
{
    public int clampInt(int value, int min, int max)
    {
        if (value < min) value = min;
        if (value > max) value = max;
        return value;
    }
    public float clampFloat(float value, float min, float max)
    {
        if (value < min) value = min;
        if (value > max) value = max;
        return value;
    }
}
