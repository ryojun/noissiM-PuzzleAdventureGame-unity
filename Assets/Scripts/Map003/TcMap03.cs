using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TcMap03 : MonoBehaviour
{
    InputField input;
    InputField.SubmitEvent se;
    public GameObject Bridge;
    public GameObject BridgeTxt;

    // Use this for initialization
    void Start()
    {


        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
        BridgeTxt.GetComponent<Renderer>().enabled = false;
        Bridge.GetComponent<Collider2D>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SubmitInput(string arg0)
    {
        GameObject MyMy = GameObject.Find("Player");
        GameObject Box1 = GameObject.Find("Box1");
        GameObject Box2 = GameObject.Find("Box2");
        arg0 = arg0.ToLower();


        if (arg0 == "agian")
        {
            Application.LoadLevel("Map003");

        }
        if (arg0 == "destroy")
        {
            if (MyMy.transform.position.x > -18 && MyMy.transform.position.x < 13)
            {
                Box1.GetComponent<Renderer>().enabled = false;
                Box1.GetComponent<Collider2D>().enabled = false;
            }
        }
        if (arg0 == "destroy")
        {
            if (MyMy.transform.position.x > 17 && MyMy.transform.position.x < 53)
            {
                Box2.GetComponent<Renderer>().enabled = false;
                Box2.GetComponent<Collider2D>().enabled = false;
            }
        }

        if (arg0 == "hi")
        {
            MyMy.transform.position = new Vector2(MyMy.transform.position.x, 50);
        }
        if (arg0 == "bridge")
        {
            
                BridgeTxt.GetComponent<Renderer>().enabled = true;
                Bridge.GetComponent<Collider2D>().enabled = true;
            
        }
         if (arg0 == "effort")
        {
         Application.LoadLevel("Map004");
        PlayerPrefs.SetInt("LevelMem", 4);
         }
    }
}