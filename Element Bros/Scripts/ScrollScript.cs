using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {


	public float speed = 0;
	public float pos = 0;
    //public float playerHealth = 4;

    public bool paused = false;

	void start ()
	{
		paused = false;
        //this.playerHealth = 4;
    }

	public void pauseButton ()
	{
		if (paused == false)
		{
			paused = true;
		}
		else if (paused == true)
		{
			paused = false;
		}
	}

    // Update is called once per frame
    void Update () {

        //this.playerHealth = Character.getCharacter().health;

        if (Character.getCharacter().health == 0)
        {
            paused = true;
        }

        if (paused == false)
				{
				this.pos += this.speed;
				if (this.pos > 1.0f)
				this.pos -= 1.0f;

				GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (this.pos, 0);
				//GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);
				}
	}
}
