using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour {

    public int auto;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Load Scene Main
    public void LoadMain()
    {
        Application.LoadLevel("Main");
    }

    //Load Scene Options
    public void LoadOptions()
    {
        Application.LoadLevel("Options");
    }

    //Load Scene Credits
    public void LoadCredits()
    {
        Application.LoadLevel("Credits");
    }

    //Load Scene Perfil
    public void LoadPerfil()
    {
        Application.LoadLevel("Perfil");
    }

    //Load Scene Shop
    public void LoadShop()
    {
        Application.LoadLevel("Shop");
    }

    //Load Scene Maps
    public void LoadMaps()
    {
        Application.LoadLevel("Sel_map");
    }

    //Load Scene Level
    public void LoadLevel()
    {
        Application.LoadLevel("Sel_level");
    }

    //Load Scene Level
    public void LoadLevel1()
    {
        Application.LoadLevel("CutScene");
        auto = 1;
    }

    public void LoadArea1()
    {
        Application.LoadLevel("Level_1");
    }

    

    //Close Application
    public void CloseAp()
    {
        Application.Quit();
    }

    //Load start deep
    public void LoadDeep()
    {
        Application.LoadLevel("deep");
    }
    
}
