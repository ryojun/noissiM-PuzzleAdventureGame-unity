using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start7 : MonoBehaviour {
    private int numBlink;
    public GameObject Body;
    public GameObject BodyArt;
    public GameObject monster;
    public GameObject Bom;
    float timecount = 0;
    float freq = 1;



    void Start()
    {
    }

    void Update () {
        
        if (Body.transform.position.y < -100)
        {
            Application.LoadLevel("Map007");
            
        }

        timecount += Time.deltaTime;
        if (timecount >= freq)
        {
            timecount = 0;
            Instantiate(monster, new Vector3(28,-5, 0), Quaternion.identity);
            Instantiate(monster, new Vector3(Random.Range(-18, -16), 22, 0), Quaternion.identity);
            Instantiate(Bom, new Vector3(Random.Range(-20, 224), 171, 0), Quaternion.identity);
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
