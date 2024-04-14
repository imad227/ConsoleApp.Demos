// See https://aka.ms/new-console-template for more information
Console.WriteLine("ConsoleApp.UserInputDemo\n");

// Declare variables
string? firstName = string.Empty;
string? lastName = string.Empty;
int age = 0;
int retirementAge = 69;
decimal salary = 0;
char gender = char.MinValue;
bool working = false;

// Prompt the users for input
Console.Write("Plese enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Plese enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary:");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F):");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (True or False):");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaning = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working yeras remaining: {workingYearsRemaning}");
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"your gender is: {gender}");
