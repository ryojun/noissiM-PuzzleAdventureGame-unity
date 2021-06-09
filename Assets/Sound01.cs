using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound01 : MonoBehaviour {
    public AudioSource Sound;
    void OnMouseDown()
    {
        Sound.Play();
    }
    }
