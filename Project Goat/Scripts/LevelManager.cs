using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // This class will contain the queue system for generating the platform GameObject's for each level.
    // If the player is playing "Infinite mode" then this script will randomlly create platforms

    public bool randomRowGeneration = false;
    public int platformOffset = 3;
    public GameObject platformParent;
    public List<GameObject> platforms = new List<GameObject>();
    public List<LevelRow> rows = new List<LevelRow>();
    
    private LevelRow previousLevelRow;
    private int previousRowType = 0;
    private int generatedLevelRowNum = 0;
    private int playerRowPosition = 0;

    // The collection of row types and the rows that can come after them. The available_positions array references the index of rowTypes
    private Dictionary<int, Dictionary<string, int[]>> rowTypes = new Dictionary<int, Dictionary<string, int[]>>
    {
        { 0, new Dictionary<string, int[]> { { "position", new int[] { 1, 0, 0 } }, { "available_positions", new int[] { 0, 1, 3 } } } },
        { 1, new Dictionary<string, int[]> { { "position", new int[] { 0, 1, 0 } }, { "available_positions", new int[] { 0, 1, 2, 3, 4, 5, 6 } } } },
        { 2, new Dictionary<string, int[]> { { "position", new int[] { 0, 0, 1 } }, { "available_positions", new int[] { 1, 2, 4 } } } },
        { 3, new Dictionary<string, int[]> { { "position", new int[] { 1, 1, 0 } }, { "available_positions", new int[] { 0, 1, 6 } } } },
        { 4, new Dictionary<string, int[]> { { "position", new int[] { 0, 1, 1 } }, { "available_positions", new int[] { 1, 2, 4, 6 } } } },
        { 5, new Dictionary<string, int[]> { { "position", new int[] { 1, 0, 1 } }, { "available_positions", new int[] { 1, 3, 4, 5, 6 } } } },
        { 6, new Dictionary<string, int[]> { { "position", new int[] { 1, 1, 1 } }, { "available_positions", new int[] { 1, 3, 4, 5, 6 } } } }
    };

    public void Start()
    {
        if (!randomRowGeneration)
        {
            Debug.Log("Adding rows to the platform queue");
        } else
        {
            Debug.Log("Creating a random platform queue");

            // Randomly generate the first 10 rows
            for (int i = 1; i <= 10; i++)
            {
                generateRandomLevelRow();
            }
        }
        // Create the gameobjects for the first 5 rows
        for (int i = 0; i < 5; i++)
        {
            this.handleRowManagement();
        }
    }
    
    // This method is used to randomly generate rows during "infinite mode"
    private void generateRandomLevelRow()
    {
        
        System.Random rnd = new System.Random();
        int rowType = -1;
        int col1 = 0;
        int col2 = 0;
        int col3 = 0;

        Debug.Log("previousLevelRow = " + this.previousLevelRow);

        if (previousLevelRow == null) this.previousRowType = 1;

        // Select a random row type based on the available positions of the last generated row
        int randomRowSelection = rnd.Next(0, rowTypes[this.previousRowType]["available_positions"].Length);
        rowType = rowTypes[this.previousRowType]["available_positions"][randomRowSelection];

        // if the randomly selected row type is the same as the previous type then randomise the selection again
        if (rowType == this.previousRowType)
        {
            randomRowSelection = rnd.Next(0, rowTypes[this.previousRowType]["available_positions"].Length);
            rowType = rowTypes[this.previousRowType]["available_positions"][randomRowSelection];
        }
           
        col1 = rowTypes[rowType]["position"][0];
        col2 = rowTypes[rowType]["position"][1];
        col3 = rowTypes[rowType]["position"][2];

        // Randomly select a platform prefab from the platforms list
        if (col1 > 0) col1 = rnd.Next(1, platforms.Count);
        if (col2 > 0) col2 = rnd.Next(1, platforms.Count);
        if (col3 > 0) col3 = rnd.Next(1, platforms.Count);

        LevelRow levelRow = new LevelRow(col1, col2, col3);

        rows.Add(levelRow);

        previousLevelRow = new LevelRow(levelRow);
        this.previousRowType = rowType;
    }

    public void handleRowManagement()
    {
        Debug.Log("Calling LevelManager.handleRowManagement()");
        this.createNextRowGameObject();
        this.deleteOldRows();
    }
    
    private void createNextRowGameObject()
    {
        if (rows.Count > 0)
        {

            LevelRow levelRow = rows[0];

            this.generatedLevelRowNum++;


            Debug.Log("Creating row " + generatedLevelRowNum);

            GameObject row = new GameObject("Row " + generatedLevelRowNum);

            row.transform.position = new Vector3(0, platformOffset * generatedLevelRowNum, platformOffset * generatedLevelRowNum);
            row.transform.SetParent(platformParent.transform);

            // instantiate platform gameobjects 
            instantiatePlatform(generatedLevelRowNum, 1, platforms[levelRow.col1], new Vector3(-3, 0, 0), row.transform);
            instantiatePlatform(generatedLevelRowNum, 2, platforms[levelRow.col2], new Vector3(0, 0, 0), row.transform);
            instantiatePlatform(generatedLevelRowNum, 3, platforms[levelRow.col3], new Vector3(3, 0, 0), row.transform);
            
            rows.RemoveAt(0);

        }

        if (this.randomRowGeneration) generateRandomLevelRow();
    }

    private void instantiatePlatform(int rowNum, int colNum, GameObject prefab, Vector3 position, Transform parent)
    {
        GameObject platform = Instantiate(prefab, parent.position + position, Quaternion.identity, parent);
        platform.name = "Row " + rowNum + " Column " + colNum;
    }

    public void increasePlayerRow()
    {
        Debug.Log("Calling LevelManager.increasePlayerRow()");
        playerRowPosition++;
    }

    // Remove the gameobjects (rows) that are out of the players viewport
    private void deleteOldRows()
    {
        // Delete rows that are 3 positions behind
        string rowName = "Row " + (this.playerRowPosition - 3);

        Debug.Log("Deleting: " + rowName);

        Transform rowTransform = platformParent.transform.Find(rowName);

        if (rowTransform != null) Destroy(rowTransform.gameObject);
    }
}
