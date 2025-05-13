using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

    //Player Values
    public float barHealth = 1;
    public float rockCount = 0;
    public float coinCount = 0;
    public float distanceCount = 0;
	public float finalDistanceCount = 0;
    public float highScore;// = PlayerPrefs.GetInt("highScore");
    public float score = 0;
    bool pause = false;
    public float playerHealth = 4;
	public float advertCount;
	bool advertCheck;
    bool advertCountCheck;

    //Random Level Number
    public int randomLevel = 1;

    //Score text
    Text coinString;
    Text distanceString;
    Text highScoreString;
    Text scoreString;
	Text highScoreTextGOString;
	Text coinTextGoString;
	Text distanceTextStringGo;

    //Score Values
    //public float highscore;
    //public float score;

    //UI Objects
    public GameObject healthImage;
    public GameObject rockBarImage;
    public GameObject coinCountText;
    public GameObject highScoreText;
    public GameObject distanceCountText;
    public GameObject scoreText;
	public GameObject highscoreTextGO;
	public GameObject coinTextGO;
	public GameObject distanceTextGO;

    public GameObject rockButtonObject;
	public Image jumpIcon;
	public Image switchIcon;
	public byte imageColour = 255;
	public Image rockButtonImage;
    public Image pauseButtonImage;
	public Image trophyImage;
    public GameObject pauseMenu;
    public GameObject gameoverMenu;
    public GameObject mainCanvas;

    //Sound Effects
    public AudioClip rockButtonSound;
    private AudioSource rockButtonSource;
    public bool rockButtonCheck = true;

    private bool beatHighScore = false;

    void Awake()
    {
        //rockButtonSource = GetComponent<AudioSource>();
        highScore = PlayerPrefs.GetFloat("highScore");
		advertCount = PlayerPrefs.GetFloat("advertCount");

    }

    //Called at game start
    void Start()
    {
        //Gather information from game
        barHealth = 1;
        rockCount = 0;
        coinCount = 0;
        distanceCount = 0;
		finalDistanceCount = 0; 
        highScore = PlayerPrefs.GetFloat("highScore");
		advertCount = PlayerPrefs.GetFloat("advertCount");
		jumpIcon.GetComponent<Image>().color = new Color32(255,255,225,255);
		switchIcon.GetComponent<Image>().color = new Color32(255,255,225,255);
        pauseMenu.gameObject.SetActive(false);
        gameoverMenu.gameObject.SetActive(false);
		trophyImage.enabled = false;
        Time.timeScale = 1.0f;

#if UNITY_IOS
		        Advertisement.Initialize ("1286461");
#endif
#if UNITY_ANDROID
        Advertisement.Initialize ("1286444");
#endif
        advertCheck = true;
        advertCountCheck = true;

    }

	public void pauseButton()
	{

		//Pause Button
			Time.timeScale = 0.0f;
            AudioListener.pause = true;
            pause = true;
            pauseButtonImage.enabled = false;
            pauseMenu.gameObject.SetActive(true);
    }

    public void playButton()
    {
        Time.timeScale = 1.0f;
        AudioListener.pause = false;
        pause = false;
        pauseButtonImage.enabled = true;
        pauseMenu.gameObject.SetActive(false);
    }

    public void homeButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        AudioListener.pause = false;
        pause = false;
        pauseButtonImage.enabled = true;
    }

    public void retryButton()
    {
        //Time.timeScale = 1.0f;
        // Load scene based on randomlevel number between 1 - 99
        this.randomLevel = Random.Range(1, 99);

        if (this.randomLevel >= 1 && this.randomLevel < 33)
        {
            SceneManager.LoadScene(1);
        }

        else if (this.randomLevel >= 33 && this.randomLevel < 66)
        {
            SceneManager.LoadScene(2);
        }

        else
        {
            SceneManager.LoadScene(3);           
        }

        Time.timeScale = 1.0f;
        AudioListener.pause = false;
        pause = false;
        pauseButtonImage.enabled = true;

    }


    // Update is called once per frame
    void Update()
    {
        //Get values for UI
        barHealth = (Character.getCharacter().health);
        rockCount = (Character.getCharacter().rockCounter);
        coinCount = Character.getCharacter().coinScore;
        distanceCount += Time.deltaTime * 10;
        score = coinCount + Mathf.Round(distanceCount/10);
		finalDistanceCount = Mathf.Round (distanceCount / 10);


        //Link to public game object
        Image healthBar = healthImage.GetComponent<Image>();
        Image rockBar = rockBarImage.GetComponent<Image>();
		Image trophy = trophyImage.GetComponent<Image>();
        Button rockButton = rockButtonObject.GetComponent<Button>();

		//Link to UI text objects
        coinString = coinCountText.GetComponent<UnityEngine.UI.Text>();
        distanceString = distanceCountText.GetComponent<UnityEngine.UI.Text>();
        highScoreString = highScoreText.GetComponent<UnityEngine.UI.Text>();
        scoreString = scoreText.GetComponent<UnityEngine.UI.Text>();
		highScoreTextGOString = highscoreTextGO.GetComponent<UnityEngine.UI.Text>();
		coinTextGoString = coinTextGO.GetComponent<UnityEngine.UI.Text>();
		distanceTextStringGo = distanceTextGO.GetComponent<UnityEngine.UI.Text>();

        //Set bars fills
        healthBar.fillAmount = barHealth / 4;
        rockBar.fillAmount = rockCount / 4;

        //set UI text
        coinString.text = coinCount.ToString();
        distanceString.text = distanceCount.ToString("0");
        highScoreString.text = highScore.ToString();
        scoreString.text = score.ToString();
		highScoreTextGOString.text = highScore.ToString();
		coinTextGoString.text = coinCount.ToString();
		distanceTextStringGo.text = finalDistanceCount.ToString();

        //Gameover
        this.playerHealth = Character.getCharacter().health;

        //Set new highscore if score > highscore
        if (score > highScore)
        {
            highScore = score;
            trophyImage.enabled = true;
            beatHighScore = true;
        }

        if (this.playerHealth == 0 && gameoverMenu.gameObject.activeSelf == false)
        {
            Time.timeScale = 0.0f;
            pause = true;
            pauseButtonImage.enabled = false;
			mainCanvas.gameObject.SetActive(false);

            if (beatHighScore)
            {
                PlayerPrefs.SetFloat("highScore", highScore);
                PlayerPrefs.Save();
                CloudOnceServices.instance.SubmitScoreToLeaderboard((int)highScore);
            }
            

            if (advertCountCheck)
			{
				advertCountCheck = false;

                advertCount = advertCount+1;
				PlayerPrefs.SetFloat ("advertCount", advertCount);
				PlayerPrefs.Save();
                
			    if (advertCount >= 3 && advertCheck && Advertisement.IsReady())
			    {
                    advertCheck = false;
                    PlayerPrefs.SetFloat("advertCount", 0);
                    PlayerPrefs.Save();
                    Advertisement.Show();
			    }
            }

            gameoverMenu.gameObject.SetActive(true);
        }

		//Fade instructions
		if (distanceCount >= 20 && imageColour > 0) {

			imageColour -= 5;
			if (imageColour < 10)
			{
				imageColour = 0;
			}

			jumpIcon.GetComponent<Image>().color = new Color32(255,255,225,imageColour);
			switchIcon.GetComponent<Image>().color = new Color32(255,255,225,imageColour);
		}


        //set button
        if (rockCount >= 4)
        {
            //rockButtonSource.PlayOneShot(rockButtonSound);
            rockButton.interactable = true;
            if (!pause)
            {
                rockButtonImage.GetComponent<Image>().transform.Rotate(0, 0, -1.0f);
            }
        }

        else
        {
            rockButton.interactable = false;
        }

        

    }
}
