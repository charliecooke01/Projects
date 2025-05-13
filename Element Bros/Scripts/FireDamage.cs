using UnityEngine;
using System.Collections;

public class FireDamage : MonoBehaviour {

    public bool flame = true;
    public bool rock = true;

    void Update()
    {
        if (GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().fire) //will check if true
        {
            flame = false;
        }
        else
        {
            flame = true;
        }

        if (GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().rock) //will check if true
        {
            rock = true;
        }
        else
        {
            rock = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "Player") && (GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().damageCount >= 2))
        {
            if ((flame == true) && (rock == false))
            {
                GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().health = (GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().health - 1);
                GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().damageCount = 0;
                GameObject.Find("Character 1").GetComponent<CharacterControllerScript>().hitCount = 0;
                return;
            }
        }

    }
}
