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

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {

                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomindex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomindex]);
                    Cards.RemoveAt(randomindex);
                }
                this.Cards = TempList;
            }
        }
    }
}

