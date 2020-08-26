using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_Class_Library
{
    public interface ICard
    {
        CardFace Face
        {
            get;
        }
        CardSuit Suit
        {
            get;
        }

        void Draw(int x, int y);
    }
}
