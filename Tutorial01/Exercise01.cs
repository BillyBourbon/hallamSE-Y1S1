
person person1 = new person();
Console.WriteLine("Enter the persons name");
person1.name = Console.ReadLine();
Console.WriteLine("Enter the persons age");
person1.age = Convert.ToInt32(Console.ReadLine());
person person2 = new person();
Console.WriteLine("Enter the persons name");
person2.name = Console.ReadLine();
Console.WriteLine("Enter the persons age");
person2.age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Person 1 | Name: {person1.name} | Age: {person1.age}\nPerson 2 | Name: {person2.name} | Age: {person2.age}");
class person
{
    public string name;
    public int age;
}
