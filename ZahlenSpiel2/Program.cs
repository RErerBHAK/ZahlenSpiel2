class Programm
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Zufällige Zahl zwischen 1 und 100
        int attempts = 0;

        Console.WriteLine("Willkommen zum Zahlenratespiel!");
 

        int guess = 0;
        do
        {
           Console.Write("Gib deine Schätzung ein (bitte ein Zahl zwischen 1 und 100): ");
           string input = Console.ReadLine();

 

           if (!int.TryParse(input, out guess))
           {
                Console.WriteLine("Die Eingabe ist leider ungültig :( Bitte gib eine ganze Zahl ein.");
                continue;
           }
    }
}
