// See https://aka.ms/new-console-template for more information
Console.WriteLine("ConsoleApp.DateTimeManipulation!");
Console.WriteLine("***** - DateTime manipulation - *****");

// Empty DateTime object
DateTime dateTime = new DateTime();

// Create a DateTime from date and time
var dateOfBirth = new DateTime(1980,12,07);
Console.WriteLine($"My DoB is: {dateOfBirth}");

var exactDateAndTimeOfBirth = new DateTime(1980, 12, 25, 14, 45, 25);
Console.WriteLine($"My DoB is: {exactDateAndTimeOfBirth}");

Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {exactDateAndTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {exactDateAndTimeOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");

// Create a DateTime from current timestmp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now Is: " + now);

// Create a DateTime from a String
// Console.Write("What is your DoB? (mm/dd/yyyy): ");
// string dob = Console.ReadLine();

// var userDob = DateTime.Parse(dob);

// Console.WriteLine($"Day of Week: {userDob.DayOfWeek}");
// Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
// Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
// Console.WriteLine($"Tick: {userDob.Ticks}");
// Console.WriteLine($"Kind: {userDob.Kind}");

// Change Format DateTime
Console.WriteLine($"Formatted Date: {now.ToString("dd/MM/yy")}");
Console.WriteLine($"Formatted Date: {now.ToString("ddd/MMM/yyyy")}");
Console.WriteLine($"Formatted Date: {now.ToString("dddd/MMMM/yyyyy")}");

Console.WriteLine($"Formatted Date: {now.ToString("MMMM, dd-yyyy")}");
Console.WriteLine($"Formatted Date: {now.ToString("dd-MMM-yyyy")}");
Console.WriteLine($"Formatted Date: {now.ToString("dddd-MMMM-yyyy")}");


// Add Additional Time
Console.WriteLine($"One hour from now is: " + now.AddHours(1));
Console.WriteLine($"One day from now is: " + now.AddDays(1));
Console.WriteLine($"One day ago from now is: " + now.AddDays(-1));
Console.WriteLine($"50 Seconds ago from now is:" + now.AddSeconds(-55));

// Ticks from DateTime

Console.WriteLine("***** - DateTime Offset manipulation - *****");
// UTC - Coordinated Universal Time (UTC)
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Date Time now: {now}");
Console.WriteLine($"UTC Date Time now: {utcNow}"); 

// DateTimeOffSet and TimeZone Info
var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"user Time Zone: {tz}");

var dto = new DateTimeOffset(now, tz);
Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
Console.WriteLine($"UCT Time of Action: {dto.UtcDateTime}");

var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

Console.WriteLine("***** - Date only and Time only manipulation - *****");

// Date Only
var dateOnly = new DateOnly(1980,12,25);
Console.WriteLine($"Date: {dateOnly}");

// Time Only
var timeNow = TimeOnly.FromDateTime(now);
Console.WriteLine($"Time now: {timeNow}");
Console.WriteLine($"Time now: {timeNow:hh:mm tt}");

// Date Comparisons
var date1 = new DateTime(1985, 11, 23);
var date2 = new DateTime(1965, 1, 20);

Console.WriteLine($"Is '{nameof(date1)}' equal? {date1 == date2}");
Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
Console.WriteLine($"Is '{nameof(date2)}' after? {date2 > date1}");
Console.WriteLine($"Is '{nameof(date2)}' before? {date2 < date1}");
