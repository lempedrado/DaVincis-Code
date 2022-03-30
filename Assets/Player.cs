using System.Collections;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //maximum 10 tiles per player
    public Tile[] hand = new Tile[10];

    //current number of tiles in player's hand
    private int size = 0;

    //distance between each tile in the hand
    //private const int DISTANCE = ;

    public int unrevealedTiles;
    


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /**
     *  Inserts the drawn Tile into the Player's hand.
     *  If the Tile is a wildcard, prompts user 
     *  for where to place the Tile
     *
     *  <param name="t"> The Tile being placed in the hand </param>
     */
    public void Insert(Tile t)
    {
        if(t.val == -1)
        {
            PlaceWildcard(t);
            return;
        }
        
        for(int i = 0; i < hand.Length - 1; i++)
        {
            //continue until this tile should be placed
            if(t.val < hand[i].val)
                continue;
            //if 2 tiles of the same value, black is placed after
            if(hand[i].val == t.val && t.color == Color.black)
                i++;
            //insert tile
            hand[i] = t;
            break;
        }
    }

    //moves the wildcard tile along the array waiting for user to confirm its position
    /** Prompts Player for where to place their wildcard Tile */
    void PlaceWildcard(Tile wc)
    {
        //TODO
    }

    /**
     *  Reveals the passed tile to all Players
     */
    void RevealTile(Tile t)
    {
        //rotate tile
        //t.Tranform.rotation
        unrevealedTiles--;
    }

    /*
        get width of hand's area
        get size of the hand
        tiles take up (tile.width * # of tiles) + (# of tiles - 1 * distance) space
        subtract ^^ from total width and divide by 2 to get buffer on either end of the hand
    */
    void Display()
    {
        //TODO
    }
}
