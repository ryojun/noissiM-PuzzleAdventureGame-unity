using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSC : MonoBehaviour {
    
    public GameObject Gun;
    public GameObject art;
    public GameObject bullet;
    public GameObject Brick;
    Vector3 startposition;
    public AudioSource CreatBlok, CreatPoint;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

    }

    public void Attack(){
        if (PlayerPrefs.GetInt("Point")>= 1){
            if (PlayerPrefs.GetInt("SoundMem") == 1)
            {
                CreatPoint.Play();
            }
            startposition = Gun.transform.position;
            Vector3 direction;
            PlayerPrefs.SetInt("Point", PlayerPrefs.GetInt("Point") - 1);
            if (art.transform.localScale.x == 1) {
                direction = transform.right;
            }
            else {
                direction = transform.right * -1;
            }

            float distance = 100;

            //Debug.DrawRay(startposition, direction, Color.blue, 0.2f);
            // RaycastHit2D hit = Physics2D.Raycast(startposition, direction, distance);
            Instantiate(bullet, startposition, Quaternion.identity);

            //if (hit.collider != null)
            // {
            //     if (hit.collider.gameObject.tag == "Bad")
            //     {

            //        Destroy(hit.collider.gameObject);
            //     }
            //   }
        }
    }
    public void BrickBrick()
    {
        if (PlayerPrefs.GetInt("Point") >= 5)
        {
            if (PlayerPrefs.GetInt("SoundMem") == 1)
            {
                CreatBlok.Play();
            }
            startposition = Gun.transform.position;
            Vector3 direction;
            PlayerPrefs.SetInt("Point", PlayerPrefs.GetInt("Point") - 5);
            if (art.transform.localScale.x == 1)
            {
                direction = transform.right;
            }
            else
            {
                direction = transform.right * -1;
            }

            float distance = 100;

            Instantiate(Brick, startposition, Quaternion.identity);
        }
    }
    }
