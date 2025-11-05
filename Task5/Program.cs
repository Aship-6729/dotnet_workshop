// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


DateTime birthDate = new DateTime(2005, 4, 26); 


DateTime currentDate = DateTime.Now;


TimeSpan ageSpan = currentDate - birthDate;
int ageInYears = (int)(ageSpan.Days / 365.25);

Console.WriteLine($"Your Birthdate: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
Console.WriteLine($"Your Age: {ageInYears} years");


DateTime futureDate = birthDate.AddDays(10);
Console.WriteLine($"10 days after your birthdate: {futureDate.ToShortDateString()}");
