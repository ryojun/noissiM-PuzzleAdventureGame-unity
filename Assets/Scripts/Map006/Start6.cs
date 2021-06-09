using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start6 : MonoBehaviour {
    private int numBlink;
    public GameObject Body;
    public GameObject BodyArt;
    public Text TimeText;
    int Timeint;
    public float cc = 10;
    public int LifeE = 100;
    void Start()
    {
    }

    void Update () {
        

        //-----Time-----------------------------


        //----Time--------------------------------

        if (Body.transform.position.y < -100)
        {
            Application.LoadLevel("Map005");
            
        }
   

        
        
       

      
       







    }
    void TimeCu()
    {
        Timeint = ((int)cc);
        TimeText.text = Timeint.ToString();
        cc -= Time.deltaTime;
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
    public void Clicker()
    {
        LifeE--;
    }

}
