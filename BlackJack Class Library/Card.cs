using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlackJack_Class_Library
{
    public class Card : ICard
    {
        public CardFace Face
        {
            get;
            private set;
        }

        public CardSuit Suit
        {
            get;
            private set;
        }

        public void Draw(int x, int y)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.White;

            if (Suit == CardSuit.Spades || Suit == CardSuit.Clubs)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            string symbol = string.Empty;
            switch (Suit)
            {
                case CardSuit.Hearts:
                    symbol = "\u2665";
                    break;
                case CardSuit.Clubs:
                    symbol = "\u2663";
                    break;
                case CardSuit.Diamonds:
                    symbol = "\u2666";
                    break;
                case CardSuit.Spades:
                    symbol = "\u2660";
                    break;
            }

            Console.SetCursorPosition(x, y);

            switch (Face)
            {
                case CardFace.A:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" A     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   A   ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     A ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.TWO:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 2     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     2 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.THREE:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 3     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     3 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.FOUR:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 4     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     4 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.FIVE:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 5     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     5 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.SIX:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 6     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     6 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.SEVEN:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 7     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1}  {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     7 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.EIGHT:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 8     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1}  {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     8 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.NINE:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 9     ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     9 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                case CardFace.TEN:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" 10    ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("  {0,1} {0,1}  ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("    10 ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
                default:
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", Face);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(" {0,1}     ", symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("   {0,1}   ", Face);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ",symbol);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("     {0,1} ", Face);
                    Console.SetCursorPosition(x, ++y);
                    Console.Write("       ");
                    break;
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;

        }
    }
}
