using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultySelect : MonoBehaviour
{
    public Slider PlayerCount;
    public Text PlayerText;
    public Slider TileCount;
    public Text TileText;
    public Button Play;
    public Toggle Timer;
    public Text TimeVal;
    public Slider TimeAdjust;

    private int _players;
    private int _tiles;

    void Start()
    {
        // handles player count
        PlayerCount.onValueChanged.AddListener(delegate { DisplayPlayers(); });
        PlayerCount.minValue = 4;
        PlayerCount.maxValue = 8;
        DisplayPlayers();

        // handles total game tiles
        // min and max value scales depending on number of players
        TileCount.onValueChanged.AddListener(delegate { DisplayTiles(); });
        TileCount.minValue = 24;
        TileCount.maxValue = 40;
        DisplayTiles();
        Play.onClick.AddListener(StartGameplay);

        // toggle whether or not to set a time limit on turns
        Timer.onValueChanged.AddListener(delegate { ToggleTimer(); });
        // timer value ranged from 1 minute to 5 minutes
        TimeAdjust.minValue = 60;
        TimeAdjust.maxValue = 300;
        TimeAdjust.onValueChanged.AddListener(delegate { RoundTime(); });
    }

    void Update()
    {
        
    }

    //  change scene to begin gameplay
    void StartGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }

    // rounds and displays slider value
    void DisplayPlayers()
    {
        var players = (int)PlayerCount.value;
        // TileCount's min and max value depends on how many players there are
        // Min: 6 tiles per player
        // Max: 10 tiles per player
        TileCount.minValue = players * 6;
        TileCount.maxValue = players * 10;
        TileCount.value = TileCount.minValue;
        DisplayTiles();

        PlayerText.text = string.Format("{0} players", players);
    }

    // round and display slider value
    void DisplayTiles()
    {
        // tile count must be even because must have the same amount of black and white tiles
        if((int)TileCount.value % 2 == 1)
            TileCount.value += 1;
        TileText.text = string.Format("{0} tiles", (int)TileCount.value);
    }

    // displays text and slider if timer is toggled on
    void ToggleTimer()
    {
        if(Timer.isOn)
        {
            TimeVal.enabled = true;
            TimeAdjust.enabled = true;
        }
        else
        {
            TimeVal.enabled = false;
            TimeAdjust.enabled = false;
            TimeAdjust.value = TimeAdjust.minValue;
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

    // formats a float into a string formatted to display time in minutes and seconds
    string ParseTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
