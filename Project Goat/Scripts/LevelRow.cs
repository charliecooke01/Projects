using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelRow
{
    public int col1 = 0;
    public int col2 = 0;
    public int col3 = 0;

    public LevelRow()
    {

    }

    public LevelRow(int col1, int col2, int col3)
    {
        this.col1 = col1;
        this.col2 = col2;
        this.col3 = col3;
    }

    public LevelRow(LevelRow levelRow)
    {
        this.col1 = levelRow.col1;
        this.col2 = levelRow.col2;
        this.col3 = levelRow.col3;
    }
}
