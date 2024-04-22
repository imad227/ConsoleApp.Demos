// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("ConsoleApp.UserInputDemo\n");

// Declare variables
const int retirementAge = 69;

string? firstName = string.Empty;
string? lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue;
bool working = false;

// Prompt the users for input
Console.Write("Plese enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Plese enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your Date of birth (dd/mm/yyyy):");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year;

Console.Write("Please enter your salary:");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F):");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (True or False):");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaning = retirementAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaning);

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Estimated retierment year: {estimatedRetirementDate.Year}");
Console.WriteLine($"Working yeras remaining: {workingYearsRemaning}");
Console.WriteLine($"You Are Employed: {working}");
Console.WriteLine($"Your salary is: {salary.ToString("C")}");
Console.WriteLine($"your gender is: {gender}");
