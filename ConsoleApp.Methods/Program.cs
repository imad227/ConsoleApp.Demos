// See https://aka.ms/new-console-template for more information
Console.WriteLine("ConsoleApp.Methods!");
Console.WriteLine("****** - Methods - ******");

// Void methods - completes a task without returning a value
void PrintName() {

    // Method code.
    Console.WriteLine("FirstName LastName");
}

// value returning methods - returns a value after an operation
int GetFiveYearsAgo() {

    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}

// Methods with parameters
void PrintNameWithParams(string name) {
    Console.WriteLine(name);
}

int GetYearsAgo(int yearsAgo) {

    int year = DateTime.Now.AddYears(-yearsAgo).Year;
    return year;
}

int YearsDifference(int year) {
    return (year - DateTime.Now.Year);
}

// Methods with optional parameters - parameter is not required.. and has a defult value
int GetFutureOrPastYear(int numberOfYears = 0) {
    return DateTime.Now.AddYears(numberOfYears).Year;
}

// Methods with nullable parameters
void PrintNameNullableParam(string? name, int? count = 1) {
    // if (name == null) {
    //     name = "FirstName LastName";
    // }

    name ??= "Default Name";
    count ??= 1;

    for(int i = 0; i < count; i++) {
        Console.WriteLine(name);
    }
}

/* Function Calls */

PrintName();
Console.WriteLine($"Five Years ago was: {GetFiveYearsAgo()}");
PrintNameWithParams("FirstName LastName");
Console.WriteLine($"Twentiy Five Years ago was: {GetYearsAgo(25)}");

Console.Write("Give a Year: ");
Console.WriteLine($"The year you provided was {YearsDifference((Convert.ToInt32(Console.ReadLine())))} years ago.");

Console.WriteLine($"This Year: {GetFutureOrPastYear()}");
Console.WriteLine($"The Year after 12 yeras is: {GetFutureOrPastYear(12)}");
PrintNameNullableParam("Hamo", 10);
PrintNameNullableParam(null,null);
PrintNameNullableParam("Jamo");

