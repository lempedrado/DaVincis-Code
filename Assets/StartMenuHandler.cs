using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuHandler : MonoBehaviour
{
    public Button Play;
    public Button HowToPlay;
    public Toggle Timer;
    public Text TimeVal;
    public Slider TimeAdjust;

    void Start()
    {
        Play.onClick.AddListener(PlayPressed);
        HowToPlay.onClick.AddListener(ShowHowToPlay);
        Timer.onValueChanged.AddListener(delegate { ToggleTimer(); });
        //timer value ranged from 1 minute to 5 minutes;
        TimeAdjust.minValue = 60;
        TimeAdjust.maxValue = 300;
        TimeAdjust.onValueChanged.AddListener(delegate { RoundTime(); });
    }

    void Update()
    {
        
    }

    // called when play button is pressed
    // prompts player to select difficulty and player count before starting
    void PlayPressed()
    {
        //GetComponent<Canvas>().enabled = false;
        SceneManager.LoadScene("Difficulty");
        SelectDifficulty();
    }

    void SelectDifficulty()
    {
        //Find("DifficultySelect").enabled = true;
        // easy, normal, hard ; total tiles is decided by tiler per player not including wildcards
        //easy: 6 tiles per player
        //normal: 8 tiles per player 
        //hard: 10 tiles per player
        // alternative have the user input total tiles for the game, minimum total 4 per person for start
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
        //SceneManager.UnloadSceneAsync("StartMenu");
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Gameplay"));
    }

    void ShowHowToPlay()
    {
        SceneManager.LoadScene("HTP");
    }

    //
    void ToggleTimer()
    {
        if(Timer.isOn)
        {
            TimeVal.enabled = true;
            TimeAdjust.enabled = true;
            //TimeAdjust.gameObject.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            TimeVal.enabled = false;
            TimeAdjust.enabled = false;
            TimeAdjust.value = TimeAdjust.minValue;
            //TimeAdjust.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    // rounds slider value to change in 15 second intervals
    void RoundTime()
    {
        var interval = 15;
        var offset = (int)TimeAdjust.value % interval;
        if(offset < (interval / 2))
            TimeAdjust.value -= offset;
        else
            TimeAdjust.value += (interval - offset);
        TimeVal.text = ParseTime(TimeAdjust.value);
    }

    string ParseTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
