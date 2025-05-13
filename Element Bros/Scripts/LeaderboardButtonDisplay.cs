using UnityEngine;

public class LeaderboardButtonDisplay : MonoBehaviour
{
    public GameObject LeaderboardButton;

    void Start()
    {

#if UNITY_IOS
        Debug.Log("Enabling the Leaderboard button for iOS");
            LeaderboardButton.SetActive(true);
#endif
    }
}
