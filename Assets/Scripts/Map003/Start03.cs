using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start03 : MonoBehaviour {
    private int numBlink;
    public GameObject Body;
    public GameObject BodyArt;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Body.transform.position.y < -100)
        {
            PlayerPrefs.SetInt("Life", PlayerPrefs.GetInt("Life") - 1);
            StartPoint();

        }

        if (Body.transform.position.y >= -6 && Body.transform.position.y <=2 && Body.transform.position.x > 218 && Body.transform.position.x <= 220)
        {
            Application.LoadLevel("Map003");


        }
        if (Body.transform.position.y <= -6 && Body.transform.position.y >= -12 && Body.transform.position.x >= 226.16 && Body.transform.position.x <= 227)
        {
            StartPoint();

        }
        if (Body.transform.position.y <= -27 && Body.transform.position.x > 116 && Body.transform.position.x < 180)
        {
            StartPoint();


        }
        if (Body.transform.position.y >= -15 && Body.transform.position.y <=-9 && Body.transform.position.x > 339 && Body.transform.position.x < 343)
        {
            Body.transform.position = new Vector3(314, 5, -2);

        }
        if (Body.transform.position.y >= -1 && Body.transform.position.y <= 2 && Body.transform.position.x >= 323 && Body.transform.position.x <= 330)
        {
            Body.transform.position = new Vector3(287, 35, -2);

        }
        if (Body.transform.position.y >= -1 && Body.transform.position.y <= 0 && Body.transform.position.x >= 167 && Body.transform.position.x <= 171)
        {
            StartPoint();

        }
        if (Body.transform.position.y <= 24 && Body.transform.position.x >= 600 && Body.transform.position.x <= 613)
        {
            StartPoint();

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
