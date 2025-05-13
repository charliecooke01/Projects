using UnityEngine;

public class CameraRunnerScript : MonoBehaviour {

	public Transform player;

	void FixedUpdate ()
	{
		transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3 (this.player.position.x + 6, (0.5f + (this.player.position.y/10)), -10), 0.25f);
	}
}
