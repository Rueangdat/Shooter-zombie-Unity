using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour
{
    public static int score;
    public static int highscore;
    Text text;

    // Use this for initialization
    void Start()
    {
        score = 0;
        text = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("highscore", highscore);
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
        }
        text.text = "สังหาร : " + score;
    }
}
