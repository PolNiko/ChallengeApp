using ChallengeApp;
using System;
Console.WriteLine("Welcome To Employees Grades System App");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Score a Employee or a Supervisor");

var supervisor = new Supervisor("Marcin", " Post", "45yo", "Project Menager");
while (true)
{
    Console.WriteLine("Add next Score for your Supervisor: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
    supervisor.AddGrade(input);
}
var supervisorStatisticks = supervisor.GetStatistics();
Console.WriteLine();
Console.WriteLine($"{supervisor.Name} {supervisor.Lastname} {supervisor.Age} {supervisor.Profession}");
Console.WriteLine($"AvgLetter: {supervisorStatisticks.AverageLetter}");
Console.WriteLine($"Average: {supervisorStatisticks.Average}");
Console.WriteLine($"Min: {supervisorStatisticks.Min}");
Console.WriteLine($"Max: {supervisorStatisticks.Max}");
Console.WriteLine();

Console.WriteLine("And now add Score for your Employee: ");
var employee = new Employee("Niko", " Post", "30yo", "Programmer");
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
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"{employee.Name} {employee.Lastname} {employee.Age} {employee.Profession}");
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");