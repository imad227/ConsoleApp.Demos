namespace ConsoleApp.ClassesDemo.Classes.PersonDemo{
    public partial class Person {
        // Constructors
        public Person() {

        }

        public Person(string firstName, string lastName, DateOnly dob){
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
        }

        public Person(string firstName, string lastName, string taxNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            _taxNumber = taxNumber;
        }
    }
}