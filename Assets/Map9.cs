using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map9 : MonoBehaviour {
    
    public GameObject monster;
    public Transform target;
    Rigidbody2D body;

    float timecount = 0;
    float freq = 1;

    public float speed;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update () {
        timecount += Time.deltaTime;

        if (timecount >= freq)
        {
            timecount = 0;
            Instantiate (monster,new Vector3(-15,Random.Range(-5,6),0),Quaternion.identity);
            
        }

        Vector2 targetposition = target.position; //เก็บค่าตำแหน่งผู้เล่น
        Vector2 botposition = transform.position; //เก็บค่าตำแหน่งบอท
        
        Vector2 direction = targetposition - botposition; //ทิศทาง
                                                          //direction.z = 0; //กันบอทกระะโดด
        body.velocity = direction.normalized * speed; //ปรับให้ความเร็วบอททุกตัวเท่ากัน เพิ่มเติม MemoTuto Red
        
    }
}
