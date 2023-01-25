using StatisticsApp;

User user1 = new User("Robert", "Kiyosaki", 49);
User user2 = new User("Paula", "Edison", 38);
User user3 = new User("Roksana", "McGregor", 29);


user1.AddScore(3);
user1.AddScore(5);
user1.AddScore(2);

user2.AddScore(4);
user2.AddScore(1);
user2.AddScore(7);

user3.AddScore(4);
user3.AddScore(9);
user3.AddScore(2);

List<User> users = new List<User>()
{
    user1, user2, user3
};

int maxResult = 0;
User userWithMaxResult = null;

foreach (var user in users)
{
    if (user1.Result > maxResult)
    {
        maxResult = user1.Result;
        userWithMaxResult = user1;
    }
    else if (user2.Result > maxResult)
    {
        maxResult = user2.Result;
        userWithMaxResult = user2;
    }
    else if (user3.Result > maxResult)
    {
        maxResult = user3.Result;
        userWithMaxResult = user3;
    }
}

Console.WriteLine($"\nPracownikiem z najwyższą sumą ocen wynoszącą {userWithMaxResult.Result} jest:\nimię: {userWithMaxResult.Name} \nnazwisko: {userWithMaxResult.Surname} \nwiek: {userWithMaxResult.Age}");
