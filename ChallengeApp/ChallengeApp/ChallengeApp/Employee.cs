namespace ChallengeApp;
public class Employee
{
    private List<float> grades = new List<float>();
    public Employee(string name, string lastname)
    {
        this.Name = name;
        this.Lastname = lastname;

    }
    public string Name { get; private set; }
    public string Lastname { get; private set; }

    public void AddGrade(float grade)
    {
        this.grades.Add(grade);
    }
    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;


        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }

        statistics.Average /= this.grades.Count;

        return statistics;
    }
}