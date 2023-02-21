namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string lastname, string age, string profession)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Profession = profession;
        }
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public string Age { get; private set; }
        public string Profession { get; private set; }
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
    }
}
