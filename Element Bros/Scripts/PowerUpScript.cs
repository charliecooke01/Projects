using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	private HUDScript hud;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			this.hud = GameObject.Find ("Main Camera").GetComponent<HUDScript> ();
			this.hud.IncreaseScore(10);
			Destroy (this.gameObject);
		}
	}

}