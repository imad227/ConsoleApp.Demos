// See https://aka.ms/new-console-template for more information
Console.WriteLine("ConsoleApp.ExceptionHandlingDemo");

// Write a program that takes a user's age as input and print it to the screen.
// Display an error message if an invalid input is received.

try
{
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old.");
}
catch (System.Exception)
{
    Console.WriteLine("Your age value was incorrect, please try again.");
    //throw;
}
finally
{
    Console.WriteLine("************ - Thank your for using the program - ************");
}