using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public bool isFire = false;
    public string collisionTag = "Fire";

    //Sets enemy body
    Animator anim;

    //Called at game start
    void Start() {
        //Gather information from game
        this.anim = GetComponent<Animator>();
        this.anim.SetBool("Dead", false);
    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player")
        {
            if (Character.getCharacter().fire == this.isFire || Character.getCharacter().rock)
            {
                //Destroy 
                this.kill();
            }
            if (Character.getCharacter().fire == this.isFire)
            {
                Character.getCharacter().rockCounter++;
            }
            
        }
        else if (collision.tag == this.collisionTag)
        {
            this.kill();
        }

    }

    private void kill()
    {
        this.anim.SetBool("Dead", true);
        StartCoroutine(KillOnAnimationEnd());
    }

    private IEnumerator KillOnAnimationEnd() {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
