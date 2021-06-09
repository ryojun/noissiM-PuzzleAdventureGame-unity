using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posistart : MonoBehaviour {
    private int numBlink;
    public GameObject Body;
    public GameObject BodyArt;
    public GameObject Point1;
    public AudioSource audio;
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
       
        
        if (Body.transform.position.y < -100)
        {
            PlayerPrefs.SetInt("Life", PlayerPrefs.GetInt("Life") - 1);
            StartPoint();
            

        }
       

        }
    void StartPoint()
    {
        
        Body.transform.position = new Vector3(-14,-2 , -2);
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
