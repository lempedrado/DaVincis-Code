using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuHandler : MonoBehaviour
{
    public Button Play;
    public Button HowToPlay;

    void Start()
    {
        Play.onClick.AddListener(PlayPressed);
        HowToPlay.onClick.AddListener(ShowHowToPlay);
    }

    void Update()
    {
        
    }

    // changes scene to set game difficulty/settings
    void PlayPressed()
    {
        SceneManager.LoadScene("Difficulty");
    }

    // changes scene to display rules and game instructions
    void ShowHowToPlay()
    {
        SceneManager.LoadScene("HTP");
    }
}
