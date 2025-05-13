using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public bool any = true;
    public bool fire = false;
    public bool bouncy = false;
    public double negSpeed = 0;
    public float speedTimer = 0.0f;
    public float turnTimer = 0.0f;
    public AudioClip coinSound;

    private Animator anim;
    private Rigidbody2D coinBody2D;
    private AudioSource source;

    // Update is called once per frame
    void Update()
    {
        if (this.bouncy)
        {
            //Sets Coin speed
            this.turnTimer += (Time.deltaTime);

            //turn coins towards player
            //if (this.turnTimer > 0.5)
            //{

            this.speedTimer += (Time.deltaTime * 6);
            this.negSpeed = -this.speedTimer;

            if (this.negSpeed > GameObject.Find("Main Camera").GetComponent<SpeedScript>().playerSpeed)
            {
                negSpeed = 0 - GameObject.Find("Main Camera").GetComponent<SpeedScript>().playerSpeed;
            }

            this.coinBody2D.velocity = new Vector2((float)this.negSpeed, this.coinBody2D.velocity.y);
            //}

            if (this.turnTimer > 4.5)
            {
                Destroy(gameObject);
            }

        }
    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    //Called at game start
    void Start()
    {
        //Gather information from game
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("Dead", false);


        if (this.bouncy)
        {
            this.coinBody2D = GetComponent<Rigidbody2D>();
            //Initial speed
            this.coinBody2D.AddForce(new Vector2((Random.Range(5, 15)), (Random.Range(5, 20))));
        }
    }

    //On player Collision
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && 
			(Character.getCharacter().rock || Character.getCharacter().fire == this.fire || this.bouncy || this.any))
        {
            
            this.destroy();
        }
    }

    private void destroy()
    {
        //Destroy Coin and increase score 
        source.PlayOneShot(coinSound);
        this.anim.SetBool("Dead", true);
        Character.getCharacter().coinScore = (Character.getCharacter().coinScore + 1);
    }
}
