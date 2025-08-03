using BackjackGame;
using BackJackGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJackGame

{
    internal class Program
    {
        static void Main() // string[] args
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by tellling me your name");
            String playerName = Console.ReadLine();

            Console.WriteLine("How many money you bring with you?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hello, {0} Do you want play 21 game?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);

                
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;

                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("feel free to look around the casion bye for now");
        }
    }
} 
