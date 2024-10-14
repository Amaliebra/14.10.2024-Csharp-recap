namespace _14._10._2024_Csharp_recap;

class Program
{
    static void Main(string[] args)
    {
        int todayDate = 14;
        string monthOct = "October";
        string yoWorld = "Yo World";
        Console.WriteLine($"{yoWorld}, today it is the {todayDate}th of {monthOct}.");

        Person personEn = new Person();

        personEn.Name = "Justin Bieber";
        personEn.Age = 30;
        personEn.Gender = "male";

        Console.WriteLine($"{personEn.Name} is a {personEn.Age} year old {personEn.Gender}");

        Person personTo = new Person();

        personTo.Name = "Asmongold";
        personTo.Age = 34;
        personTo.Gender = "male";

        Console.WriteLine($"Name:{personTo.Name}\nAge:{personTo.Age}\nGender:{personTo}");

        string[] handleListe = {"Melk", "Egg", "Brus"};
        for (int i = 0; i < handleListe.Length; i++)
        {
            Console.WriteLine(handleListe[i]);
        }

        personEn.SayHello();

        Utility utility = new Utility();
        string hello = "Hello";
        string world = "World";
        Console.WriteLine(utility.SimpleConcat(hello, world));

        bool canEnter = false;
        int age = 19;
        if(age >= 18 && !canEnter)
        {
            Console.WriteLine("You can enter");
        }
        else
        {
            Console.WriteLine("You cannot enter");
        }
    }
}
