// Write a function TruncateStringIfNecessary which takes in a
// string and a maximum length as input parameters,
// and returns a new string which obeys the constraints that were passed in.
// If the string does need to be shortened then bear in mind that the “ellipsis”
// (i.e. the three dots) will take up 3 of the available characters.
// Useful functions may include Substring, and Length.
// Some examples are shown below:

TruncateStringIfNecessary("Path", 6);
TruncateStringIfNecessary("Braid", 5);
TruncateStringIfNecessary("LIMBO", 4);
TruncateStringIfNecessary("NUVAVULT", 6);
TruncateStringIfNecessary("Portal", 5);
TruncateStringIfNecessary("Heiko", 3);
TruncateStringIfNecessary("Fez", 2);
string TruncateStringIfNecessary(string stringToTrunc, int maximumLength)
{
    Console.WriteLine($"String To Trunc: {stringToTrunc}");

    string truncated = stringToTrunc;
    int stringLength = stringToTrunc.Length;

    if(stringLength > 3 && stringLength > maximumLength)
    {
        truncated = $"{stringToTrunc.Substring(0, maximumLength-3)}...";
    }

    Console.WriteLine($"Truncated String: {truncated}");

    return truncated;
}
