using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TCMap2 : MonoBehaviour {

    InputField input;
    InputField.SubmitEvent se;

    public Text PointTxt;
    public GameObject Box1;
    public GameObject Box1TxT;


    void Start()
    {
        
        input = gameObject.GetComponent<InputField>();
        Box1TxT.GetComponent<Renderer>().enabled = false;
        Box1.GetComponent<Collider2D>().enabled = false;
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;

        
    }
    void Update()
    {
        
    }
    private void SubmitInput(string arg0)
    {
        GameObject MyMy = GameObject.Find("Player");
        arg0 = arg0.ToLower();


        if (arg0 == "agian")

        {
            Application.LoadLevel("Map002");

        }
        
       
        
        if (arg0 == "way")
        {
            Box1TxT.GetComponent<Renderer>().enabled = true;
            Box1.GetComponent<Collider2D>().enabled = true;
        }

        if (arg0 == "next")
        {
            Application.LoadLevel("Map003");
            PlayerPrefs.SetInt("LevelMem", 3);

        }

    }


}
