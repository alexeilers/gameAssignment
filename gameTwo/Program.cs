// ROCK PAPER SCISSORS //


bool gameLoop = true;
int userPoints = 0;
int computerPoints = 0;

while (gameLoop) 
{
    Console.WriteLine("Welcome to ROCK PAPER SCISSORS! Please enter the number for your choice and hit ENTER");
    Console.WriteLine("1. ROCK");
    Console.WriteLine("2. PAPER");
    Console.WriteLine("3. SCISSORS");

    string userChoice = Console.ReadLine();

    Random randomChoice = new Random ();
    int computerChoice = randomChoice.Next(1,4);

    switch (computerChoice) 
    {
    case 1:
        if (userChoice == "1")

        {
            Console.WriteLine("You selected ROCK");
            Console.WriteLine("Opponent selected ROCK");
            Console.WriteLine("It's a tie!");
        }
    
        else if (userChoice == "2")
        {
            Console.WriteLine("You selected PAPER");
            Console.WriteLine("Opponent selected ROCK");
            Console.WriteLine("You win!");
            userPoints++;
        }
        else if (userChoice == "3")
        {
            Console.WriteLine("You selected SCISSORS");
            Console.WriteLine("Opponent selected ROCK");
            Console.WriteLine("You lost!");
            computerPoints++;
        }
        break;

    case 2:
        if (userChoice == "1")
        {
            Console.WriteLine("You selected ROCK");
            Console.WriteLine("Opponent selected PAPER");
            Console.WriteLine("You lost!");
        }
    
        else if (userChoice == "2")
        {
            Console.WriteLine("You selected PAPER");
            Console.WriteLine("Opponent selected PAPER");
            Console.WriteLine("It's a tie!");
            userPoints++;
        }
        else if (userChoice == "3")
        {
            Console.WriteLine("You selected SCISSORS");
            Console.WriteLine("Opponent selected PAPER");
            Console.WriteLine("You win!");
            computerPoints++;
        }
    break;

    case 3:
    if (userChoice == "1")
        {
            Console.WriteLine("You selected ROCK");
            Console.WriteLine("Opponent selected SCISSORS");
            Console.WriteLine("You win!");
            userPoints++;
        }
    
        else if (userChoice == "2")
        {
            Console.WriteLine("You selected PAPER");
            Console.WriteLine("Opponent selected SCISSORS");
            Console.WriteLine("You lost!");
            computerPoints++;
        }
        else if (userChoice == "3")
        {
            Console.WriteLine("You selected SCISSORS");
            Console.WriteLine("Opponent selected SCISSORS");
            Console.WriteLine("It's a tie!");
        }
        
    break;
    }

    Console.WriteLine("Another round? Y/N");
        string playAgain = Console.ReadLine();

        if (playAgain == "N" || playAgain == "n" || playAgain=="no") 
        {
        gameLoop = false;
        Console.WriteLine($"You have {userPoints} points - Opponent has {computerPoints} points");
        }
    
}




