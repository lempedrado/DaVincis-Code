using System;
using System.Collections;
using UnityEngine;

public class Tile : MonoBehaviour
{
    //The value of the Tile. Equals -1 if wildcard
    public int val;

    //The color of the Tile. Either Black or White.
    public Color color;

    //protected const int WIDTH = ;

    // Reference to the Tile prefab
    public GameObject tilePrefab;
    public Material white;
    public Material black;

    //Reference to the Tile GameObject 
    protected GameObject obj;

    public Tile(int val, Color color)
    {
        //check if Tile value is not a wildcard or NaN
        if(val < -1)
            throw new ArgumentException("Invalid tile value");
    
        // validate Tile color
        if(color != Color.black && color != Color.white)
            throw new ArgumentException("Color must be black or white.");

        this.val = val;
        this.color = color;
        obj = (GameObject)Instantiate(tilePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        string s = (val == -1) ? "-" : val.ToString();
        //set the Tile value
        //((GameObject)obj).transform.GetChild(0).gameObject.GetComponent(typeof(TextMesh)).text = s;
        //((GameObject)obj).GetComponentInChildren(typeof(TextMesh)).text = s;
        //set the Tile color
        ((GameObject)obj).GetComponent<Renderer>().material = (color == Color.black) ? black : white;
    }

    public Color GetColor()
    {
        return this.color;
    }
}
