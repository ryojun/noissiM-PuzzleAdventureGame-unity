using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map2Code : MonoBehaviour {

    // Use this for initialization
    void Start()
    {if(PlayerPrefs.GetInt("Stay") <2)
        PlayerPrefs.SetInt("Stay", 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GotoHome()
    {
        Application.LoadLevel(0);

    }
    public void PlayAgian()
    {
        Application.LoadLevel("Scene02");
    }
    public void GotoNext()
    {
        Application.LoadLevel("Scene03");
    }
}
