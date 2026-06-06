using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarGenerator : MonoBehaviour
{
    [SerializeField] GameObject Carprefab;
    public float span = 1.0f;
    float delta = 0;
    float a = 0;

    public Sprite[] walk;
    int sprite_index;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        sprite_index = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
        this.delta += Time.deltaTime;
        this.a += Time.deltaTime;

        if (this.delta > this.span)
        {

            this.delta = 0;
            GameObject go = Instantiate(Carprefab);
            go.GetComponent<SpriteRenderer>().sprite = walk[Random.Range(0, 11)];
            float px = Random.Range(-2.5f, 2.5f);
            go.transform.position = new Vector3(px, 7, 0);
            if (this.a >= 0 && this.a < 10)
            {
                go.GetComponent<CarController>().speed = -10;
            }
            else if (this.a >= 10 && this.a < 15)
            {
                go.GetComponent<CarController>().speed = -13;
            }
            else if (this.a >= 15 && this.a < 20)
            {
                go.GetComponent<CarController>().speed = -15;
            }
            else
            {
                go.GetComponent<CarController>().speed = -17;
            }

        }
        if (this.a >= 0 && this.a < 10)
        {
            span = 1.0f;
            print("1");
        }
        else if (this.a >= 10 && this.a < 15)
        {
            span = 0.7f;
            print("2");
        }
        else if (this.a >= 15 && this.a < 20)
        {
            span = 0.5f;
            print("3");
        }
        else
        {
            span = 0.3f;
            print("4");
        }
    }
}

