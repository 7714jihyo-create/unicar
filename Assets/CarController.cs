using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    GameObject x;
    ScoreCount xx;
    public float speed=-10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger 모드");
        GetComponent<AudioSource>().Play();

        x = GameObject.Find("GameDirector");
        xx = x.GetComponent<ScoreCount>();
        float z = PlayerPrefs.GetFloat("HighScore", 0f);
        PlayerPrefs.SetFloat("Score", xx.score);
        if (xx.score > z)
        {
            PlayerPrefs.SetFloat("HighScore", xx.score);
        }

    }
    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, speed * Time.deltaTime, 0);

        if (transform.position.y < -7.0f)
        {
            Destroy(gameObject);
        }

    }
}
