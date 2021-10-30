using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public Camera player1;
    public Camera player2;
    public Camera player3;
    public Camera player4;

    // Start is called before the first frame update
    void Start()
    {
        player1.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            changePlayer(player1);
        }
        else if(Input.GetKeyDown("2"))
        {
            changePlayer(player2);
        }
        else if(Input.GetKeyDown("3"))
        {
            changePlayer(player3);
        }
        else if(Input.GetKeyDown("4"))
        {
            changePlayer(player4);
        }
    }

    // disable all active Cameras and enable the specified Camera
    private void changePlayer(Camera player)
    {
        foreach(Camera c in Camera.allCameras)
            c.enabled = false;
        player.enabled = true;
    }
}
