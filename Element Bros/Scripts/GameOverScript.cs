using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour{

    //Random Level Number
    public int randomLevel = 1;

    //Score
    public float coinCount = 0;
    public float distanceCount = 0;




    public void Retry()
    {

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

    }


}