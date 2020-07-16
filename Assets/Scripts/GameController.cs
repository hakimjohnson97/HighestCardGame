using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Contains all the logic of the game. Uses the classes Card and Deck which are in separate files.
*/

public class GameController : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject textBox;
    public GameObject playText;
    public GameObject player1Text;
    public GameObject player2Text;
    private SpriteRenderer card1SpriteRenderer;
    private SpriteRenderer card2SpriteRenderer;

    public Deck deck;
    public Sprite[] sprites;


    // Start is called before the first frame update
    void Start()
    {
        deck = new Deck();

        card1SpriteRenderer = card1.GetComponent<SpriteRenderer>();
        card2SpriteRenderer = card2.GetComponent<SpriteRenderer>();

    }

    public void playGame()
    {
        deck.reset();
        Card taken1 = deck.takeTop();
        card1SpriteRenderer.sprite = sprites[taken1.getIndex()];
        Card taken2 = deck.takeTop();
        card2SpriteRenderer.sprite = sprites[taken2.getIndex()];

        int compareResult = taken1.compare(taken2);
        if (compareResult == 1)
        {
            textBox.GetComponent<UnityEngine.UI.Text>().text = "Player 1 wins";
        }
        else if (compareResult == 0)
        {
            textBox.GetComponent<UnityEngine.UI.Text>().text = "Draw";
        }
        else
        {
            textBox.GetComponent<UnityEngine.UI.Text>().text = "Player 2 wins";
        }

        playText.GetComponent<UnityEngine.UI.Text>().text = "Play again";
        player1Text.GetComponent<UnityEngine.UI.Text>().text = "Player 1";
        player2Text.GetComponent<UnityEngine.UI.Text>().text = "Player 2";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

