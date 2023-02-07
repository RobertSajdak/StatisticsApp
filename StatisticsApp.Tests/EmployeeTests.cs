namespace StatisticsApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGradeIsTheLowestValue_GetCorrectResult()
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
            employee.AddGrade(88);

            //  act (uruchomienie)
            var statistics = employee.GetStatistics();

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreEqual(88, statistics.Max);
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

        [Test]
        public void WhenAverageValueIsCorrect_ReturnCorrectResult()
        {
            // arrange (przygotowanie)
            var employee = new Employee("Robert", "Sajdak");
            employee.AddGrade(5.6);
            employee.AddGrade(4.4);
            employee.AddGrade(5);

            //  act (uruchomienie)
            var statistics = employee.GetStatistics();

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.AreEqual(Math.Round(5.00, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenAverageLetterValueIsCorrect_ReturnCorrectResult()
        {
            // arrange (przygotowanie)
            var employee = new Employee("Robert", "Sajdak");
            employee.AddGrade(33);
            employee.AddGrade(60);
            employee.AddGrade(87);

            //  act (uruchomienie)
            var statistics = employee.GetStatistics();

            // assert (zapewnienie, że zostały spełnione określone warunki)
            Assert.That('B', Is.EqualTo(statistics.AverageLetter));
        }
    }
}
