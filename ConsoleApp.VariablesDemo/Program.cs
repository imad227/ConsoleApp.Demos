// See https://aka.ms/new-console-template for more information

// Different datatypes

/*
    * text: string
    * integers: int
    * decimal: double, float, decimal
    * logical: bool
*/

string name = "-- Your Name --";
Console.WriteLine(name);

// Text concatination:
Console.WriteLine("I am " + name);

// Text interpolation:
Console.WriteLine($"I am {name}");

// Formatted string:
Console.WriteLine("I am {0}",name);

int age = 99;
int retiermentYearsLeft = 11;
int retirementAge = age + retiermentYearsLeft;

Console.WriteLine("My age is: " + age);

Console.WriteLine($"My retierment age is: {retirementAge}");

bool isRetired = true;
Console.WriteLine("Am I retired? " + isRetired);