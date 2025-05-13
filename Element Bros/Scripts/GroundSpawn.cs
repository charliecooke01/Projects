using UnityEngine;
using System.Collections;

public class GroundSpawn : MonoBehaviour
{
    
    //Time between each spawn
    public double spawnTimer = 0;
    public double gapTime = 0;
    public double speed = 0;
    public int gapDistance = 0;

    //Random number
    public int randomGap = 0;
    public int randomStep = 0;

    //step arrays
    public GameObject[] stepArray = new GameObject[100];
    private int[] minArray = new int[] {    13, 13, 13, 13, 13, 18, 18, 18, 18, 18, 23, 23, 23, 23 ,23, 28, 28, 28, 28, 28, 33, 33, 33, 33, 33,
                                    13, 13, 13, 13, 13, 18, 18, 18, 18, 18, 23, 23, 23, 23 ,23, 28, 28, 28, 28, 28, 33, 33, 33, 33, 33,
                                    13, 13, 13, 13, 13, 18, 18, 18, 18, 18, 23, 23, 23, 23 ,23, 28, 28, 28, 28, 28, 33, 33, 33, 33, 33,
                                    13, 13, 13, 13, 13, 18, 18, 18, 18, 18, 23, 23, 23, 23 ,23, 28, 28, 28, 28, 28, 33, 33, 33, 33, 33,
                                    13, 13, 13, 13, 13, 18, 18, 18, 18, 18, 23, 23, 23, 23 ,23, 28, 28, 28, 28, 28, 33, 33, 33, 33, 33  };

    private int[] maxArray = new int[] {    17, 17, 17, 17, 17, 22, 22, 22, 22, 22, 27, 27, 27, 27, 27, 32, 32, 32, 32, 32, 37, 37, 37, 37, 37,
                                    17, 17, 17, 17, 17, 22, 22, 22, 22, 22, 27, 27, 27, 27, 27, 32, 32, 32, 32, 32, 37, 37, 37, 37, 37,
                                    17, 17, 17, 17, 17, 22, 22, 22, 22, 22, 27, 27, 27, 27, 27, 32, 32, 32, 32, 32, 37, 37, 37, 37, 37,
                                    17, 17, 17, 17, 17, 22, 22, 22, 22, 22, 27, 27, 27, 27, 27, 32, 32, 32, 32, 32, 37, 37, 37, 37, 37,
                                    17, 17, 17, 17, 17, 22, 22, 22, 22, 22, 27, 27, 27, 27, 27, 32, 32, 32, 32, 32, 37, 37, 37, 37, 37 };

    
    void Start()
    {
        //Set first gap
        this.randomGap = Random.Range(9, 10);
        this.randomStep = Random.Range(1, 99);
    }


    void Update()
    {

        //find player speed
        this.speed = GameObject.Find("Main Camera").GetComponent<SpeedScript>().playerSpeed;

        //start Timer
        this.spawnTimer += Time.deltaTime * (this.speed * 1.67);
        this.gapTime = this.spawnTimer;

        //Random number
        this.randomStep = Random.Range(1, 100);

        //Increase gap distaqnce based on speed
        if (this.speed >= 4 && this.speed > 5)
        {
            gapDistance = 0;
        }

        if (this.speed >= 5 && this.speed > 6)
        {
            gapDistance = 1;
        }

        if (speed >= 6 && speed > 7)
        {
            gapDistance = 2;
        }

        if (speed >= 7 && speed > 8)
        {
            gapDistance = 3;
        }

        if (speed >= 8 && speed >= 9)
        {
            gapDistance = 4;
        }

        //gapDistance = (int)speed;

        //spawn Terrain
        this.SpawnTerrain(this.randomGap, 
            this.randomStep, 
            this.stepArray[this.randomStep], 
            (this.minArray[this.randomStep] + this.gapDistance), 
            (this.maxArray[this.randomStep] + this.gapDistance));


    }

    void SpawnTerrain(int rand, int stepOrder, GameObject stepNum, int gapMin, int gapMax)
    {

        if (this.randomStep == stepOrder && rand <= this.gapTime)
        {
            Instantiate(stepNum, new Vector3(20, -4, 0), Quaternion.Euler(0, 0, 0));
            this.randomGap = Random.Range(gapMin, gapMax);
            this.spawnTimer = 0;
            //randomStep = Random.Range(0, 19);
        }
    }



}
