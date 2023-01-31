namespace StatisticsApp;

public class User
{
    private List<int> scores = new List<int>();

    public User(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public User(string login)
    {
        this.Login = login;
    }


    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public string Login { get; private set; }

    public int Result
    {
        get
        {
            return this.scores.Sum();
        }
    }

    public void AddScore(int number)
    {
        this.scores.Add(number);
    }
}