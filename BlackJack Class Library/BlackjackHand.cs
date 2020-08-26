using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_Class_Library
{
    public class BlackjackHand : Hand
    {
        public int Score { get; private set; }
        public bool IsDealer { get; private set; }

        public BlackjackHand(bool isDealer = false)
        {
            Score = 0;
            IsDealer = isDealer;
        }

        public override void AddCard(ICard addCard)
        {
            _cards.Add(addCard);

            calculateScore();
        }

        public void calculateScore()
        {
            int score = 0;

            List<BlackjackCard> aces = new List<BlackjackCard>();

            foreach (BlackjackCard card in _cards)
            {
                if (card.Face == CardFace.A)
                {
                    aces.Add(card);
                    score += 1;
                    continue;
                }

                score += card.value[0];
            }

            foreach(BlackjackCard ace in aces)
            {
                if (score + 10 <= 21)
                {
                    score += 10;
                }
            }

            Score = score;
        }

        public override void Draw(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (IsDealer)
            {
                Console.WriteLine("{0, -15} ({1,2})  ", "Dealer", Score);
                base.Draw(x, y + 2);

            }
            else
            {
                Console.WriteLine("{0, -15} ({1, 2})", "Player", Score);
                base.Draw(x, y + 2);
            }
        }

        public void Draw(int x, int y, bool hide)
        {
            if (!hide)
            {
                Draw(x, y);
            }
            else
            {
                
                if (IsDealer)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0, -15} ({1,2})  ", "Dealer", "XX");
                    int left = Console.BufferWidth;


                    int count = 1;
                    foreach (ICard card in _cards)
                    {
                        int top = y + 2;
                        left = left - 15;
                        Console.SetCursorPosition(left, top);
                        if (count == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("       ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("       ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write(" F     ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("  U    ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("   L   ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("    L  ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write(" S     ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("  A    ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("   I   ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("    L  ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("       ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("       ");
                            Console.SetCursorPosition(left, ++top);
                            Console.Write("       ");
                        }
                        else
                        {
                            card.Draw(left, top);

                        }

                        count = count + 1;

                    }

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0, -15} ({1, 2})", "Player", Score);
                    base.Draw(x, y + 2);
                }
            }


        }
    }
}
