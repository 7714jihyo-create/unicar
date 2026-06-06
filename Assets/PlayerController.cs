using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger ¸ðµå");
        Invoke("aa", 0.28f);
      
        
    }
    void aa()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 v = new Vector3(-10f*Time.deltaTime, 0, 0);
            transform.Translate(v);
        }

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(10f*Time.deltaTime, 0, 0);
        }

        float xxx = Mathf.Clamp(transform.position.x, -2.5f, 2.5f);
        transform.position = new Vector3(xxx,transform.position.y,transform.position.z);

    }

    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    }

    


}
