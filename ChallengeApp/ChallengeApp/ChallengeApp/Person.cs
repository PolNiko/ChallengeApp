namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string lastname, string age, char sex)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public string Age { get; private set; }
        public char Sex { get; private set; }
    }
}
