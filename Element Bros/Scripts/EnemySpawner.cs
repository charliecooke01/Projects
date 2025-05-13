using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

	public float spawnTimer = 0;
	public float gapTime = 0;

	//Random number
	public int randomGap = 0;
	public int randomEnemy = 0;
	public int maxGap = 15;


	//Enemies
	//public GameObject Ice;
	public GameObject Fire;
	public GameObject Drop;
    //public GameObject Ice;

    //Spawn point
    public GameObject SpawnPoint;

	// Use this for initialization
	void Start()
	{

		this.randomGap = Random.Range(10, this.maxGap);
		this.randomEnemy = Random.Range(1, 6);

	}

	// Update is called once per frame
	void Update()
	{

		//start Timer
		this.spawnTimer += Time.deltaTime * 10;
		this.gapTime = this.spawnTimer;

		if (this.randomGap <= this.gapTime)
		{
			SpawnEnemy(this.randomEnemy, 25, 40);
			this.randomEnemy = Random.Range(1, 6);
		}
	}

    //	randomEnemy >= 1 && randomEnemy <= 4

    void SpawnEnemy(int rand, int gapMin, int gapMax)
    {
        if (rand >= 1 && rand <= 3)
        {
            Instantiate(this.Drop, (this.SpawnPoint.transform.position), Quaternion.Euler(0, 0, 0));
            this.randomGap = Random.Range(gapMin, gapMax);
            this.spawnTimer = 0;
        }

        else if (rand >= 4 && rand <= 6)
        {
            Instantiate(this.Fire, (this.SpawnPoint.transform.position), Quaternion.Euler(0, 0, 0));
            this.randomGap = Random.Range(gapMin, gapMax);
            this.spawnTimer = 0;
        }
        /*else //(rand >= 7 && rand <= 9)
        {
        	Instantiate(this.Ice, new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
        	this.randomGap = Random.Range(gapMin, gapMax);
        	this.spawnTimer = 0;
        }*/
    }
}
