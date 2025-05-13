using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

    private Animator anim;

    //Called at game start
    void Start()
    {
        //Gather information from game
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("Dead", false);
    }


    //On player Collision
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Destroy Coin and increase score
            this.anim.SetBool("Dead", true);
            Character.getCharacter().coinScore = (Character.getCharacter().coinScore + 1);
        }
    }

}
