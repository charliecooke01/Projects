using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    private Rigidbody2D bulletBody2D;

    //public variables
    public bool strong = false;
    public bool flame = false;

    // Use this for initialization
    void Start () {

        this.bulletBody2D = GetComponent<Rigidbody2D>();

        //Initial speed
        this.bulletBody2D.AddForce(new Vector2(10, 0));
    }
	
	// Update is called once per frame
	void Update () {

        this.bulletBody2D.velocity = new Vector2(10, 0);
    }
}
