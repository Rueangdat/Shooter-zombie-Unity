using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBestScore : MonoBehaviour
{
    public Text best;
    public int high;
    // Use this for initialization
    void Start()
    {
        high = PlayerPrefs.GetInt("highscore", high);
        best.text = "สังหารสูงสุด : " + high;
    }

}
