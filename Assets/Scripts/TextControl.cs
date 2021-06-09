using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    InputField input;
    InputField.SubmitEvent se;
    public GameObject Body;
    public GameObject BodyArt;

    void Start()
    {
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;


    }
     void Update()
    {
        if (Body.transform.position.y < -100)
        {
            StartPoint();
        }
    }
    private void SubmitInput(string arg0)
    {


        arg0 = arg0.ToLower();

        if (arg0 == "ready")

        {
            Application.LoadLevel("Map002");
            PlayerPrefs.SetInt("LevelMem", 2);
        }

        

        if (arg0 == "again")
        {
            Body.transform.position = new Vector3(Body.transform.position.x-10, Body.transform.position.y+10, -2);


        }
    }
    void StartPoint()
    {

        Body.transform.position = new Vector3(-14, -2, -2);
        StartCoroutine(DoBlinks(0.2f));

    }
    IEnumerator DoBlinks(float seconds)
    {
        BodyArt.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        BodyArt.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(seconds);
        BodyArt.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        BodyArt.GetComponent<Renderer>().enabled = true;

    }

}
