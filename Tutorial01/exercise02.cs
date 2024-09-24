//Write a program that allows users to enter their address and store the data in an Address class that you’ve created.
//It should store the house number, the street name, and the postcode.
//Output the 3 pieces of data back to the screen nicely separated by commas.

address usersAddress = new address();
Console.WriteLine("You Will Be Asked To Enter Your Address");
Console.WriteLine("Enter Your Post Code");
usersAddress.postCode = Console.ReadLine();
Console.WriteLine("Enter Your Street Name");
usersAddress.streetName = Console.ReadLine();
Console.WriteLine("Enter Your House Number");
usersAddress.houseNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your Address... \nHouse Number: {usersAddress.houseNumber}\nStreet Name: {usersAddress.streetName}\nPost Code: {usersAddress.postCode}");
class address
{
    public int houseNumber;
    public string streetName;
    public string postCode;
}
