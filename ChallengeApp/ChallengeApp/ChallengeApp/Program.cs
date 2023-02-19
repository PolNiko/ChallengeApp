using ChallengeApp;
using System;
Console.WriteLine("Welcome To Employees Grades System App");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Score a Employee");

var employee = new Employee("Niko", " Post", " 30yo", 'M');
while (true)
{
    Console.WriteLine("Add next Score for your Employee: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Finally here");
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"{employee.Name} {employee.Lastname} {employee.Age} {employee.Sex}");
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
