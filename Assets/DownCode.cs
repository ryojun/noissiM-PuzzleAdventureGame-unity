using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCode : MonoBehaviour {
    public GameObject MainObj;
    void Start()
    {
        
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("Ready") == 1)
        {
            gameObject.SetActive(false);
        }
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MainObj.transform.position = new Vector3(MainObj.transform.position.x , MainObj.transform.position.y -2, MainObj.transform.position.z);
        }
    }
}
