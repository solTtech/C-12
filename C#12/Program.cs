// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Input safety Score");
int safetyScore = int.Parse(System.Console.ReadLine());
string message = $"The usage policy for {safetyScore} is {safetyScore switch
{
    > 90 => "Unlimited usage",
    > 80 => "General usage, with daily safety check",
    > 70 => "Issues must be addressed within 1 week",
    > 50 => "Issues must be addressed within 1 day",
    _ => "Issues must be addressed before continued use",
}}";
System.Console.WriteLine(message);
System.Console.WriteLine(new string('*', 40));
int salary = 500;
int year = 5;
const int month = 12;
int yarsProfit = month * year * salary;
System.Console.WriteLine($"With a salary of {salary:C}, the employee will receive {yarsProfit:C} in {year} years.");

System.Console.WriteLine(new string('*', 40));



