// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("ConsoleApp.Arrays/ConsoleApp.Arrays!");
Console.WriteLine("****** - Arrays & Lists - ******");

// Declare Fixed Size Array
int[] grades = new int[5];

// Add values to Fixed Size Array
// grades[0] = 45;
// grades[1] = 25;
// grades[2] = 38;
// grades[3] = 45;
// grades[4] = 54;
for (int i = 0; i < grades.Length; i++) {
    //Console.Write("Enter Grade: ");
    //grades[i] =Convert.ToInt32(Console.ReadLine());
    grades[i] = i*i+i;
}

// Print values in Fixed Size Array
Console.WriteLine("The Grades you have entered are: ");

for (int i = 0; i < grades.Length; i++){
    Console.WriteLine(grades[i]);
}

// Declare Variable Sized Array
string[] studentNames = new string[] {"Jim", "James", "Jashwa", "jones", "Jimbo"};

// Add values to Varivale Sized Array

// Print values in Variable Sized Array
Console.WriteLine("The Students names are: ");
for (int i = 0; i < studentNames.Length; i++){
    Console.WriteLine(studentNames[i]);
}

/* ----- Lists ----- */

// Declare a List
//List<int> gradesList = new List<int>();
//List<int> gradesList = new();
var gradesList = new List<int>();

// Add values to list
// gradesList.Add(45);
// gradesList.Add(95);
// Console.WriteLine(gradesList[0]);
// Console.WriteLine(gradesList[1]);
int grade = 0;
Console.WriteLine("Enter Grade (-1 to exit)");
do {
    Console.Write("Enter Grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    if (grade != -1){
        gradesList.Add(grade);
    }
} while (grade != -1);

// Print values in List - for
Console.WriteLine("Printing the grades:");
for (int i = 0; i < gradesList.Count; i++) {
    Console.WriteLine(gradesList[i]);
}

// Print values in List - foreach
Console.WriteLine("Printing the grades (using foreach):");
foreach (var item in gradesList) {
    Console.WriteLine(item);
}
