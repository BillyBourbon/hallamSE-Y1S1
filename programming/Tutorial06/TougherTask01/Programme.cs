//Write a class called BadCipher which does not store any data.
//It should provide a member function called Encrypt.
//The function receives a string representing the data to encrypt and returns a string with the encrypted data.
//The encryption process is to reverse the input, remove the first character and add it back at the end, and shift each character up by 1 (i.e. a = b, J = K, z = a).
//Add some tests to check the encryption process works. For example:

//Additionally you could mark the class and member function as static which allows you to call the function without creating an instance of the object.
//(That’s how things like Console.WriteLine("hi") and Convert.ToSingle("5.1") work).
//After making the change you can simplify the usage code to this:
//Now try adding a static Decrypt function which reverses the process. For example:

using System.Diagnostics;

tests();

void tests()
{
    //Encryption Test
    {
        //string result = new BadCipher().Encrypt("Programming is FUN");
        //Debug.Assert(result == "VG tj hojnnbshpsQO");
    }
    //Encryption Test using static method
    {
        string result = BadCipher.Encrypt("Programming is FUN");
        Debug.Assert(result == "VG tj hojnnbshpsQO");
    }
    //Decryption Test
    {
        string result = BadCipher.Decrypt("VG tj hojnnbshpsQO", -1);
        Debug.Assert(result == "Programming is FUN");
    }
}

void helper()
{
    string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    foreach (char c in alphabet)
    {
        Console.WriteLine($"Letter: {c}, As Int: {(int)c}");
    }
}
