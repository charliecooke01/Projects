using UnityEngine;
using System.Collections;

public class FireEnemy : MonoBehaviour {

    public bool flame = true;

    //Sets enemy body
    Rigidbody2D enemybody2D;
    Animator anim;
    public GameObject damage;

    //Coin
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;

    //Coin spawn point
    public GameObject SpawnPoint;

    //Called at game start
    void Start()
    {
        //Gather information from game
        anim = GetComponent<Animator>();
        anim.SetBool("Dead", false);
        //enemybody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().fire) //will check if true
        {
            flame = true;
        }
        else
        {
            flame = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {


        if ((other.tag == "Player"))
        {
            //Destroy flame
            if (flame == true)
            {
                anim.SetBool("Dead", true);
                Instantiate(Spawn1, (SpawnPoint.transform.position), Quaternion.Euler(0, 0, 0));
                Instantiate(Spawn2, (SpawnPoint.transform.position), Quaternion.Euler(0, 0, 0));
                Instantiate(Spawn3, (SpawnPoint.transform.position), Quaternion.Euler(0, 0, 0));
                GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().rockCounter = (GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().rockCounter + 1);
                //Destroy(gameObject);
            }
        }

        if (other.tag == "Water")
        {
            anim.SetBool("Dead", true);
            Destroy(damage);
        }
    }
}
