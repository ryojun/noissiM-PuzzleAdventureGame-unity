using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TcMap04 : MonoBehaviour
{
    InputField input;
    InputField.SubmitEvent se;


    // Use this for initialization
    void Start()
    {


        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;

    }

    private void SubmitInput(string arg0)
    {
        GameObject MyMy = GameObject.Find("Player");
        arg0 = arg0.ToLower();

        GameObject Box1 = GameObject.Find("fire01");
        GameObject Box2 = GameObject.Find("Box2");
        GameObject Boxrun = GameObject.Find("Boxrun");
        GameObject Boxsun = GameObject.Find("Boxsun");

        if (arg0 == "agian")
        {
            Application.LoadLevel("Map004");
        }

        if (arg0 == "water"|| arg0 =="destroy")
        {
            
                Box1.GetComponent<Renderer>().enabled = false;
                Box1.GetComponent<Collider2D>().enabled = false;
        }
        if (arg0 == "destroy")
        {
            if (MyMy.transform.position.x > 17 && MyMy.transform.position.x < 53)
            {
                Box2.GetComponent<Renderer>().enabled = false;
                Box2.GetComponent<Collider2D>().enabled = false;
            }
        }
        if (arg0 == "run")
            {
                
                    Boxrun.GetComponent<Renderer>().enabled = false;
                    Boxrun.GetComponent<Collider2D>().enabled = false;
                

            }
        if (arg0 == "sun")
        {

            Boxsun.GetComponent<Renderer>().enabled = false;
            Boxsun.GetComponent<Collider2D>().enabled = false;


        }

         if (arg0 == "harder")
        {
         Application.LoadLevel("Map005");
        PlayerPrefs.SetInt("LevelMem", 5);
         }
    }
}