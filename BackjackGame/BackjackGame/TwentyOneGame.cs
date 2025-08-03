using BackJackGame;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjackGame
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer(); // Instantiate a new instance of TwentyOneDealer called Dealer
            foreach (Player player in Players) // Iterate through the list of Players and assign each instance to the player variable
            {
                player.Hand = new List<Card>(); // Creates a new empty hand of playing cards for the Player
                player.Stay = false; // Reset the Stay property to false of the current player object
            } // End FOREACH
            Dealer.Hand = new List<Card>(); // Create a new empty hand of playing cards for the Dealer
            Dealer.Stay = false; // Set the Dealer's stay property to false
            Dealer.Deck = new Deck(); // Issue the Dealer with a new deck of playing cards
            Dealer.Deck.Shuffle(); // Shuffle the Dealer's new deck of playing cards

            foreach (Player player in Players)
            {

                Console.WriteLine("place your bet!");
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullybet = player.Bet(bet);
                if (!successfullybet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2;i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if ( blackJack )
                        {
                            Console.WriteLine("Blackjack! {0} win {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return; 
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if ( blackJack )
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone Loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.isBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bets of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you wanna player again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.IsActivelyPlaying = true;
                        }
                        else
                        {
                            player.IsActivelyPlaying = false;
                        }
                    }
                }

            }
            Dealer.IsBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.IsBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.IsBusted = TwentyOneRules.isBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is Staying.");
            }
            if (Dealer.IsBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("push! No one Wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true) 
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.IsActivelyPlaying = true;
                    return;
                }
                else
                {
                    player.IsActivelyPlaying = false;
                    return;
                }
            }          
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
