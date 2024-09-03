using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fewArraysTasks
{
    internal class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<String> list = new List<String>() { "clubs", "hearts", " Diamonds", "Spades" };
            List<String> list2 = new List<String>() { "two", "three", "four", "five" };
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
            foreach (String s in list)
            {
                foreach (String s2 in list2)
                {
                    Card card = new Card();
                    card.Suit = s2;
                    card.Face = s;
                    Cards.Add(card);

                }

            }

        }
        
        
        public List<Card> Cards { get; set; }
    }
}

