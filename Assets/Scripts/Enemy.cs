using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public LayerMask enemyMask;
    public float speed;
    private Rigidbody2D myBody;
    Transform mytrans;
    float myWidth;
    void Start () {
        mytrans = this.transform;
        myBody = gameObject.GetComponent<Rigidbody2D>();
        myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;


    }
	
	void FixedUpdate () {
        Vector2 lineCastPos = mytrans.position = mytrans.right * myWidth;
        Debug.DrawLine(lineCastPos, lineCastPos + Vector2.down);
        bool isground = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);
        

        if (!isground)
        {
            Vector3 currRot = mytrans.eulerAngles;
            currRot.y += 180;
            mytrans.eulerAngles = currRot;
        }

        Vector2 myVel = myBody.velocity;
        myVel.x = -mytrans.right.x * speed;
        myBody.velocity = myVel;


	}
}
