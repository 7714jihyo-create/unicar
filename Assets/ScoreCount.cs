using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public float score=0;
    public Text timeText; 

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        timeText.text = "score: "+score.ToString("F0");
        // 초당 1점씩 화면에 점수 표시
    }


}
