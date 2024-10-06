// Write a DoMaths function.
// It should accept 2 numbers as inputs, and a character representing the operation to perform
// on the 2 numbers.
// It should return the result of applying that operation.
// An example of the usage code is shown below.
// After you have it working try to store the input data into a MathsData object
// and make the function receive that instead

int value1, value2;
char operation;

value1 = 5;
value2 = 2;
operation = '%';

float i = doMaths(value1, value2, operation);

Console.WriteLine(i);

float doMaths(float number1, float number2, char operation)
{
    if(operation == '+') return number1 + number2;
    if(operation == '-') return number1 - number2;
    if(operation == '*') return number1 * number2;
    if(operation == '/') return number1 / number2;
    if(operation == '%') return number1 % number2;
    throw new NotImplementedException();
}
