namespace StatisticsApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange (przygotowanie)
            var user = new User("Robert", "Kowalski", 49);
            user.AddScore(4);
            user.AddScore(8);

            //  act (uruchomienie)
            var result = user.Result;

            // assert (zapewnienie, ¿e zosta³y spe³nione okreœlone warunki)
            Assert.AreEqual(12, result);
        }

        [Test]
        public void WhenUserCollectNegativeSumScores_ShouldReturnZero()
        {
            // arrange (przygotowanie)
            var user = new User("Robert", "Kowalski", 49);
            user.AddScore(4);
            user.AddScore(8);
            user.AddScore(-12);

            //  act (uruchomienie)
            var result = user.Result;

            // assert (zapewnienie, ¿e zosta³y spe³nione okreœlone warunki)
            Assert.AreEqual(0, result);
        }
    }
}