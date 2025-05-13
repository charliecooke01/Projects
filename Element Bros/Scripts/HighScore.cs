using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

    public float highScore;

    Text highScoreString;

    public GameObject highScoreText;

    // Use this for initialization
    void Start () {

        highScore = PlayerPrefs.GetFloat("highScore");

    }
	
	// Update is called once per frame
	void Update () {

        highScoreString = highScoreText.GetComponent<UnityEngine.UI.Text>();
        highScoreString.text = highScore.ToString();
    }
}
