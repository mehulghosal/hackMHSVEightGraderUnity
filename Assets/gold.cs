using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : MonoBehaviour {
  
    public Renderer rend;
	// Use this for initialization
	void Start () {
       
        rend = this.GetComponent<Renderer>();
        rend.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		if (Global.key) {
            
			rend.enabled = false;
		} else {
			rend.enabled = true;
		}
		Debug.Log (Global.key);
	}
}
