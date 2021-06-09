using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gomenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Gotomenu()
    {
        Application.LoadLevel("Start");
    }
    public void Lose()
    {
        Application.LoadLevel("Map006");
    }
}
