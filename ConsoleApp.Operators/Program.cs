// See https://aka.ms/new-console-template for more information
Console.WriteLine("ConsoleApp.Operators");

Console.Write("Please enter the first number: ");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter the second number: ");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

/* Math Operations */
// Add numbers
int sum = (int) (num1 + num2); 
Console.WriteLine("The sum of both numbers is: {0}", sum);

// multiply
int mul = (int)(num1 * num2);
Console.WriteLine($"The product of both numbers is: {mul}");

// Modulus
int mod = (int)(num1 % num2);
Console.WriteLine("The modulus of both number is {0}", mod);

/* Logical Operations */

var isGreaterThan = num1 > num2;

Console.WriteLine($"{num1} is greater than {num2}: {isGreaterThan}");

/* Assignments Operations */
Console.WriteLine($"{num1} increaded by 2: {num1 += 2}");