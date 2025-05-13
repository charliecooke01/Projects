using UnityEngine;
using System.Collections;

public class CoinScorer : MonoBehaviour {

    //On player Collision
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Character.getCharacter().coinScore = (Character.getCharacter().coinScore + 1);
        }
    }

}
