using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using ConsoleApp.ClassesDemo.Utils;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    // Define a class
    public partial class Person
    {
        // Properties, Data Members
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }

        // Field members
        private string _taxNumber = string.Empty;
        protected string _idNumber = string.Empty;

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        public void PrintInitials() {
            var firstInitial = FirstName[0];
            var lastInitial = LastName[0];
            Console.WriteLine($"{char.ToUpper(firstInitial)}.{char.ToUpper(lastInitial)}. ");
        }

        public void GenerateTaxNumber() {
            if(string.IsNullOrEmpty(_taxNumber)){
                _taxNumber = PersonHelper.GenerateIdNumber("");
            } else {
                Console.WriteLine($"Tax number already exists for {FirstName} {LastName}!");
            }
        }
        public string GetTaxNumber() {
            return _taxNumber;
        }
        public string GetIdNumber() {
            return _idNumber;
        }
        public int GetAge() {
            var age = DateTime.Now.Year - DateOfBirth.Year;
            return age;
        }
        public int GetAge(DateOnly year) {
            return year.Year - DateOfBirth.Year;
        }
    }
}