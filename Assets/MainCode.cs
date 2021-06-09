using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCode : MonoBehaviour {
    public GameObject StarterBlock;
    public GameObject CanvasUp, CanvasDown, CanvasLeft, CanvasRight;
    public GameObject ReadyButton;

    public SpriteRenderer []GameImage;
	void Start () {

        PlayerPrefs.SetInt("Ready", 0);
        CanvasUp.SetActive(false);
        
        CanvasLeft.SetActive(false);
        CanvasRight.SetActive(false);
        ReadyButton.SetActive(true);
	}
	
	void Update () {
		if(PlayerPrefs.GetInt("Ready") == 1)
        {

            CanvasUp.SetActive(true);
            
            CanvasLeft.SetActive(true);
            CanvasRight.SetActive(true);
            ReadyButton.SetActive(false);
            DestroyObject(StarterBlock);
        }
	}
    public void ReadyFunc()
    {

        PlayerPrefs.SetInt("Ready", 1);
        GameImage[0].sprite = null;
        GameImage[1].sprite = null;
        GameImage[2].sprite = null;
        GameImage[3].sprite = null;
        GameImage[4].sprite = null;
        GameImage[5].sprite = null;
        GameImage[6].sprite = null;
        GameImage[7].sprite = null;
        GameImage[8].sprite = null;
        GameImage[9].sprite = null;
        GameImage[10].sprite = null;
        GameImage[11].sprite = null;
        GameImage[12].sprite = null;
        GameImage[13].sprite = null;
        GameImage[14].sprite = null;
        GameImage[15].sprite = null;
    }
    
}
