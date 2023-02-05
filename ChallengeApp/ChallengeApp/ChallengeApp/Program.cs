using ChallengeApp;
{
    Console.WriteLine("EmployeesGradesSystem");
}

Employee employee0 = new Employee("Angelika", "Nowak", " ,43");
employee0.AddScore(5);
employee0.AddScore(6);
employee0.AddScore(4);
employee0.AddScore(7);
employee0.AddScore(6);

Employee employee1 = new Employee("Tomek", "Malysz", " ,39");
employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(3);

Employee employee2 = new Employee("Andrzej", "Gora", " ,33");
employee2.AddScore(5);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(7);

List<Employee> employees = new List<Employee>()
{
    employee0, employee1, employee2
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine("Employee with best result: ");
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Lastname + employeeWithMaxResult.Age + " Years Old");
Console.WriteLine($"Result: {employeeWithMaxResult.Result} Points.");
