﻿using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

    private static Music instance = null;
    public static Music Instance
    {
        get { return instance; }
    }


    //Check to see if music object already exists and destroys the new copy
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
