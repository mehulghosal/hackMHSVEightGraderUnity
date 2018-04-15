using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {

	 Renderer visi;
	// Use this for initialization
	void Start () {

		visi = this.GetComponent<Renderer>();
		visi.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Global.key) {
			visi.enabled = true;
		} 
		else {
			visi.enabled = false;
		}
	}
}
