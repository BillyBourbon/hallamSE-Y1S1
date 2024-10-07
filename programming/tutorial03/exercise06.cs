//Write a function GetInsideString which takes in a string as a parameter
//and returns a modified version of the input string without any whitespace
//at the start or end, and with the first and last character removed.
//Useful functions may include Trim, Substring, and Length.
//Some examples are shown below:

string s1 = GetInsideString("    snail sing  "); // returns "nail sin"
Console.WriteLine(s1);
string s2 = GetInsideString(" bryan cube");      // returns "ryan cub"
Console.WriteLine(s2);
string s3 = GetInsideString("mate  ");           // returns "at"
Console.WriteLine(s3);
string s4 = GetInsideString(" vices ");          // returns "ice"
Console.WriteLine(s4);
string s5 = GetInsideString("   heart   ");      // returns "ear"
Console.WriteLine(s5);
string s6 = GetInsideString(" preachy  ");       // returns "reach"
Console.WriteLine(s6);

string GetInsideString(string text)
{ 
    string trimmedText = text.Trim();
    string substring = trimmedText.Substring( 1, trimmedText.Length - 2);

    return substring;
}
