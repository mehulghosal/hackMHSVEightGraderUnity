using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bo : MonoBehaviour {
    float startTime;
    

    
	// Use this for initialization
	void Start () {
     
        
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startTime >= 3.0)
        {
            
           
			if (Global.deaths == 3) {
				SceneManager.LoadScene ("Constant", LoadSceneMode.Single);
				Global.deaths = 0;
			} 
			else if(Global.level == 0)
            {
				SceneManager.LoadScene ("level 1", LoadSceneMode.Single);
			}
            else if(Global.level == 2)
            {
                SceneManager.LoadScene("level 2", LoadSceneMode.Single);
                Global.key = false;
            }
			else if(Global.level == 3)
			{
				SceneManager.LoadScene("level 3", LoadSceneMode.Single);
				Global.key = false;
			}
            
           
            
        }
      
	}
}
