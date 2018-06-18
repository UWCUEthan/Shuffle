using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shuffle;

namespace ShuffleTest
{
    [TestClass]
    public class ShuffleTest
    {
        [TestMethod]
        public void DeckInOrder()
        {
            var deck = new Deck();
            deck.Display();
            Console.ReadLine();
        }

        [TestMethod]
        public void DeckShuffled()
        {
            var deck = new Deck();
            deck.Shuffle();
            deck.Display();
            Console.ReadLine();
        }

        [TestMethod]
        public void DeckDraw()
        {
            var deck = new Deck();
            deck.Shuffle();
            var card1 = deck.Draw();
            var card2 = deck.Draw();
            Assert.AreEqual(50, deck.CardsRemaining());
        }
    }
}
