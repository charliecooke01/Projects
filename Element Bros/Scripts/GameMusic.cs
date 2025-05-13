using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour {


    void Awake()
    {
        // see if we've got menu music still playing
        var menuMusic = GameObject.Find("MenuMusic");
        if (menuMusic)
        {
            // kill game music
            Destroy(menuMusic);
        }
        // make sure we survive going to different scenes
        DontDestroyOnLoad(gameObject);
    }

}
