// See https://aka.ms/new-console-template for more information
Console.WriteLine("ConsoleApp.StringManipulation!");

// Initialize with regular string literal.
string s1 = "This is a literal string";
String s2 = "This is a literal string";
System.Console.WriteLine($"{nameof(s1)}: {s1}");
System.Console.WriteLine($"{nameof(s2)}: {s2}");

// Declare without initializing. (possible null exception)
string s3;
//System.Console.WriteLine($"{nameof(s3)}: {s3}");

// Initialize to null. (possible null exception)
string? s4 = null;
System.Console.WriteLine($"{nameof(s4)}: {s4}");

// Initialize as an empty string.
string s5 = string.Empty;
string s6 = "";   // is called magic string (not recommended use string.Empty instade)
System.Console.WriteLine($"{nameof(s5)}: {s5}");
System.Console.WriteLine($"{nameof(s6)}: {s6}");

// Escape sequences and characters
string sentence = "She said, \"I have your phone\"\r\n This is the \'netx\' line";
System.Console.WriteLine($"{nameof(sentence)}: {sentence}");

// Verbatim string literal.
string oldpath = "C:\\program files\\programfolder\\";
string newpath = @"C:\program files\programfolder\";
System.Console.WriteLine($"{nameof(oldpath)}: {oldpath}");
System.Console.WriteLine($"{nameof(newpath)}: {newpath}");

// Use a const string to prevent modification to a string
const string path = "C:\\program files\\programfolder";
System.Console.WriteLine($"{nameof(path)}: {path}");

// Raw string literals (after C#11)
string rawLiteral = """ \sdfj ' "" This is a literal string """;
string rawLiteralMultiLines = """ 
    This is the first line
    This is the second line
    (in the case of multiple lines the (3x") must be in seperate lines)
    """;
System.Console.WriteLine($"{nameof(rawLiteral)}: {rawLiteral}");
System.Console.WriteLine($"{nameof(rawLiteralMultiLines)}: {rawLiteralMultiLines}");

// Review concatination and interpolation
s1 += s2;   // In this case s1 is not been modified but the program create a new instance of s1
string newString = $"{s1} {s2} Some random literal text";
System.Console.WriteLine($"{nameof(newString)}: {newString}");

       newString = s1 + " " + s2 + " Some random literal text";
System.Console.WriteLine($"{nameof(newString)}: {newString}");


/* String manipulation methods and properties and assessment */

// Null of empty checks
// find the length of a string

Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
//Console.WriteLine($"{nameof(s3)} has a lenght of {s3.Length}");
if (s4 is not null)
    Console.WriteLine($"{nameof(s4)} has a lenght of {s4.Length}");

if (!string.IsNullOrEmpty(s4))
    Console.WriteLine($"{nameof(s4)} has a lenght of {s4.Length}");

if (string.IsNullOrEmpty(s4) == false)
    Console.WriteLine($"{nameof(s4)} has a lenght of {s4.Length}");

Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");


// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)}: {subString}");

subString = s1.Substring(5,5);
Console.WriteLine($"{nameof(subString)}: {subString}");

// Spliting strings
var splitStrings = s2.Split(' ');
for(int i = 0; i < splitStrings.Length; i++)
    Console.WriteLine($"Row {i}: {splitStrings[i]}");

// Replace
string replacments1 = s1.Replace('i','I');
Console.WriteLine($"{nameof(replacments1)}: {replacments1}");

string replacments2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacments2)}: {replacments2}");

// Convert to string
string salary = 478910.20.ToString();
int value = 78923343;
string strValue = value.ToString();
Console.WriteLine($"{nameof(salary)}: {salary}");
Console.WriteLine($"{nameof(strValue)}: {strValue}");

// Changing Formatting
Console.WriteLine($"{nameof(salary)}: {salary:C}");
Console.WriteLine(nameof(value) +": " + value.ToString("C"));


// String comparison
