using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greendesto : MonoBehaviour {
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
            Destroy(gameObject);
        }
    }

}