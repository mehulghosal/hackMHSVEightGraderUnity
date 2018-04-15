using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	float m_distanceTraveled = 0f;
	bool j = false;
	bool g = true;


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update() {
		if (m_distanceTraveled <= 3f ) {
			Vector3 oldPosition = transform.position;
			transform.Translate (0, -1, 0 * Time.deltaTime * 100);
			m_distanceTraveled += Vector3.Distance (oldPosition, transform.position);
		} 
		if (m_distanceTraveled > 3f && m_distanceTraveled < 8f) {
			Vector3 oldPosition = transform.position;
			transform.Translate (0, 1, 0 * Time.deltaTime * 100);
			m_distanceTraveled += Vector3.Distance (oldPosition, transform.position);
		} 

	}
}
