using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour
{

    //player speed
    public float maxSpeed = 7;
    public float speed = 7;

    //check for pause
    public bool paused = false;

    //Player health
    public float health = 4;

    //Player Score
    public float coinScore = 0;
    public float rockTimer = 10;
    public float rockCounter = 0;

    //Damage counter
    public float damageCount = 2;
    public float hitCount = 2;

    //for animation
    public Animator anim;
    private bool grounded = false;
    public bool fire = true;
    public bool jumped = false;
    public bool rock = false;
    public bool rockIn = false;

    //check for ground
    public Transform groundCheck;
    private float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    //jump measurments
    public float jumpForce = 100f;
    public float extraJumpForce = 100f;
    public float jumpTimer = 0.0f;
    public float newJumpForce = 0;

    //Sets player body
    private Rigidbody2D myRigidbody2D;

    //Bullet Objects
    public GameObject fireBullet;
    public GameObject waterBullet;
    public GameObject rockBullet;
    public bool bullet = false;

    //Sound Effects
    public AudioClip jumpSound;
    private AudioSource jumpSource;
    public AudioClip switchSound;
    private AudioSource switchSource;
    public AudioClip rockSound;
    private AudioSource rockSource;

    //Called at game start
    void Start()
    {

        //Gather information from game
        this.anim = GetComponent<Animator>();
        this.myRigidbody2D = GetComponent<Rigidbody2D>();
        this.health = 4;
        this.rockCounter = 0;
        this.coinScore = 0;
        this.rock = false;
        this.rockTimer = 13;
        paused = false;
        Time.timeScale = 1.0f;

        //get sound effects
        jumpSource = GetComponent<AudioSource>();
        switchSource = GetComponent<AudioSource>();
        rockSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Checks for ground
        this.grounded = Physics2D.OverlapCircle(this.groundCheck.position, this.groundRadius, this.whatIsGround);
        this.anim.SetBool("Ground", this.grounded);

        //Determines vertical speed
        this.anim.SetFloat("vSpeed", this.myRigidbody2D.velocity.y);

        //Sets Player speed
        this.myRigidbody2D.velocity = new Vector2(0, this.myRigidbody2D.velocity.y);

        //Sets what to do when grounded
        if (this.grounded)
        {
            this.jumpTimer = 0;
            this.jumped = false;
            this.anim.SetBool("Jumped", false);
        }

        //Measures length of jump
        if (!this.grounded)
        {
            this.jumpTimer += (Time.deltaTime * 30);

        }

        //Creates new jumpforce from timer
        this.newJumpForce = this.extraJumpForce + this.jumpTimer;

        //Extra jump force
        if (this.newJumpForce < 37.5 && !this.jumped)
        {
            this.myRigidbody2D.AddForce(new Vector2(0, (this.newJumpForce)));
        }

    }

    //check for pause
    public void pauseButton()
    {
        if (paused == false)
        {
            paused = true;
        }
        else if (paused == true)
        {
            paused = false;
        }
    }

    public void JumpDown()
    {
        //if not paused
        if (paused == false)
        {
            //Normal jump
            if (this.grounded)
            {
                this.anim.SetBool("Ground", false);
                this.myRigidbody2D.AddForce(new Vector2(0, this.jumpForce));
                jumpSource.PlayOneShot(jumpSound);
            }
        }


    }

    public void JumpUp()
    { 
        //Check for Jump end
        if (!this.grounded)
        {
            this.jumped = true;
            this.anim.SetBool("Jumped", true);
        }


    }

    public void elementSwitch()
    {
        // if not paused
        if (paused == false)
        {
            //Set fire
            if (this.fire == false)
            {
                if (this.rock == false)
                {
                    switchSource.PlayOneShot(switchSound);
                    this.anim.SetBool("Flame", true);
                    this.fire = true;
                }
            }

            //Set Water
            else if (this.fire == true)
            {
                if (this.rock == false)
                {
                    switchSource.PlayOneShot(switchSound);
                    this.anim.SetBool("Flame", false);
                    this.fire = false;
                }
            }
        }
    }

    public void rockPower()
    {
        //if not paused
        if (paused == false)
        {
            //after 4 enemy kills
            if (this.rockCounter > 3 && !this.rock)
            {
                rockSource.PlayOneShot(rockSound);
                this.rock = true;
                this.rockIn = true;
                this.rockTimer = 0;
                this.rockCounter = 0;
            }
        }
    }

    public void rocksound()
    {
        //if not paused
        if (paused == false)
        {
            rockSource.PlayOneShot(rockSound);
        }
    }

    public void shoot()
    {
        //if (bullet == false)
        //{

            if (this.rock)
            {
                Instantiate(this.rockBullet, (new Vector2(this.transform.position.x, ((float)this.transform.position.y - 0.15f))), Quaternion.Euler(0, 0, 0));
            }

            else
            {

                if (this.fire)
                {
                    Instantiate(this.fireBullet, (new Vector2(this.transform.position.x, ((float)this.transform.position.y - 0.15f))), Quaternion.Euler(0, 0, 0));
                }

                else
                {
                    Instantiate(this.waterBullet, (new Vector2(this.transform.position.x, ((float)this.transform.position.y - 0.15f))), Quaternion.Euler(0, 0, 0));
                }
            }
            //bullet = true;
        //}
    }
    

    // Update is called once per frame
    void Update()
    {

        //Damage counter
        this.damageCount += (Time.deltaTime);

        if (this.damageCount >= 2)
        {
            this.damageCount = 2;
        }
        else if (this.damageCount < 1)
        {
            this.anim.SetBool("Damage", true);
        }
        else
        {
            this.anim.SetBool("Damage", false);
        }

        //Hit
        this.hitCount += (Time.deltaTime * 5);

        if (this.hitCount >= 2)
        {
            this.hitCount = 2;
        }
        else if (this.hitCount < 1)
        {
            this.anim.SetBool("Hit", true);
        }
        else
        {
            this.anim.SetBool("Hit", false);
        }


        //Rock Powerup
        this.rockTimer += (Time.deltaTime);

        //if ((rockCounter > 7) && (!rock))
        //{
        //    rock = true;
        //    rockTimer = 0;
        //    rockCounter = 0;
        //}

        if (this.rock)
        {
            this.rockCounter = 0;
            this.anim.SetBool("Rock", true);
        }

        if (this.rockIn)
        {
            this.anim.SetBool("RockIn", true);
        }
        else
        {
            this.anim.SetBool("RockIn", false);
        }

        if (this.rockTimer >= 12)
        {
            this.rockTimer = 12;
            this.rock = false;
            this.anim.SetBool("Rock", false);
        }

        else if (this.rockTimer < 12)
        {
            this.damageCount = 0;
        }

        if (this.rockTimer <= 0.7)
        {
            this.rockIn = true;
        }

        if (this.rockTimer > 0.7)
        {
            this.rockIn = false;
        }


        
    }

}