using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Code : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("Stay") < 1)
            PlayerPrefs.SetInt("Stay", 1);

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
        Application.LoadLevel("Scene01");
    }
    public void GotoNext()
    {
        Application.LoadLevel("Scene02");
    }
}
