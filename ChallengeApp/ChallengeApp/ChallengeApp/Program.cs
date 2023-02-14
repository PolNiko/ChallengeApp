using ChallengeApp;
{
    Console.WriteLine("Employees Grades System 0-100");
}
var employee = new Employee("Niko", " Post");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(7.26);
employee.AddGrade(98.99);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");