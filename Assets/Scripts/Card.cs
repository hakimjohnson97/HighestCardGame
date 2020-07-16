using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public enum Number { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace };
    public enum Suit { Clubs, Diamonds, Hearts, Spades };
    public static int NUM_SUITS = 4;
    public static int NUM_NUMBERS = 13;

    public Card(Number argNumber, Suit argSuit)
    {
        number = argNumber;
        suit = argSuit;
    }

    public int getIndex()
    {
        return ((int)number) * Card.NUM_SUITS + ((int)suit);
    }

    public int compare(Card otherCard)
    {
        if (((int)number) > ((int)otherCard.number))
        {
            return 1;
        }
        else if (((int)number) == ((int)otherCard.number))
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }


    public Number number;
    public Suit suit;
}