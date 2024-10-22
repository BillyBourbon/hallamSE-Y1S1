// Write a function that computes and returns the running total of a list, (i.e.the first, the first plus the second, the first plus the second plus the third, etc.)

// returns values [1, 3, 6, 10, 15, 21]

main();

void main()
{
    List<int> input = new List<int> { 1, 2, 3, 4, 5, 6 };

    List<int> output = RunningTotal(input);;

    Console.WriteLine(string.Join(", ", output));
}

List<int> RunningTotal(List<int> input)
{
    List<int> result = new List<int>();
    int total = 0;

    foreach (int number in input)
    {
        total += number;
        result.Add(total);
    }

    return result;
}
