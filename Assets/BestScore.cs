using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public Text BestscoreText;
    // Start is called before the first frame update
    void Start()
    {   
        BestscoreText.text = "Best score: " + PlayerPrefs.GetFloat("HighScore", 0f).ToString("F0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
