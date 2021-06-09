using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeRunning : MonoBehaviour {
    public Text TimeText;
    float GameTime;
    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("GameTime", 0);
        GameTime = 0;
        TimeText.text = "" + (int)GameTime;
	}
	
	// Update is called once per frame
	void Update () {
        TimeText.text = "" + (int)GameTime;
        GameTime += Time.deltaTime;
        PlayerPrefs.SetInt("GameTime", (int)GameTime);
    }
}
