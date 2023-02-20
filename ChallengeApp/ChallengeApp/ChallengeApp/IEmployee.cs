//what?
namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Lastname { get; }
        string Age { get; }
        string Profession { get; }
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
    }
}
