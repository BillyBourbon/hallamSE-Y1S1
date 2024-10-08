//Write a program to do some (very weak) encryption. Create a class called Data which stores 3 integers.
//Your program should use the following functions:
//GetData - asks the user for the 3 numbers and returns a Data object
//Make sure the numbers are clamped to a single digit, i.e. between 0 and 9
//EncryptData - receives a Data object as a parameter and “encrypts” it
//To encrypt: swap the 1st and 3rd digit. Add 5 to each digit. Make sure after adding 5 each digit stays between 0 and 9.
//I.e. 7 becomes 12 which becomes 2, 5 becomes 10 which becomes 0, and 1 becomes 6 which stays as 6.
//GenerateOutput - receives a Data object as a parameter and returns a nicely formatted string which can be output to the screen


main();
void main()
{
    Data data = getData();
    data = encryptData(data);
    generateOutput(data);
}

void generateOutput(Data data)
{
    Console.WriteLine($"Encrypted Data Input\nNumber1   :   {data.number1}\nNumber2   :   {data.number2}\nNumber3   :   {data.number3}");
}

Data encryptData(Data data)
{
    int placeHolder = 0;
    placeHolder = data.number1;
    data.number1 = data.number3;
    data.number3 = placeHolder;

    data.number1 = clampInt(data.number1 + 5);
    data.number2 = clampInt(data.number2 + 5);
    data.number3 = clampInt(data.number3 + 5);

    return data;
}

Data getData()
{
    Data data = new Data();
    
    data.number1 = clampInt(getUserInputInt("Enter Number 1"));
    data.number2 = clampInt(getUserInputInt("Enter Number 1"));
    data.number3 = clampInt(getUserInputInt("Enter Number 1"));

    return data;
}

int clampInt(int value, int min = 0, int max = 9)
{
    //if (value < min) value = min;
    //if (value > max) value = max;
    while (value > max)
    {
        //Console.WriteLine($"Value {value} >= {max}");
        value -= max + 1;
    }
    while (value < min)
    {
        //Console.WriteLine($"Value {value} <= {min}");
        value += max + 1;
    }
    return value;
}

int getUserInputInt(string prompt = "Enter An Interger")
{
    Console.WriteLine(prompt);
    int userInputInt = Convert.ToInt32(Console.ReadLine());
    return userInputInt;
}

class Data
{
    public int number1, number2, number3;
}
