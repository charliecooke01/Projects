using UnityEngine;
using System.Collections;

public class SpeedScript : MonoBehaviour {

    public double playerSpeed = 0;
    public float startSpeed = 5;
    public float maxSpeed = 15;

    // Use this for initialization
    void Start () {
        this.playerSpeed = this.startSpeed;
    }
	
	// Update is called once per frame
	void Update () {

        this.playerSpeed = this.playerSpeed + (Time.deltaTime*0.08);
        if (this.playerSpeed > this.maxSpeed)
        {
            this.playerSpeed = this.maxSpeed;
        }
	}
}
