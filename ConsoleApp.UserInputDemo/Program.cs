// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Xml.Serialization;

Console.WriteLine("ConsoleApp.UserInputDemo\n");

// Variables 
char choise = char.MinValue;

string? firstName = string.Empty;
string? lastName = string.Empty;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue;
bool working = false;

List<Person> persons = new List<Person>();

while (choise != 'E')
{
    // Prompt the users for input
    Console.Write("Plese enter your first name: ");
    firstName = Console.ReadLine();

    Console.Write("Plese enter your last name: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your Date of birth (dd/mm/yyyy):");
    dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
    //age = DateTime.Now.Year - dob.Year;

    Console.Write("Please enter your salary:");
    salary = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Please enter your gender (M or F):");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you working? (True or False):");
    working = Convert.ToBoolean(Console.ReadLine());

    Person person = new(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        DateOfBirth = dob,
        Gender = gender,
        IsWorking = working,
        Salary = salary
    };

    persons.Add(person);

    Console.Write("C: To contiune | E: to exit : ");
    choise = Convert.ToChar(Console.ReadLine());
}


foreach (var person in persons)
{
    // Output the results to the user
    Console.WriteLine();
    Console.WriteLine($"Full name: {person.ToString()}");
    Console.WriteLine($"Age: {person.GetAge()}");
    Console.WriteLine($"Estimated retierment year: {person.GetEstimatedRetirementDate().Year}");
    Console.WriteLine($"Working yeras remaining: {person.GetNumberOfWorkingYearsRemaning()}");
    Console.WriteLine($"You Are Employed: {person.IsWorking}");
    Console.WriteLine($"Your salary is: {person.Salary.ToString("C")}");
    Console.WriteLine($"your gender is: {person.Gender}");
}
