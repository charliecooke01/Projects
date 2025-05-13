using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScroll : MonoBehaviour {

    public float speed = 0;
    public float pos = 0;

    void start()
    {
        Time.timeScale = 1.0f;
    }


	// Update is called once per frame
	void Update () {

        this.pos += this.speed;
        if (this.pos > 1.0f)
            this.pos -= 1.0f;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(this.pos, 0);
    }
}
