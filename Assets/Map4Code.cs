using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map4Code : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("Stay") < 4)
            PlayerPrefs.SetInt("Stay", 4);

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
        Application.LoadLevel("Scene04");
    }
    public void GotoNext()
    {
        Application.LoadLevel(0);
    }
}
