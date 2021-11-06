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

    void Update()
    {
        
    }

    void StartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
