namespace ChallengeApp;

public class Employee
{
    private List<int> score = new List<int>();
    public Employee(string Name, string Lastname, string Age)
    {
        this.Name = Name;
        this.Lastname = Lastname;
        this.Age = Age;
    }
    public string Name { get; private set; }
    public string Lastname { get; private set; }
    public string Age { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int grade)
    {
        this.score.Add(grade);
    }
}