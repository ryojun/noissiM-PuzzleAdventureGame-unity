using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiCode : MonoBehaviour
{
    public GameObject Ui1, Ui2;
    public GameObject  Scene2, Scene3, Scene4;
    // Use this for initialization
    void Start()
    {
        Ui1.SetActive(true);
        Ui2.SetActive(false);
        Scene2.SetActive(false);
        Scene3.SetActive(false);
        Scene4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Stay") == 2)
        {

            Scene2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Stay") == 3)
        {
            Scene2.SetActive(true);
            Scene3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Stay") == 4)
        {
            Scene2.SetActive(true);
            Scene3.SetActive(true);
            Scene4.SetActive(true);
        }
    }
    public void StartButton()
    {
        Ui1.SetActive(false);
        Ui2.SetActive(true);

    }
    public void GoScene1()
    {
        Application.LoadLevel(1);
    }
    public void GoScene2()
    {
        Application.LoadLevel(2);
    }
    public void GoScene3()
    {
        Application.LoadLevel(3);
    }
    public void GoScene4()
    {
        Application.LoadLevel(4);
    }
}
