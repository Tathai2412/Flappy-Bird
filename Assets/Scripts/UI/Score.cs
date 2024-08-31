using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public static int highScoreValue = 0;

    public Text score;
    public Text highScore;
    // Start is called before the first frame update
    // void Start()
    // {
    //     score = GetComponent<Text>();
    //     highScore = GetComponent<Text>();
    // }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + scoreValue;
        highScore.text = "High Score: " + highScoreValue;
    }
}
