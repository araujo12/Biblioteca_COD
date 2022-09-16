using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
        

    // Use this for initialization
    void Start () {
        Application.LoadLevel("Main");        
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    // Load Scene audio
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);        
    }
        
}
