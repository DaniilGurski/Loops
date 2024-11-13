internal class Program
{
    private static void Main(string[] args)
    {
        // Assigment 1: 
        // for (int i=1; i <= 100; i++) {
        //     if (i % 2 != 0) {
        //         Console.WriteLine(i);
        //     }
        // }


        // Assigment 2:
        // for (int row = 1; row <= 10; row++) {
        //     for (int i = 10; i >= row; i--) {
        //         Console.Write("#");
        //     }
            
        //     Console.WriteLine("");
        // }


        // Assigment 3
        // int tries = 0;
        // string password = "password";

        // while (true) {
        //     Console.Write("Your guess: "); 
        //     string? guess = Console.ReadLine();
        //     tries++;

        //     if (guess == password) {
        //         Console.WriteLine("You guessed the password correctly !");
        //         Console.WriteLine($"Tries: {tries}");
        //         break;
        //     }

        //     Console.WriteLine("Wrong, try again.");
        // }


        // Assigment 4
        Console.WriteLine("Your current balance: ");
        double? balance = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Your goal: ");
        double? goal = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Your interest rate: ");
        double? interest = Convert.ToDouble(Console.ReadLine()) / 100; 

        int years = 0;

        while (balance <= goal) {
            balance += balance * interest;
            years++;
        }

        Console.WriteLine($"It will take {years} to reach your goal of {goal}");
    }
}