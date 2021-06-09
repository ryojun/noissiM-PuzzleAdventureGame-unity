using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCode : MonoBehaviour {
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
            MainObj.transform.position = new Vector3(MainObj.transform.position.x - 2, MainObj.transform.position.y, MainObj.transform.position.z);
        }
    }
}
