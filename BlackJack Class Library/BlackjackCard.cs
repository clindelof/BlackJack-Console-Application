using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_Class_Library
{
    public class BlackjackCard : Card
    {
        public int[] value { get; private set; }
        public BlackjackCard(CardFace face, CardSuit suit) : base(face, suit)
        {
            switch(face)
            {
                case CardFace.TWO:
                    value = new int[]{ 2 };
                    break;
                case CardFace.THREE:
                    value = new int[] { 3 };
                    break;
                case CardFace.FOUR:
                    value = new int[] { 4 };
                    break;
                case CardFace.FIVE:
                    value = new int[] { 5 };
                    break;
                case CardFace.SIX:
                    value = new int[] { 6 };
                    break;
                case CardFace.SEVEN:
                    value = new int[] { 7 };
                    break;
                case CardFace.EIGHT:
                    value = new int[] { 8 };
                    break;
                case CardFace.NINE:
                    value = new int[] { 9 };
                    break;
                case CardFace.TEN:
                    value = new int[] { 10 };
                    break;
                case CardFace.A:
                    value = new int[] { 1, 11 };
                    break;
                default:
                    value = new int[] { 10 };
                    break;

            }
        }
    }
}
