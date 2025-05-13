using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour {

    //Splash object
    public GameObject splash;

    //Sound Effects
    public AudioClip splashSound;
    private AudioSource splashSource;

    //public GameObject groundSpawn;
    //public GameObject enemySpawn1;
    //public GameObject enemySpawn2;
    //public GameObject enemySpawn3;

    void Awake()
    {
        splashSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            splashSource.PlayOneShot(splashSound);
            Instantiate(splash, new Vector3(other.transform.position.x, -3, other.transform.position.z), Quaternion.identity);
            other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            //other.rigidbody2D.velocity = 0;
            //other.gameObject.rigidbody = RigidbodyConstraints.FreezePositionX;
            //SceneManager.LoadScene(1);
        }

        else
        {
            //splashSource.PlayOneShot(splashSound);
            Instantiate(splash, new Vector3(other.transform.position.x, -3, other.transform.position.z), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}