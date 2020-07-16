using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    private Card[] cards;
    private int start = 0;
    static System.Random r = new System.Random();

    public Deck()
    {
        GenerateDeck();
    }

    public Card takeTop()
    {
        if (start == (Card.NUM_NUMBERS * Card.NUM_SUITS - 1))
        {
            return null;
        }
        start++;
        return cards[start - 1];
    }

    public void reset()
    {
        shuffle();
        start = 0;
    }

    public void shuffle()
    {
        for (int n = cards.Length - 1; n > 0; --n)
        {
            int k = r.Next(n + 1);
            Card temp = cards[n];
            cards[n] = cards[k];
            cards[k] = temp;
        }
    }

    private void GenerateDeck()
    {
        cards = new Card[Card.NUM_NUMBERS * Card.NUM_SUITS];

        for (int i = 0; i < Card.NUM_NUMBERS; i++)
        {
            for (int j = 0; j < Card.NUM_SUITS; j++)
            {
                Card newCard = new Card((Card.Number)i, (Card.Suit)j);
                cards[newCard.getIndex()] = newCard;
                //print(i * Card.NUM_SUITS + j);
            }
        }
    }

}
