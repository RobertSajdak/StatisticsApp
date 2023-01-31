namespace StatisticsApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenEqualTwoValueTypes()
        {
            // arrange (przygotowanie)
            int number1 = 1;
            int number2 = 2;

            //  act (uruchomienie)

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenEqualTwoValueDoubleTypes()
        {
            // arrange (przygotowanie)
            var num1 = 1.22;
            var num2 = 2.38;

            //  act (uruchomienie)

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreNotEqual(num1, num2);
        }

        [Test]
        public void WhenEqualTwoStringsTypes()
        {
            // arrange (przygotowanie)
            string employee1 = "Robert";
            string employee2 = "Robert";

            //  act (uruchomienie)

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreEqual(employee1, employee2);
        }

        [Test]
        public void WhenEqualTwoReferenceTypes()
        {
            // arrange (przygotowanie)
            var user1 = GetUser("Earl", "Nightingale", 68);        
            var user2 = GetUser("Dale", "Carnegie", 67);

            //  act (uruchomienie)

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name, string surname, int age)
        {
            return new User(name, surname, age);
        }
    }
}
