namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenTwoDiffrentEmployeesNamesShouldShowEqual()
        {
            // arrange
            var employee0 = GetEmployee("Angelika");
            var employee2 = GetEmployee("Andrzej");

            // act

            // assert
            Assert.AreNotEqual(employee0, employee2);
        }

        [Test]
        public void WhenScoresAreTheSameShouldReturnEqual()
        {
            // arrange
            int Score1 = 5;
            int Score2 = 5;

            // act

            // assert
            Assert.AreEqual(Score1, Score2);
        }

        [Test]
        public void WhenFloatsAreDiffrentShouldShowEqual()
        {
            // arrange
            float number1 = 2.115f;
            float number = 5.187f;

            // act

            // assert
            Assert.AreNotEqual(number1, number);
        }

        [Test]
        public void WhenStringReturnDifferentAgesShouldShowEqual()
        {
            // arrange
            string employee0 = "33";
            string employee3 = "48";

            // act

            // assert
            Assert.AreNotEqual(employee0, employee3);
        }
        private Employee GetEmployee(string Login)
        {
            return new Employee(Login);
        }
    }
}

