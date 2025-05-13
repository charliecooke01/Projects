using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HUDScript : MonoBehaviour {

	public float playerScore = 0;
	public float playerHealth = 4;
	public float playerCoins = 0;
	public float rockBar = 0;

    public Image pauseButtonImage;
    public GameObject gameoverMenu;

    //reset health at start
    void Start ()
	{
		this.playerHealth = 4;
		this.playerCoins = 0;
		this.rockBar = 0;
	}

	//distance counter
	void Update () {

		this.playerHealth = Character.getCharacter().health;
		this.playerCoins = Character.getCharacter().coinScore;
		this.rockBar = Character.getCharacter().rockCounter;
		this.playerScore += Time.deltaTime * 3;

		//if (this.playerHealth == 0)
		//{
  //          Time.timeScale = 0.0f;
  //          pauseButtonImage.enabled = false;
  //          gameoverMenu.gameObject.SetActive(true);
  //          //SceneManager.LoadScene(0);
  //      }
	}

	//score based on distance
	public void IncreaseScore(int amount)
	{
		this.playerScore += amount;
	}

	void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)this.playerScore);
	}

	//Display GUI
	void OnGUI ()
	{
		GUI.color = Color.black;
		//GUI.Label(new Rect (200,10, 100, 30), "Health: " + this.playerHealth);
		//GUI.Label(new Rect(300, 10, 100, 30), "Coins: " + this.playerCoins);
		//GUI.Label(new Rect(400, 10, 100, 30), "Rock: " + this.rockBar);
		//GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)this.playerScore);
	}
}
