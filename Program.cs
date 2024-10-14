namespace _14._10._2024_Csharp_recap;

class Program
{
    static void Main(string[] args)
    {
        int todayDate = 14;
        string monthOct = "October";
        string yoWorld = "Yo World";
        Console.WriteLine($"{yoWorld}, today it is the {todayDate}th of {monthOct}.");

        Person person = new Person();

        person.Name = "Justin Bieber";
        person.Age = 30;
        person.Gender = "male";

        Console.WriteLine($"{person.Name} is a {person.Age} year old {person.Gender}");
    }
}
