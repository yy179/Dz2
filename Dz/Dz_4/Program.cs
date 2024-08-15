using Dz_4;
using static Dz_4.ApplicationSettings;

internal class Program
{
    public static void Main(string[] args)
    {
        //2.
        ApplicationSettings appSettings = new ApplicationSettings("MyApp", 2.0);
        DatabaseSettings dbSettings = new DatabaseSettings("connectionString", 30);
        Console.WriteLine(dbSettings.Settings(appSettings));
        // Можно ли это все проще было сделать? Ну понятно что без вложенных циклов - можно, но я имею ввиду относительно задания

        //3.
        var ints = new Storage<int>();
        ints.SetItem(50);
        Console.WriteLine(ints.GetItem());
        var strs = new Storage<string>();
        strs.SetItem("Hi!");
        Console.WriteLine(strs.GetItem());
        var scores = new Storage<Score>();
        var score = new Score {Name = "Vlad", Count = 20 };
        scores.SetItem(score);
        Console.WriteLine(scores.GetItem());
        //4.
        static void Timefinish() { Console.WriteLine("The timer has expired"); }
        MyTimer timer = new MyTimer();//появились проблемы изза дефолтного таймера в threading так что я переименовал свой
        timer.OnTimeElapsed += Timefinish;
        timer.Start(5);
        Console.WriteLine("Timer has started");
        Console.ReadLine();
    }
}

// Создал класс прямо тут для наглядности, в отдельный файл выносить его показалось мне странным 
public class Score 
{
    public string Name { get; set; }
    public int Count { get; set; }
    public override string ToString()
    {
        return $"Name: {Name}\nScore: {Count}";
    }
}
