using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class PlayerControl : MonoBehaviour {
    
    private int numBlink;
    public LayerMask playerMask;
    public float speed = 10;
    public float jumpverocity =30;
    public float jumpfic =30;
    public bool canMoveInAir = true;
    Transform mytrans,tagGround;
    private Rigidbody2D rb2d;
    public bool isground = false;
    AnimetorController myanim;
    float hInput = 0;
    public GameObject BodyArt;
    public GameObject Body;

    public GameObject Leftbt, rightbt, upbt, Player;
    public GameObject LastGame,GameOver, CompleteText;
    public GameObject HomeBt, AgianBt, NextBt;

    public AudioSource JumpSound;
    public AudioSource CompleteMap;
    public AudioSource BadSound;
    void Start () {

    rb2d = gameObject.GetComponent<Rigidbody2D>();
        mytrans = this.transform;
        tagGround = GameObject.Find(this.name + "/tag_ground").transform;
        myanim = AnimetorController.instance;

        LastGame.SetActive(false);
        GameOver.SetActive(false);
        CompleteText.SetActive(false);
        HomeBt.SetActive(false);
        AgianBt.SetActive(false);
        NextBt.SetActive(false);
    }
    void Update()
    {
        
        
    }
    void FixedUpdate () {

        isground = Physics2D.Linecast(mytrans.position,tagGround.position, playerMask);
        myanim.UpdateIsGround(isground);

#if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BLACKBERRY && !UNITY_WINRT || UNITY_EDITOR
         hInput = Input.GetAxisRaw("Horizontal");
        myanim.UpdateSpeed(hInput);
        if (Input.GetButtonDown("Jump"))
        {
            jump();

        }
#endif
        Move(hInput);

    }

    void Move(float horizonalInput)
    {
        if (!canMoveInAir && !isground)
            return;

        Vector2 movevel = rb2d.velocity;
        movevel.x = horizonalInput * speed;
        rb2d.velocity = movevel;
    }
    public void jump()
    {
        if (isground)
        {
            rb2d.velocity += jumpverocity * Vector2.up;
            //if (PlayerPrefs.GetInt("SoundMem") ==1) {
               JumpSound.Play();
            //}
        }
    }
    public void StartMoving(float horizonalInput)
    {

        hInput = horizonalInput;
        myanim.UpdateSpeed(horizonalInput);
    }

    private void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.gameObject.tag == "Bad")
        {
            LastGame.SetActive(true);
            GameOver.SetActive(true);
            Leftbt.SetActive(false);
            rightbt.SetActive(false);
            upbt.SetActive(false);
            Player.SetActive(false);
            HomeBt.SetActive(true);
            AgianBt.SetActive(true);
            BadSound.Play();
            Handheld.Vibrate();
        }
        if (Coll.gameObject.tag == "gate1")
        {
            CompleteText.SetActive(true);
            LastGame.SetActive(true);
            Leftbt.SetActive(false);
            rightbt.SetActive(false);
            upbt.SetActive(false);
            Player.SetActive(false);
            HomeBt.SetActive(true);
            AgianBt.SetActive(true);
            NextBt.SetActive(true);
            CompleteMap.Play();
        }
        if (Coll.gameObject.tag == "gate2")
        {
            CompleteText.SetActive(true);
            LastGame.SetActive(true);
            Leftbt.SetActive(false);
            rightbt.SetActive(false);
            upbt.SetActive(false);
            Player.SetActive(false);
            HomeBt.SetActive(true);
            AgianBt.SetActive(true);
            NextBt.SetActive(true);
            CompleteMap.Play();
        }
        if (Coll.gameObject.tag == "gate3")
        {
            CompleteText.SetActive(true);
            LastGame.SetActive(true);
            Leftbt.SetActive(false);
            rightbt.SetActive(false);
            upbt.SetActive(false);
            Player.SetActive(false);
            HomeBt.SetActive(true);
            AgianBt.SetActive(true);
            NextBt.SetActive(true);
            CompleteMap.Play();
        }
        if (Coll.gameObject.tag == "gate4")
        {
            CompleteText.SetActive(true);
            LastGame.SetActive(true);
            Leftbt.SetActive(false);
            rightbt.SetActive(false);
            upbt.SetActive(false);
            Player.SetActive(false);
            HomeBt.SetActive(true);
            AgianBt.SetActive(true);
            NextBt.SetActive(true);
            CompleteMap.Play();
        }
    }
    
    
    IEnumerator DoBlinks(float seconds)
    {
        BodyArt.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        BodyArt.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(seconds);
        BodyArt.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(seconds);
        BodyArt.GetComponent<Renderer>().enabled = true;

    }
}
