using System.Collections.Generic;

namespace Shuffle
{
    public interface IDeck
    {
        /// <summary>
        /// Returns a list of the names of all of the cards in the deck
        /// </summary>
        /// <returns></returns>
        List<string> Display();

        /// <summary>
        /// Reorder all of the cards in the deck
        /// </summary>
        /// <param name="iterations">Number of times to shuffle the cards</param>
        void Shuffle(int iterations = 1);

        /// <summary>
        /// Returns the top card from the deck and removes it from the deck.
        /// </summary>
        void Draw();
    }
}