using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack_Class_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_Class_Library.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {

        [TestMethod()]
        public void AddCardTest()
        {
            BlackjackHand test = new BlackjackHand(false);

            BlackjackCard ace = new BlackjackCard(CardFace.A, CardSuit.Clubs);
            BlackjackCard eight = new BlackjackCard(CardFace.EIGHT, CardSuit.Clubs);

            test.AddCard(ace);
            test.AddCard(eight);

            if (test.Score != 19)
            {
                Assert.Fail("Score is " + test.Score + " it should be 19, initial add.");
            }

            BlackjackCard ten = new BlackjackCard(CardFace.TEN, CardSuit.Clubs);
            test.AddCard(ten);

            if (test.Score != 19)
            {
                Assert.Fail("Score is " + test.Score + " it should be 19, add 10");
            }

            test = new BlackjackHand(false);
            test.AddCard(ace);
            test.AddCard(ace);
            test.AddCard(eight);

            if (test.Score != 20)
            {
                Assert.Fail("Score is " + test.Score + " it should be 20");
            }
        }
    }
}