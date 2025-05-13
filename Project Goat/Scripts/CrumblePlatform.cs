using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrumblePlatform : MonoBehaviour
{
    public float destroyAfter = 3f;

    private GameObject player;
    private bool isDestroyed = false;
    private bool startTimer = false;
    private float timeOnPlatform = 0f;
    private bool isOnPlatform = false;

    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
        if (this.player != null)
        {
            Debug.Log("CrumblePlatform found Player");
        } else
        {
            Debug.Log("CrumblePlatform cannot find Player");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!this.isDestroyed)
        {
            if (this.startTimer)
            {
                this.timeOnPlatform += Time.deltaTime;
            }

            if (this.timeOnPlatform >= destroyAfter)
            {
                this.isDestroyed = true;
            }
        } else
        {
            if (player != null && this.isOnPlatform) player.GetComponent<PlayerMovement>().setFalling(true);
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter: " + gameObject.name + " collided with " + other.name);

        if (other.name == "Player")
        {
            this.startTimer = true;
            this.isOnPlatform = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit: " + gameObject.name + " no longer collides with " + other.name);

        if (other.name == "Player")
        {
            this.isOnPlatform = false;
        }
    }
}
