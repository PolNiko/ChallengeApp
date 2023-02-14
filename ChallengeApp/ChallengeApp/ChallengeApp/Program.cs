using ChallengeApp;
{
    Console.WriteLine("EmployeesGradesSystem");
}
var employee = new Employee("Niko", " Post");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(8);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");