using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BlackJack_Class_Library
{
    public class Hand
    {
        public List<ICard> _cards;

        public Hand()
        {
            _cards = new List<ICard>();
        }

        public virtual void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public virtual void Draw(int x, int y)
        {
            int left = Console.BufferWidth - 15;
            int top = y;

            foreach (ICard card in _cards)
            {
                card.Draw(left, top);
                left = left - 15;
            }

            Console.WriteLine();
        }
    }
}
