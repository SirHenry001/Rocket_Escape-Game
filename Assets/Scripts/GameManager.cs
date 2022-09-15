using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timer;
    public float recordTime;
    public float rocketIncreasedSpeed, rocketIncreaseSpeed2;
    public SpaceRocket spaceRocketScript;

    //Variables for score

    public int score;
    public int hiScore;
    public GameObject scoreText;
    public GameObject hiScoreText;

    public Text timerText;
    public Text recordTimeText;
    public bool gameEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        hiScore = PlayerPrefs.GetInt("HiScoreText");
        recordTime = PlayerPrefs.GetFloat("RecordTime", 60f);
        hiScoreText.GetComponent<Text>().text = "HiSCORE:" + hiScore.ToString();
        recordTimeText.text = "Record" + recordTime.ToString();
        //hiScoreText.GetComponent<TextMeshProUGUI>().text = hiScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "TIME:" + timer.ToString();

        if (!gameEnd)
        {
            timer += Time.deltaTime;
        }
    }

    public void AddScore()
    {
        score += 100;
        scoreText.GetComponent<Text>().text = "SCORE: " + score.ToString();

        if (score > hiScore)
        {
            hiScore = score;
            hiScoreText.GetComponent<Text>().text = "HiSCORE:" + hiScore.ToString();
            PlayerPrefs.SetInt("HiScoreText", hiScore);
            PlayerPrefs.Save();
        }
    }

    public void TimeRecorder()
    {
        if(timer<recordTime)
        {
            recordTime = timer;
            PlayerPrefs.SetFloat("RecordTime",timer);
            recordTimeText.text = "Record" + recordTime.ToString();
            PlayerPrefs.Save();
        }

    }
}
