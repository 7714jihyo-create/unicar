using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetFloat("Score", 0f));
        scoreText.text = "Score: " + PlayerPrefs.GetFloat("Score", 0f).ToString("F0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
