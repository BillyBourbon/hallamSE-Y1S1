// This is a combination of the previous 2 questions. We’re going to make it so that a Person object also stores an address.
// But, rather than the address just being a string, we’ll use our Address class.
// The two classes should be defined separately,
// but inside the Person class you’ll need to add an Address variable - so now a Person should contain a string for their name,
// an int for their age, and an Address object for their address details. You should be able to use the person object like below:


Person person1 = new Person();
Console.WriteLine("Please Enter Your Name");
person1.name = Console.ReadLine();
Console.WriteLine("Please Enter Your Age");
person1.age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter Your House Number");
person1.address.houseNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter Your Street Name");
person1.address.streetName = Console.ReadLine();
Console.WriteLine("Please Enter Your Post Code");
person1.address.postCode = Console.ReadLine();


Console.WriteLine($"Welcome {person1.name}. Your {person1.age} Years Old. You Live At Number {person1.address.houseNumber} on {person1.address.streetName} Street, Post Code: {person1.address.postCode}");

class Person
{
    public string name;
    public int age;
    public Address address = new Address();
}
class Address 
{
    public int houseNumber;
    public string streetName;
    public string postCode;
}
