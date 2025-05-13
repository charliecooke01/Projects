using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    // public variables
    public bool fire = false;
    public int coins = 3;
    public GameObject coin;
    public GameObject spawnPoint;
    public bool strong = false;

    // private variables
    private Rigidbody2D enemybody2D;
    private double negSpeed = 0;
    private Animator anim;

    //Sound Effects
    public AudioClip deathSound;
    private AudioSource deathSource;

    void Awake()
    {
        deathSource = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {
        this.enemybody2D = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("Dead", false);
    }

    // Update is called once per frame
    void Update()
    {
        //Sets Player speed
        this.negSpeed = ((0 - GameObject.Find("Main Camera").GetComponent<SpeedScript>().playerSpeed) - 1);
        this.enemybody2D.velocity = new Vector2((float)this.negSpeed, this.enemybody2D.velocity.y);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {   
            if (Character.getCharacter().rock || 
                (Character.getCharacter().fire == this.fire && !this.strong))
            {
                deathSource.PlayOneShot(deathSound);
                this.kill();
                
                for (int i = 1; i <= this.coins; i++)
                {
                    Instantiate(this.coin, (this.spawnPoint.transform.position), Quaternion.Euler(0, 0, 0));
                }

                if (Character.getCharacter().fire == this.fire)
                {
                    Character.getCharacter().rockCounter++;
                }
            }
        }

        else if (other.tag == "Bullet")
        {
            this.kill();

            
            for (int i = 1; i <= this.coins; i++)
            {
                Instantiate(this.coin, (this.spawnPoint.transform.position), Quaternion.Euler(0, 0, 0));
            }

			this.anim.SetBool("Dead", true);
            //Destroy(gameObject);
			Destroy (other.gameObject);
            Character.getCharacter().bullet = false;
        }


        else if (other.tag == "Water" && this.fire)
        {
            this.kill();
        }

        else if (other.tag == "Fire" && !this.fire)
        {
            this.kill();
        }

    }

    private void kill()
    {
        this.anim.SetBool("Dead", true);
        StartCoroutine(KillOnAnimationEnd());

        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    private IEnumerator KillOnAnimationEnd()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
