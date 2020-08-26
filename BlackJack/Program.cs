using System;
using BlackJack_Class_Library;
using Microsoft.VisualBasic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            
            string[] menuOptions =
            {
                "1. Play BlackJack",
                "2. Shuffle and Show Deck",
                "3. Exit"
            };
            
            int choice;

            do
            {
                ReadChoice(menuOptions, out choice, "Choice: ");

                switch (choice)
                {
                    case 1:
                        bool exit = false;
                        do
                        {
                            PlayBlackJack();

                            bool valid = false;
                            string answer = string.Empty;
                            do
                            {
                                ReadString("Play again? (Yes or No) ", ref answer);

                                if (answer == "yes" || answer == "y" || answer == "no" || answer == "n")
                                {
                                    valid = true;
                                }
                            } while (!valid);

                            exit = (answer == "no" || answer == "n");
                        } while (!exit);
                        

                        break;
                    case 2:
                        Deck cardDeck = new Deck();
                        cardDeck.Shuffle();
                        cardDeck.Print();
                        break;
                    case 3:
                        break;
                }
            } while (choice != 3);

        }

        static void PlayBlackJack()
        {
            BlackjackHand player = new BlackjackHand();
            BlackjackHand dealer = new BlackjackHand(true);

            Deck deck = new Deck();
            deck.Shuffle();

            for (int i = 0; i < 2; i++)
            {
                player.AddCard(deck.Deal());
                dealer.AddCard(deck.Deal());
            }

            PrintGame(ref dealer, ref player);

            if (player.Score == 21)
            {
                
                PrintGame(ref dealer, ref player, false);
                Console.WriteLine("Player wins, BlackJack!");
                return;
            } else if (dealer.Score == 21)
            {
                PrintGame(ref dealer, ref player, false);
                Console.WriteLine("Dealer wins, BlackJack!");
                return;
            }

            //player round
            int choice;
            do
            {
                string[] options = { "1. Hit", "2. Stand" };

                ReadChoice(options, out choice, "Choice: ");

                if (choice == 1)
                {
                    player.AddCard(deck.Deal());

                    PrintGame(ref dealer, ref player);
                    if (player.Score > 21)
                    {
                        PrintGame(ref dealer, ref player, false);
                        Console.WriteLine("Player Busts!");
                        return;
                    } else if (player.Score == 21)
                    {
                        PrintGame(ref dealer, ref player, false);
                        Console.WriteLine("Player wins! BlackJack!");
                        return;
                    }
                }
            } while (choice != 2);

            //computer/dealer round
            do
            {
                if (dealer.Score < 17)
                {
                    dealer.AddCard(deck.Deal());
                }

                PrintGame(ref dealer, ref player);
            } while (dealer.Score < 17);

            PrintGame(ref dealer, ref player, false);

            if (dealer.Score == 21)
            {
                Console.WriteLine("Dealer wins, BlackJack!");
                return;
            } else if (dealer.Score > player.Score && dealer.Score < 21)
            {
                Console.WriteLine("Dealer wins with score of " + dealer.Score);
                return;
            } else if (dealer.Score < player.Score && player.Score < 21)
            {
                Console.WriteLine("Player wins with score of " + player.Score);
                return;
            } else
            {
                Console.WriteLine("Game is a Draw");
                return;
            }
        }
        
        static void PrintGame(ref BlackjackHand dealer, ref BlackjackHand player, bool hide = true)
        {
            Console.Clear();
            dealer.Draw(0, 0, hide);
            Console.SetCursorPosition(0, 15);
            player.Draw(0, 15, hide);
            
        }

        static void ReadChoice(string[] options, out int selection, string prompt = "Please make a selection")
        {
            Console.WriteLine();
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine();

            selection = ReadInteger(prompt, 1, options.Length + 1);
        }

        static int ReadInteger(string prompt = "Please enter an integer", int min = 0, int max = Int32.MaxValue)
        {

            bool intEntered = false;
            int enteredNumber = min - 1;

            while (!intEntered)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                try
                {
                    enteredNumber = Int32.Parse(input);

                    if (enteredNumber < min || enteredNumber > max)
                    {
                        Console.WriteLine("Integer is out of range");
                        continue;
                    }
                    else
                    {
                        intEntered = true;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("That is not an integer, please try again.");
                    continue;
                }

            }

            return enteredNumber;
        }

        static void ReadString(string prompt, ref string returnVar)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Write(prompt);
                string tempVar = Console.ReadLine();

                tempVar = tempVar.Trim().ToLower();

                if (tempVar.Length > 0)
                {
                    returnVar = tempVar;
                    exit = true;
                } else
                {
                    Console.WriteLine("Please enter a valid string");
                }
            }
        }
    }
}
