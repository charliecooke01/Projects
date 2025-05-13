using UnityEngine;
using System.Collections;

public class BouncyCoin : MonoBehaviour {

    private Animator anim;
	private Rigidbody2D coinBody2D;
	
    public double negSpeed = 0;
	
	//Speed Timer
	public float speedTimer = 0.0f;

    //turn Timer
    public float turnTimer = 0.0f;


    //Called at game start
    void Start()
    {
        //Gather information from game
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("Dead", false);
        this.coinBody2D = GetComponent<Rigidbody2D>();

        //Initial speed
        this.coinBody2D.AddForce(new Vector2((Random.Range(5, 15)), (Random.Range(5, 20))));
		
    }

    // Update is called once per frame
    void Update()
    {

        //Sets Coin speed

        this.turnTimer += (Time.deltaTime);

        //turn coins towards player
        if (this.turnTimer > 0.5)
        {

            this.speedTimer += (Time.deltaTime * 7);
            this.negSpeed =-this.speedTimer;

            if (this.negSpeed < GameObject.Find("Main Camera").GetComponent<SpeedScript>().playerSpeed)
            {
                //negSpeed = GameObject.Find("Main Camera").GetComponent<SpeedScript>().playerSpeed;			
            }

            this.coinBody2D.velocity = new Vector2((float)this.negSpeed, this.coinBody2D.velocity.y);
        }
		
		if (this.turnTimer > 2.5)
        {
			Destroy(gameObject);
		}
		
    }
	
	
    //On player Collision
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Destroy Coin and increase score
            this.anim.SetBool("Dead", true);
			return;
        }
    }

}