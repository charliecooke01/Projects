using UnityEngine;
using System.Collections;

public class DamageScript : MonoBehaviour {


    public bool fire = false;
    public int damage = 1;
    public bool strong = false;

    //Sound Effects
    public AudioClip damageSound;
    private AudioSource damageSource;

    void Awake()
    {
        damageSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
	{
        if (other.tag == "Player")
        {
            if (Character.getCharacter().damageCount >= 2 &&
                !Character.getCharacter().rock &&
                (Character.getCharacter().fire != this.fire || this.strong))
            {
                damageSource.PlayOneShot(damageSound);
                Character.getCharacter().health = (Character.getCharacter().health - this.damage);
                Character.getCharacter().damageCount = 0;
                Character.getCharacter().hitCount = 0;
            }
        }
    }
}