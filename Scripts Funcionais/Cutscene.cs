using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene: MonoBehaviour {

    public float time = 0.0f;
    
    

	// Use this for initialization
	void Start () {

        
    }
    

    // Update is called once per frame
    private void Update () {        

        time += Time.deltaTime;
		
        if(time >= 65.08f)
        {
            Application.LoadLevel("Level_1");
            
        }

	}
}
