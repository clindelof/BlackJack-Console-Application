using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace BlackJack_Class_Library
{
    public class Deck
    {
        List<ICard> _cards;

        public Deck()
        {
            _cards = new List<ICard>();

            FillDeck();

        }

        public void FillDeck()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardFace face in Enum.GetValues(typeof(CardFace)))
                {
                    _cards.Add(CardFactory.CreateBlackjackCard(face, suit));
                }
            }
        }

        public ICard Deal()
        {
            if (_cards.Count == 0)
            {
                FillDeck();
                Shuffle();
            }

            ICard toDeal = _cards.ElementAt(0);
            _cards.RemoveAt(0);

            return toDeal;
        }

        public void Shuffle()
        {
            Random rng = new Random();

            for (var i = _cards.Count - 1; i > 0; i--)
            {
                //get a random position in the list
                int k = rng.Next(i + 1);

                //swap that random position with the position in the list
                ICard value = _cards[k];
                _cards[k] = _cards[i];
                _cards[i] = value;
               
            }
        }

        public void Print()
        {
            int left = Console.CursorLeft + 1;
            int top = Console.CursorTop;

            int count = 0;

            foreach(ICard card in _cards)
            {
                card.Draw(left, top);

                count++;
                if (count % 4 == 0)
                {
                    top = top + 15;
                    left = 1;
                } else
                {
                    left = left + 15;
                }
            }
        }
    }
}
