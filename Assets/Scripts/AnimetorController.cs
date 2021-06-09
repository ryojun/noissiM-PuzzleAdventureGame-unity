using UnityEngine;
using System.Collections;

public class AnimetorController : MonoBehaviour {
    public static AnimetorController instance;
    Transform mytrans;
    Animator myanim;
    Vector3 artScaleCache;

	void Start () {
        mytrans = this.transform;
        myanim = this.gameObject.GetComponent<Animator>();
        instance = this;

        artScaleCache = mytrans.localScale;
	}
	void FlipArt (float currentSpeed)
    {
        if((currentSpeed < 0 && artScaleCache.x == 1)|| //going left AND faceing right OR...
            (currentSpeed > 0 && artScaleCache.x == -1))//going right AND faceing left 

            {
            //flip the art
            artScaleCache.x *= -1;
            mytrans.localScale = artScaleCache;

        }
    }
	public void UpdateSpeed (float currentSpeed) {
        myanim.SetFloat("speed", currentSpeed);
        FlipArt(currentSpeed);
	}
    public void UpdateIsGround(bool isground)
    {
        myanim.SetBool("isground", isground);
    }
}
