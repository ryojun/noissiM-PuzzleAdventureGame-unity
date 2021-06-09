using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map3Code : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("Stay") < 3)
            PlayerPrefs.SetInt("Stay", 3);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GotoHome()
    {
        Application.LoadLevel(0);

    }
    public void PlayAgian()
    {
        Application.LoadLevel("Scene03");
    }
    public void GotoNext()
    {
        Application.LoadLevel("Scene04");
    }
}
