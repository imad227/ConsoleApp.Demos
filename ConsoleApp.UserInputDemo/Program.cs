// See https://aka.ms/new-console-template for more information
Console.WriteLine("ConsoleApp.UserInputDemo\n");

// Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 69;

// Prompt the users for input
Console.WriteLine("Plese enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaning = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working yeras remaining: {workingYearsRemaning}");