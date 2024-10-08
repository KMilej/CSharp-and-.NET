using BackjackGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJackGame
{
    public class Player
    {
        public Player(String name, int BeginBalance)
        {
            Hand = new List<Card>();
            BeginBalance = BeginBalance;
            name = name;

        }
        public List<Card> Hand {  get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount > 0)
            {
                Console.WriteLine("you do not have enough to place a bet that size");
                return
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
 