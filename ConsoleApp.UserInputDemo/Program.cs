// Declare variables
string name = string .Empty;
int age = 0;
int retirementAge = 65;

// Prompt the user for input
Console.WriteLine("Please enter your name");
name = Console.ReadLine();

Console.WriteLine("Please enter your age");
//string initialAgeValue = Console.ReadLine();
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingyearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingyearsRemaining}");


