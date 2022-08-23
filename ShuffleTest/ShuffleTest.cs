using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shuffle;

namespace ShuffleTest
{
    [TestClass]
    public class ShuffleTest
    {
        [TestMethod]
        public void DeckHasAllCards()
        {
            var deck = new Deck();
            var deckCards = deck.Display();
            List<string> allDisplay = new List<string>()
            {
                "Ace of Spades","Two of Spades","Three of Spades","Four of Spades","Five of Spades","Six of Spades","Seven of Spades","Eight of Spades","Nine of Spades","Ten of Spades","Jack of Spades","Queen of Spades","King of Spades","Ace of Diamonds","Two of Diamonds","Three of Diamonds","Four of Diamonds","Five of Diamonds","Six of Diamonds","Seven of Diamonds","Eight of Diamonds","Nine of Diamonds","Ten of Diamonds","Jack of Diamonds","Queen of Diamonds","King of Diamonds","Ace of Clubs","Two of Clubs","Three of Clubs","Four of Clubs","Five of Clubs","Six of Clubs","Seven of Clubs","Eight of Clubs","Nine of Clubs","Ten of Clubs","Jack of Clubs","Queen of Clubs","King of Clubs","Ace of Hearts","Two of Hearts","Three of Hearts","Four of Hearts","Five of Hearts","Six of Hearts","Seven of Hearts","Eight of Hearts","Nine of Hearts","Ten of Hearts","Jack of Hearts","Queen of Hearts","King of Hearts"
            };
            Assert.AreEqual(52, allDisplay.Intersect(deckCards).Count());
        }

        //[TestMethod]
        //public void DeckShuffled()
        //{
        //    var deck = new Deck();
        //    var orderedCards = deck.Display();
        //    deck.Shuffle();
        //    var shuffledCards = deck.Display();
        //    shuffledCards.ForEach(o => System.Diagnostics.Debug.WriteLine(o));
        //    Assert.AreNotEqual(string.Join(",", orderedCards), string.Join(",", shuffledCards));
        //}
    }
}
