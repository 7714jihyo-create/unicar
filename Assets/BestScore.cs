using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
//최고 점수 불러오기 및 표시: PlayerPrefs 시스템을 사용하여 기기에 저장된 "HighScore" 데이터를 찾아옵니다 만약 저장된 기록이 없다면 기본값인 0을 가져옵니다.
//UI 업데이트: 게임이 시작될 때(Start 메서드), 불러온 점수를 "Best score: [점수]" 형태의 문자열로 변환하여 화면상의 BestscoreText 요소에 출력합니다. 이때 .ToString("F0")을 사용하여 소수점 없이 정수 형태로 표시하도록 설정되어 있습니다.
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
