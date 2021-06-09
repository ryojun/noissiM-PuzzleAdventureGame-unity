using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start4 : MonoBehaviour {
    private int numBlink;
    public GameObject Body;
    public GameObject BodyArt;
    public Text TimeText;
    int Timeint;
    public float cc = 100;

    void Start()
    {
    }

    void Update () {
        GameObject Box1 = GameObject.Find("fire01");

        //-----Time-----------------------------
        if ((int)cc == 0)
        {
            StartPoint();

        }
        else
        {
            Timeint = ((int)cc);
            TimeText.text = Timeint.ToString();
            cc -= Time.deltaTime;
        }

        //----Time--------------------------------

        if (Body.transform.position.y < -100)
        {
            Application.LoadLevel("Map004");
            
        }
        if (Body.transform.position.x > 14 && Body.transform.position.x < 15 && Box1.GetComponent<Renderer>().enabled == true)
        {
            Application.LoadLevel("Map004");
            
        }
        if (Body.transform.position.x >=140 && Body.transform.position.x <= 192 && Body.transform.position.y <= -10  )
        {
            Application.LoadLevel("Map004");
            
        }
        if (Body.transform.position.x >= 200 && Body.transform.position.x <= 204 && Body.transform.position.y >= -2 && Body.transform.position.y <=0)
        {
            Application.LoadLevel("Map004");
            
        }
        if (Body.transform.position.x >= 250 && Body.transform.position.x <= 266 && Body.transform.position.y <= -10)
        {
            Application.LoadLevel("Map004");

        }
    }

    void StartPoint()
    {

        Body.transform.position = new Vector3(-14, -2, -2);
        StartCoroutine(DoBlinks(0.2f));
        cc = 100;
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
