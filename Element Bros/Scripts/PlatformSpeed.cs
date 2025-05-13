using UnityEngine;
using System.Collections;

public class PlatformSpeed : MonoBehaviour {

	//Movement speed
	public double speed = 3;

	//Sets platfrom body
	private Rigidbody2D myRigidbody2D;

	// Use this for initialization
	void Start () {
		this.myRigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		//Sets Player speed
		this.speed = GameObject.Find("Main Camera").GetComponent<SpeedScript>().playerSpeed;
		this.myRigidbody2D.velocity = new Vector2 (- (float)this.speed, this.myRigidbody2D.velocity.y);

	}
}
