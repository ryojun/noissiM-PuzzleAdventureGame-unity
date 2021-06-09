using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select : MonoBehaviour {
    int LevelMem;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Text bt1;
    public Text bt2;
    public Text bt3;
    public Text bt4;
    public Text bt5;
    public Text bt6;
    public Text bt7;
    public Text bt8;
    public Text bt9;
    public Text bt10;
    public AudioSource audio;
    public Image SoundSwitch;
    public GameObject Lk2, Lk3, Lk4, Lk5, Lk6, Lk7, Lk8, Lk9, Lk10;
    void Start () {

        button1.GetComponent<Button>().enabled = true;
        button2.GetComponent<Button>().enabled = false;
        button3.GetComponent<Button>().enabled = false;
        button4.GetComponent<Button>().enabled = false;
        button5.GetComponent<Button>().enabled = false;
        button6.GetComponent<Button>().enabled = false;
        button7.GetComponent<Button>().enabled = false;
        button8.GetComponent<Button>().enabled = false;
        button9.GetComponent<Button>().enabled = false;
        button10.GetComponent<Button>().enabled = false;

        
        Lk2.SetActive(true);
        Lk3.SetActive(true);
        Lk4.SetActive(true);
        Lk5.SetActive(true);
        Lk6.SetActive(true);
        Lk7.SetActive(true);
        Lk8.SetActive(true);
        Lk9.SetActive(true);
        Lk10.SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {
        LevelMem = PlayerPrefs.GetInt("Map");
        if (PlayerPrefs.GetInt("SoundMem") == 0)
        {
            audio.mute = true;
            SoundSwitch.color = new Color32(255, 255, 255, 120);
            
        }
        if (PlayerPrefs.GetInt("SoundMem") == 1)
        {
            audio.mute = false;
            SoundSwitch.color = new Color32(255, 255, 255, 255);
        }
        if (LevelMem == 0)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = false;
            button3.GetComponent<Button>().enabled = false;
            button4.GetComponent<Button>().enabled = false;
            button5.GetComponent<Button>().enabled = false;
            button6.GetComponent<Button>().enabled = false;
            button7.GetComponent<Button>().enabled = false;
            button8.GetComponent<Button>().enabled = false;
            button9.GetComponent<Button>().enabled = false;
            button10.GetComponent<Button>().enabled = false;
            bt2.text = "";
            bt3.text = "";
            bt4.text = "";
            bt5.text = "";
            bt6.text = "";
            bt7.text = "";
            bt8.text = "";
            bt9.text = "";
            bt10.text = "";
        }
        if (LevelMem == 1)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = false;
            button3.GetComponent<Button>().enabled = false;
            button4.GetComponent<Button>().enabled = false;
            button5.GetComponent<Button>().enabled = false;
            button6.GetComponent<Button>().enabled = false;

        }
        if (LevelMem == 2)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = false;
            button4.GetComponent<Button>().enabled = false;
            button5.GetComponent<Button>().enabled = false;
            button6.GetComponent<Button>().enabled = false;
            bt2.text = "2";
            Lk2.SetActive(false);
            Lk3.SetActive(true);
            Lk4.SetActive(true);
            Lk5.SetActive(true);
            Lk6.SetActive(true);
            Lk7.SetActive(true);
            Lk8.SetActive(true);
            Lk9.SetActive(true);
        }
        if (LevelMem == 3)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = true;
            button4.GetComponent<Button>().enabled = false;
            button5.GetComponent<Button>().enabled = false;
            button6.GetComponent<Button>().enabled = false;
            bt2.text = "2";
            bt3.text = "3";
            Lk2.SetActive(false);
            Lk3.SetActive(false);
            Lk4.SetActive(true);
            Lk5.SetActive(true);
            Lk6.SetActive(true);
            Lk7.SetActive(true);
            Lk8.SetActive(true);
            Lk9.SetActive(true);
        }
        if (LevelMem == 4)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = true;
            button4.GetComponent<Button>().enabled = true;
            button5.GetComponent<Button>().enabled = false;
            button6.GetComponent<Button>().enabled = false;
            bt2.text = "2";
            bt3.text = "3";
            bt4.text = "4";
            Lk2.SetActive(false);
            Lk3.SetActive(false);
            Lk4.SetActive(false);
            Lk5.SetActive(true);
            Lk6.SetActive(true);
            Lk7.SetActive(true);
            Lk8.SetActive(true);
            Lk9.SetActive(true);
        }

        if (LevelMem == 5)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = true;
            button4.GetComponent<Button>().enabled = true;
            button5.GetComponent<Button>().enabled = true;
            button6.GetComponent<Button>().enabled = false;
            bt2.text = "2";
            bt3.text = "3";
            bt4.text = "4";
            bt5.text = "5";
            Lk2.SetActive(false);
            Lk3.SetActive(false);
            Lk4.SetActive(false);
            Lk5.SetActive(false);
            Lk6.SetActive(true);
            Lk7.SetActive(true);
            Lk8.SetActive(true);
            Lk9.SetActive(true);
        }

        if (LevelMem == 6)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = true;
            button4.GetComponent<Button>().enabled = true;
            button5.GetComponent<Button>().enabled = true;
            button6.GetComponent<Button>().enabled = true;
            bt2.text = "2";
            bt3.text = "3";
            bt4.text = "4";
            bt5.text = "5";
            bt6.text = "6";
            Lk2.SetActive(false);
            Lk3.SetActive(false);
            Lk4.SetActive(false);
            Lk5.SetActive(false);
            Lk6.SetActive(false);
            Lk7.SetActive(true);
            Lk8.SetActive(true);
            Lk9.SetActive(true);
        }
        if (LevelMem == 7)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = true;
            button4.GetComponent<Button>().enabled = true;
            button5.GetComponent<Button>().enabled = true;
            button6.GetComponent<Button>().enabled = true;
            button7.GetComponent<Button>().enabled = true;
            
            bt2.text = "2";
            bt3.text = "3";
            bt4.text = "4";
            bt5.text = "5";
            bt6.text = "6";
            bt7.text = "7";
            Lk2.SetActive(false);
            Lk3.SetActive(false);
            Lk4.SetActive(false);
            Lk5.SetActive(false);
            Lk6.SetActive(false);
            Lk7.SetActive(false);
            Lk8.SetActive(true);
            Lk9.SetActive(true);

        }
        if (LevelMem == 8)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = true;
            button4.GetComponent<Button>().enabled = true;
            button5.GetComponent<Button>().enabled = true;
            button6.GetComponent<Button>().enabled = true;
            button7.GetComponent<Button>().enabled = true;
            button8.GetComponent<Button>().enabled = true;
            
            bt2.text = "2";
            bt3.text = "3";
            bt4.text = "4";
            bt5.text = "5";
            bt6.text = "6";
            bt7.text = "7";
            bt8.text = "8";
            Lk2.SetActive(false);
            Lk3.SetActive(false);
            Lk4.SetActive(false);
            Lk5.SetActive(false);
            Lk6.SetActive(false);
            Lk7.SetActive(false);
            Lk8.SetActive(false);
            
        }
        if (LevelMem == 9)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = true;
            button4.GetComponent<Button>().enabled = true;
            button5.GetComponent<Button>().enabled = true;
            button6.GetComponent<Button>().enabled = true;
            button7.GetComponent<Button>().enabled = true;
            button8.GetComponent<Button>().enabled = true;
            button9.GetComponent<Button>().enabled = true;
           
            bt2.text = "2";
            bt3.text = "3";
            bt4.text = "4";
            bt5.text = "5";
            bt6.text = "6";
            bt7.text = "7";
            bt8.text = "8";
            bt9.text = "9";

            Lk2.SetActive(false);
            Lk3.SetActive(false);
            Lk4.SetActive(false);
            Lk5.SetActive(false);
            Lk6.SetActive(false);
            Lk7.SetActive(false);
            Lk8.SetActive(false);
            Lk9.SetActive(false);
            
        }
        if (LevelMem == 10)
        {
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
            button3.GetComponent<Button>().enabled = true;
            button4.GetComponent<Button>().enabled = true;
            button5.GetComponent<Button>().enabled = true;
            button6.GetComponent<Button>().enabled = true;
            button7.GetComponent<Button>().enabled = true;
            button8.GetComponent<Button>().enabled = true;
            button9.GetComponent<Button>().enabled = true;
            button10.GetComponent<Button>().enabled = true;
            bt2.text = "2";
            bt3.text = "3";
            bt4.text = "4";
            bt5.text = "5";
            bt6.text = "6";
            bt7.text = "7";
            bt8.text = "8";
            bt9.text = "9";
            bt10.text = "10";
            Lk2.SetActive(false);
            Lk3.SetActive(false);
            Lk4.SetActive(false);
            Lk5.SetActive(false);
            Lk6.SetActive(false);
            Lk7.SetActive(false);
            Lk8.SetActive(false);
            Lk9.SetActive(false);
            Lk10.SetActive(false);
        }

    }
    public void map1()
    {
        Application.LoadLevel("Map001");

    }
    public void map2()
    {
        Application.LoadLevel("Map002");

    }
    public void map3()
    {
        Application.LoadLevel("Map003");

    }
    public void map4()
    {
        Application.LoadLevel("Map004");

    }
    public void map5()
    {
        Application.LoadLevel("Map005");

    }
    public void map6()
    {
        Application.LoadLevel("Map006");

    }
    public void map7()
    {
        Application.LoadLevel("Map007");

    }
    public void map8()
    {
        Application.LoadLevel("Map008");

    }
    public void map9()
    {
        Application.LoadLevel("Map009");

    }
    public void map10()
    {
        Application.LoadLevel("Map010");

    }
    public void Reset()
    {
        PlayerPrefs.SetInt("LevelMem",0);
    }
    public void Sound()
    {
        
        if (audio.mute == true )
        {

            audio.mute = false;
            PlayerPrefs.SetInt("SoundMem", 1);
        }
        else 
        {

            audio.mute = true;
            PlayerPrefs.SetInt("SoundMem", 0);
        }
    }
    public void comeback()
    {
        Application.LoadLevel("Start");
    }
}
