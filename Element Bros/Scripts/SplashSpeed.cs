using UnityEngine;
using System.Collections;

public class SplashSpeed : MonoBehaviour {


    public double negSpeed = 0;

    private Rigidbody2D splashBody2D;

    //Sound Effects
    public AudioClip splashSound;
    private AudioSource splashSource;

    //destroy counter
    public float splashTimer = 0;

    void Awake()
    {
        splashSource = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {

        //splashSource.PlayOneShot(splashSound);
        this.splashBody2D = GetComponent<Rigidbody2D>();
        

    }
	
	// Update is called once per frame
	void Update () {

        this.negSpeed = ((0 - GameObject.Find("Main Camera").GetComponent<SpeedScript>().playerSpeed));
        this.splashBody2D.velocity = new Vector2((float)this.negSpeed, this.splashBody2D.velocity.y);
        this.splashTimer += (Time.deltaTime);

        if (splashTimer >= 2)
        {
            Destroy (this.gameObject);
        }

    }
}
