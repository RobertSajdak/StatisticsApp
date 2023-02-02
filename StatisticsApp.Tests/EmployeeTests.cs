namespace StatisticsApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // arrange (przygotowanie)
            var employee = new Employee("Robert", "Sajdak");
            employee.AddGrade(8);
            employee.AddGrade(5);
            employee.AddGrade(11);

            //  act (uruchomienie)
            var statistics = employee.GetStatistics();

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreEqual(5, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange (przygotowanie)
            var employee = new Employee("Robert", "Sajdak");
            employee.AddGrade(3);
            employee.AddGrade(1);
            employee.AddGrade(8);

            //  act (uruchomienie)
            var statistics = employee.GetStatistics();

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            // arrange (przygotowanie)
            var employee = new Employee("Robert", "Sajdak");
            employee.AddGrade(11);
            employee.AddGrade(7);
            employee.AddGrade(2);

            //  act (uruchomienie)
            var statistics = employee.GetStatistics();

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreEqual(Math.Round(6.67, 2), Math.Round(statistics.Average, 2));
        }
    }
}
