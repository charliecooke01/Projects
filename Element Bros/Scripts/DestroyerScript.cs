using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class DestroyerScript : MonoBehaviour {

    //UI objects
    public GameObject gameoverMenu;
    public GameObject mainCanvas;

    //Called at game start
    void Start()
    {
        //Gather information from game
        //gameoverMenu.gameObject.SetActive(false);

    }

        void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {

            Time.timeScale = 0.0f;
            Character.getCharacter().health = 0;
            //mainCanvas.gameObject.SetActive(false);
            //gameoverMenu.gameObject.SetActive(true);
            //SceneManager.LoadScene(0);
            return;
		}

        if (other.tag == "Bullet")
        {
            Character.getCharacter().bullet = false;
        }

        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject);
		} else {
			Destroy (other.gameObject);
		}
	}
}
