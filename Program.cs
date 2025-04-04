using Casino.CardGames.Poker;
using Casino.SmallGames;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            // if (OperatingSystem.IsWindows())
            // {
            //     Console.SetWindowSize(65, 40);
            //     Console.BufferWidth = 65;
            //     Console.BufferHeight = 40;
            // }

            // Turned off for debug
            // Console.Title = "Game Selection";
            // Console.WriteLine();
            // Console.WriteLine("Select a game to play:");
            // Console.WriteLine("1. Poker Game");
            // Console.WriteLine("2. Triangle Drawer Game");
            // Console.WriteLine("3. Dice Game");
            // Console.WriteLine("4. Guessing Game");
            // Console.WriteLine("Enter the number of the game to play:");

            // Choice turned off for debug
            string? choice = "1"; //Console.ReadLine();

            IPlayable game = new FiveCardPoker();

            switch (choice)
            {
                case "1":
                    game = new FiveCardPoker();
                    break;
                case "2":
                    game = new TriangleDrawer();
                    break;
                case "3":
                    game = new DiceGame();
                    break;
                case "4":
                    game = new GuessingGameRight();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    Environment.Exit(0);
                    break;
            }

            game.Play();
        }

        // static void PlayPokerGame()
        // {
        //     Console.Title = "Poker Game";
        //     Console.WriteLine();
        //     Console.WriteLine();
        //     PokerGame game = new PokerGame();
        //     game.PlayGame();
        // }
    }
}