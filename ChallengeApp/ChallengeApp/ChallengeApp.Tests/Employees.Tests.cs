namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenStatisticIsMaxShowResult()
        {
            //arrange
            var employee = new Employee("Niko", " Post");

            //act
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(8);
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Max, 8);
        }

        [Test]
        public void WhenStatisticIsMinShowResult()
        {
            //arrange
            var employee = new Employee("Niko", " Post");

            //act
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(8);
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Min, 2);
        }

        [Test]
        public void WhenAverageIsCorrectShowEqual()
        {
            //arrange
            var employee = new Employee("Niko", " Post");

            //act
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(8);
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Average, 5);
        }
    }
}