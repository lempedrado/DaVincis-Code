using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraView : MonoBehaviour
{
    public Camera Player1;
    public Camera Player2;
    public Camera Player3;
    public Camera Player4;

    // Start is called before the first frame update
    void Start()
    {
        ChangePlayer(Player1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            ChangePlayer(Player1);
        }
        else if(Input.GetKeyDown("2"))
        {
            ChangePlayer(Player2);
        }
        else if(Input.GetKeyDown("3"))
        {
            ChangePlayer(Player3);
        }
        else if(Input.GetKeyDown("4"))
        {
            ChangePlayer(Player4);
        }
    }

    // disable all active Cameras and enable the specified Camera
    private void ChangePlayer(Camera player)
    {
        foreach(var c in Camera.allCameras)
            c.enabled = false;
        player.enabled = true;
    }
}

