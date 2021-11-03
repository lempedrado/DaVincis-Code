using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public Button Back;

    void Start()
    {
        Back.onClick.AddListener(StartMenu);
    }

    public void StartMenu()
    {
        Debug.Log("try to change scene");
        SceneManager.LoadScene("StartMenu");
        Debug.Log("after scene change");
    }

    void Update()
    {
        
    }
}
