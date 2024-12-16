// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input safety Score");
int safetyScore = int.Parse(Console.ReadLine());
string message = $"The usage policy for {safetyScore} is {safetyScore switch
{
    > 90 => "Unlimited usage",
    > 80 => "General usage, with daily safety check",
    > 70 => "Issues must be addressed within 1 week",
    > 50 => "Issues must be addressed within 1 day",
    _ => "Issues must be addressed before continued use",
}}";
Console.WriteLine(message);
int salary = 500;
int year = 5;
const int month = 12;
int yarsProfit = month * year * salary;
Console.WriteLine($"With a salary of {salary:C}, the employee will receive {yarsProfit:C} in {year} years.");



