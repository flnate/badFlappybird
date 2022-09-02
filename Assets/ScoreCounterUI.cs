using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounterUI : MonoBehaviour
{
    public Text scoreText;
    int score;
    
    public static ScoreCounterUI instance;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
