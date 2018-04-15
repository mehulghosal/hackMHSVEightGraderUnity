using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    Animator animator;
    Transform transform;
    Rigidbody2D rb;
    Vector2 up;
	int foo;
    bool key1;
	public Collider coll;
    // Use this for initialization
    void Start()
        
    {
		coll = GetComponent<Collider>();
        animator = this.GetComponent<Animator>();
        transform = this.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
        up = new Vector2(0, 1);
       
    }

    

   

    // Update is called once per frame
    void Update()
    {
		foo = Global.deaths;
        if(Input.GetMouseButtonDown(0))
        {


            animator.SetTrigger("spacepressed");
            animator.SetInteger("attack", 1);
			coll.material.bounciness = 100;
			
        }
        if(Input.GetKey("w"))
        {
            rb.velocity = new Vector3(0, 6, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        if(Input.GetKey("s"))
        {
            rb.velocity = new Vector3(0, -6, 0);
        }
        if(Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-6, 0, 0);
        }
        if(Input.GetKey("d"))
        {
            rb.velocity = new Vector3(6, 0, 0);
        }

					
    }
    void OnTriggerEnter2D(Collider2D door)
    {
        if (door.gameObject.name == "door")
        {
            SceneManager.LoadScene("level 1", LoadSceneMode.Single);
        }
        if (door.gameObject.name == "enemy")
        {
            SceneManager.LoadScene("Death", LoadSceneMode.Single);
			foo++;
			Global.deaths = foo;

        }
        if (door.gameObject.name == "exit")
        {
            SceneManager.LoadScene("level 2", LoadSceneMode.Single);
            Global.level = 2;
            Global.key = false;
        }
        if (door.gameObject.name == "Crypto_key.svg")
        {
           
            Global.key = true;

        }
		if (door.gameObject.name == "line (1)" && Global.key) {
			SceneManager.LoadScene("level 3", LoadSceneMode.Single);
			Global.level = 3;
		}
		if (door.gameObject.name == "lv3wall") {
			SceneManager.LoadScene("level 4", LoadSceneMode.Single);
			Global.level = 4;
		}

        
    }
}


