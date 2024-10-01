//Ask for a username and password and check if it matches “admin” and “w34kPa55w0rd”.
//Change your program so the entered username and password are stored in a LoginDetails object.
//You’ll need to define a LoginDetails class which is capable of storing 2 strings
int attemptsRemaining = 3;
while (attemptsRemaining > 0)
{
    string isValidMessage = "Your Login Details Are Wrong Please Try Again";
    // Validate user inputs
    LoginDetails login = main();
    if (login.isValid == true)
    {
        isValidMessage = $"Welcome Back {login.name}";
        attemptsRemaining = 0;
    }
    Console.WriteLine(isValidMessage);
    attemptsRemaining--;
}

static LoginDetails main()
{
    // Get user inputs
    Console.WriteLine("Enter Your Username");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Your Password");
    string password = Console.ReadLine();
    // Store user inputs
    LoginDetails login = new LoginDetails();
    login.name = username;
    login.password = password;
    bool isValid = validateLoginDetails(login);
    login.isValid = isValid;
    return login;
}

// Function to validate login details
static bool validateLoginDetails( LoginDetails loginDetails)
{
    bool isValid = false;
    string adminLoginName = "admin";
    string admLoginPassword = "w34kPa55w0rd";
    if ( loginDetails.name == adminLoginName && loginDetails.password == admLoginPassword)
    {
        isValid = true;
    }
    return isValid;
}

// Login details class

class LoginDetails
{
    public string name;
    public string password;
    public bool isValid;
}
