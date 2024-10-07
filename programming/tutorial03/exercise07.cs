//Write a function RegistrationToYear that receives a string as a parameter and
//returns an integer.
//The string that is received should be a valid UK car registration in the format
//“XX## XXX” where X represents a letter, and # represents a number.
//Examples include “FD06 MIM” and “BN70 LAU”.
//The function should return the year the car was manufactured which can be
//calculated by looking at the two numbers in the registration.
//It will always be the year 20##, we just need to calculate the last two digits.
//The two digits from the registration plate represent this,
//but if the first digit is 5 or above then you should subtract 5 from it.
//Here are some examples you can use to test your function:

int y1 = RegistrationToYear("FD06 MIM"); // returns 2006
Console.WriteLine(y1);
int y2 = RegistrationToYear("BN70 LAU"); // returns 2020
Console.WriteLine(y2);
int y3 = RegistrationToYear("WF68 BON"); // returns 2018
Console.WriteLine(y3);
int y4 = RegistrationToYear("YK18 TEM"); // returns 2018
Console.WriteLine(y4);
int y5 = RegistrationToYear("MA73 SUK"); // returns 2023
Console.WriteLine(y5);


int RegistrationToYear(string registration)
{
    int baseYear = 2000;

    string regSubstring = registration.Trim().Substring(2, 2);

    int number1 = Convert.ToInt32(regSubstring.Substring(0, 1));
    int number2 = Convert.ToInt32(regSubstring.Substring(1, 1));

    if (number1 >= 5) number1 -= 5;

    int year = baseYear + (number1 * 10) + number2;

    return year;
}
