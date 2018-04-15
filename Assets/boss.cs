using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			rb.velocity = new Vector3(0, 6, 0);
		}
		else
		{
			rb.velocity = new Vector3(0, 0, 0);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			rb.velocity = new Vector3(0, -6, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			rb.velocity = new Vector3(-6, 0, 0);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			rb.velocity = new Vector3(6, 0, 0);
		}

	}
}
