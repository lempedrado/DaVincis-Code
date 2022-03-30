using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Windows.Forms;

public class Gameplay : MonoBehaviour
{
    //array of players
    private List<Player> players = new List<Player>();

    //list of tiles (Pile)
    private List<Tile> tiles = new List<Tile>();
   
    private void Start()
    {
        //replace constant with total # of game tiles / 2
        for(int i = 0; i < 12; i++)
        {
            tiles.Add(new Tile(i, Color.black));
            tiles.Add(new Tile(i, Color.white));
        }
        //if Wildcard tiles are enabled
        //tiles.Add(new Tile(-1, Color.black));
        //tiles.Add(new Tile(-1, Color.white));

        //Shuffle();
    }

    void Update()
    {
        
    }

    /**
     *  Shuffles the Tile objects in the pile
     *  Places the tiles in random positions and loops
     *  this action several times.
     *  copy from APCSA card game
     */
    void Shuffle()
    {
       //TODO 
    }

    //method to move tiles to players
    /**
     *  Draws a random Tile from the pile and places it
     *  into the current Player's hand.
     */
    void Draw(Player p)
    {
        //get random tile from Tiles
        Tile t = tiles[0];
        tiles.RemoveAt(0);
        //pass Tile to Player's Insert() method
        p.Insert(t);
    }

    //method to handle guessing
    /**
     *  Prompts the Player to choose another Player 
     *  and guess one of their Tile's value.
     */
    string Guess()
    {
        string g = Console.ReadLine();
        //choose Player to target
        //display buttons attached to each player and receive input
        
        //choose Tile to target
        //highlight or overlay buttons over tiles and zoom into player's hand

        //display prompt to guess the Tile's value
        //buttons of all possible vals? or txt box?

        //compare guess to actual value
        //if input == t.val
        //reveal(t)
        //else reveal(player's t)

        //call RevealTile() on the approriate Tile

        //if all of the Player's Tiles are revealed, destroy their CameraView
        return g;
    }

    //method to reveal tile value
    /**
     * Rotates the passed Tile to reveal it to all Players.
     *  <param name="t"> The Tile being revealed. </param>
     */
     //or pass the Player and an index of the tile that has been revealed
    void RevealTile(Tile t)
    {
        //rotate Tile 180 degrees horizontally, or 90 degrees vertically

        //(optional) move Tile forward

        //if(Player.unrevealedTiles == 0)
        //destroy player
    }

    //method to prompt for continuing after correct guess
    /**
     *  Prompts the current Player if they would like to
     *  continue guessing if they guessed correctly
     */
    bool Continue()
    {
        return false;
        //DialogResult dialogResult = Show("Would you like to continue guessing?", "Continue?", MessageBoxButtons.YesNo);
        //return dialogResult == DialogResult.Yes;
        //prompt input whether or not to continue guessing

        //return
    }

    //method to handle game end
    /**
     *  Displays a congratulation message to the winning Player.
     *  Prompts the host or all player take a vote to continue
     *  playing or to edit game settings.
     */
    void EndGame()
    {
        //congratulation message for winner

        //prompt to play again or edit settings
    }
}
