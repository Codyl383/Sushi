using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMan : MonoBehaviour {

    public static int score;
    public Text scoreText;

    public Text hiScoreText;
    public float hiScoreCount;



	void Start ()
    {
       /* scoreText = GetComponent<Text>();
        hiScoreText = GetComponent<Text>();
        score = 0;
        */
	}
	
	
	void Update ()
    {
        if (score < 0)
            score = 0;

        if(score > hiScoreCount)
        {
            hiScoreCount = score;
        }

        scoreText.text = "Score: " + score;
        hiScoreText.text = "High Score: " + hiScoreCount;
           
	}

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void Reset()
    {
        score = 0;
    }

}
