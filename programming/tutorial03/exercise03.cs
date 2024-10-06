// Write a WhatIsAfter function.
// When you call the function you pass in what you are currently doing and it should
// return what the next thing to do is.
// You can use the following as an example,
// but feel free to outline your typical day.
// “Shower”,
// “Play with cat”,
// “Work”, “Make dinner”,
// “Eat and watch something”,
// “Work on project”,
// “Read a book”,
// “Sleep”.
// The tasks should loop around to the start once it hits the end.
// For example, here’s some usage code to test it works:

string[] tasksArray = [ "Shower", "Play with cat", "Work", "Make dinner", "Eat and watch something", "Work on project", "Read a book", "Sleep" ];

string currentTask = "Make dinner";
Console.WriteLine($"currentTask: {currentTask}");

string nextTask = whatIsAfter(currentTask);
Console.WriteLine($"nextTask: {nextTask}");

string whatIsAfter(string currentTask)
{
    string nextTask = "";
    int index = 0;
    foreach (string task in tasksArray)
    {
        if (task == currentTask)
        {
            nextTask = tasksArray[index+2];
            return nextTask;
        }
        index++;
    }
    return nextTask;
}
