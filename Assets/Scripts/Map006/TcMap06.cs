using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TcMap06 : MonoBehaviour
{
    InputField input;
    InputField.SubmitEvent se;
    public GameObject Body;
    public GameObject BodyArt;
    public GameObject Monster;
    public GameObject ATK1;
    public Text LifeTxt1;
    public int LifeE;
    int MS =10;
    public float cc = 100;
    int Timeint;
    public Text TimeText;
    public string[] Word;
    

    // Use this for initialization
    void Start()
    {

        
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
        Word = new string[15];
        Word[0] = "ready";
        Word[1] = "way";
        Word[2] = "next";
        Word[3] = "destroy";
        Word[4] = "bridge";
        Word[5] = "water";
        Word[6] = "word";
        Word[7] = "again";
        Word[8] = "run";
        Word[9] = "sun";
        Word[10] = "world";
        Word[11] = "true";
        Word[12] = "false";
        Word[13] = "final";
        Word[14] = "effort";
        Word[15] = "harder";
        



    }
    void Update()
    {

        LifeTxt1.text = LifeE.ToString();
        TimeCu();
        ATK1.GetComponent<Renderer>().enabled = false;

        if (LifeE < 1)
        {
            Application.LoadLevel("Winner");
        }
        if (cc < 1)
        {
            Application.LoadLevel("Lose");
        }

    }


    private void SubmitInput(string arg0)
    {
        
        arg0 = arg0.ToLower();
        

        if (arg0 == Word[0])
        {

            Killer();
            Word[0] = "Ryo";
           
            
        }
        if (arg0 == Word[1])
        {

            Killer();
            Word[1] = "Ryo";

        }
        if (arg0 == Word[2])
        {

            Killer();
            Word[2] = "Ryo";

        }

        if (arg0 == Word[3])
        {

            Killer();
            Word[3] = "Ryo";

        }
        if (arg0 == Word[4])
        {

            Killer();
            Word[4] = "Ryo";

        }
        if (arg0 == Word[5])
        {

            Killer();
            Word[5] = "Ryo";

        }
        if (arg0 == Word[6])
        {

            Killer();
            Word[6] = "Ryo";

        }
        if (arg0 == Word[7])
        {
            Killer();
            Word[7] = "Ryo";
        }
        if (arg0 == Word[8])
        {
            Killer();
            Word[8] = "Ryo";
        }
        if (arg0 == Word[9])
        {
            Killer();
            Word[9] = "Ryo";
        }
        if (arg0 == Word[10])
        {
            Killer();
            Word[10] = "Ryo";
        }
        if (arg0 == Word[11])
        {
            Killer();
            Word[11] = "Ryo";
        }
        if (arg0 == Word[12])
        {
            Killer();
            Word[12] = "Ryo";
        }
        if (arg0 == Word[13])
        {
            Killer();
            Word[13] = "Ryo";

        }
        if (arg0 == Word[14])
        {
            Killer();
            Word[14] = "Ryo";
        }
        if (arg0 == Word[15])
        {
            Killer();
            Word[15] = "Ryo";
        }

    }

    void TimeCu()
    {
        Timeint = ((int)cc);
        TimeText.text = Timeint.ToString();
        cc -= Time.deltaTime;
        

    }
    void Killer()
    {

        LifeE--;

        MS -= 2;
        Monster.transform.localScale = new Vector3(MS, MS);
        StartCoroutine(Attack(0.1f));
        StartCoroutine(DoBlinks(0.2f));
        
    }
    IEnumerator Attack(float seconds)
    {
        ATK1.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(1);
        ATK1.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        ATK1.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(seconds);
        ATK1.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        ATK1.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(seconds);
        ATK1.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        ATK1.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(seconds);
        ATK1.GetComponent<Renderer>().enabled = false;

    }

    IEnumerator DoBlinks(float seconds)
    {
        Monster.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(1);
        Monster.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        Monster.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(seconds);
        Monster.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        Monster.GetComponent<Renderer>().enabled = true;

    }
   
}