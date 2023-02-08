namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectPlusScoresShouldSum()
        {
            // arrange
            var employee = new Employee("Angelika", "Nowak", " ,43");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(6);

            // act
            var result = employee.Result;

            //assert
            Assert.AreEqual(18, result);
        }
        [Test]
        public void WhenEmployeeCollectBoughtScoresShouldShowThem()
        {
            // arrange
            var employee = new Employee("Angelika", "Nowak", " ,43");
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddMinusScore(-6);

            // act
            var result = employee.Result;

            //assert
            Assert.AreEqual(5, result);
        }
        [Test]
        public void WhenEmployeeCollectThreeNegativeScoresShouldSum()
        {
            // arrange
            var employee = new Employee("Angelika", "Nowak", " ,43");
            employee.AddMinusScore(-7);
            employee.AddMinusScore(-6);
            employee.AddMinusScore(-6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-19, result);
        }
    }
}