using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Hand
    {
        public List<Card> cards = new List<Card>();

        public int Count
        {
            get
            {
                return cards.Count();
            }
        }


        public Card this[int index]
        {
            get
            {
                return cards[index];
            }
        }


        public void AddCard(Card newCard)
        {
            // the List<T>.Contains method cannot be used since it only checks if the same reference object exists
            /*if (ContainsCard(newCard))
            {
                throw new ConstraintException(newCard.FaceValue.ToString() + " of " +
                    newCard.Suit.ToString() + " already exists in the Handsss");
            }*/

            cards.Add(newCard);
        }

        public void RemoveCard(Card theCard)
        {
            if(!cards.Contains(theCard))
            {
                throw new ConstraintException(theCard.FaceValue.ToString() + "of" +
                    theCard.Suit.ToString() + "does not exist in the hand.");
            }
            cards.Remove(theCard);
        }

        public void RemoveCard(int index)
        {
            if(index < 0 || index > cards.Count - 1)
            {
                throw new DataException("A card does not exist at the index specified.");
            }
            cards.RemoveAt(index);
        }

        public void  RemoveCard(Suit theSuit, FaceValue theFaceValue)
        {
            Card card = cards.Where(c => c.FaceValue == theFaceValue && c.Suit == theSuit).FirstOrDefault();

            if (card == null)
            {
                throw new ConstraintException(theFaceValue.ToString() + "of" +
                    theSuit.ToString() + "does not exist in the hand.");
            }
            cards.Remove(card);
        }
    }
}
