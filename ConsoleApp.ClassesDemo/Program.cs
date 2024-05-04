// See https://aka.ms/new-console-template for more information

using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

Console.WriteLine("ConsoleApp.ClassesDemo!");
Console.WriteLine("****** - Classes and Objects - ******",
                            Console.ForegroundColor = ConsoleColor.Blue);

Console.ForegroundColor = ConsoleColor.White;

// Define an object of type Person
//Student person = new Student();
Teacher person = new Teacher();
//Person person = new Person();

person.FirstName = "ErstoNamo";
person.LastName = "Lasto Namo";
person.DateOfBirth = new DateOnly(2023,10,29);

person.PrintFullName();
person.PrintInitials();

person.GenerateTaxNumber();
var taxNumber =person.GetTaxNumber();

person.GenerateTeacherIdNumber();

Console.WriteLine("Your Tax Number is: {0}", taxNumber);
Console.WriteLine("Your Id Number is: {0}", person.GetIdNumber());

var person1 = new Person("Jim","Jumbo", new DateOnly(2020,10,29));

person1.PrintFullName();
person1.PrintInitials();

Console.WriteLine($"{nameof(person1)} is {person1.GetAge()} years old");
Console.WriteLine($"Last year {nameof(person1)} was {person1.GetAge(new DateOnly(2023,1,2))} years old");



var person2 = new Person("Jessy", "Jones", "123421343");

person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();

var rectangle = new ConsoleApp.ClassesDemo.Classes.ShapeDemo.Rectangle(10,20);
Console.WriteLine($" Rectangale Area: {rectangle.Area()}");

Square square= new Square(50);
Console.WriteLine($"Square Area: {square.Area()}");

Cuboid cuboid  = new Cuboid(1,7,5);
System.Console.WriteLine($"Cuboid area is: {cuboid.Area()}");
System.Console.WriteLine($"Cuboid Volume is: {cuboid.Volume()}");
System.Console.WriteLine($"Cuboid Perimeter is: {cuboid.Perimeter()}");


Shpere shpere  = new Shpere(7);
System.Console.WriteLine($"Sphere Volume is: {shpere.Volume()}");
System.Console.WriteLine($"Sphere circumference is: {shpere.Circumference()}");
