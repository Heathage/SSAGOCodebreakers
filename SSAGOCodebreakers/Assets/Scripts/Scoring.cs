using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public int TeamOneScore, TeamTwoScore;
    public int tempChoice; 


    private void Start()
    {
        TeamOneScore = 9;
        TeamTwoScore = 9;
        Debug.Log("Team One starts!");
    }

    public void RemoveFromTotal(int buttonTeamID)
    {
        switch(buttonTeamID)
        {
            case 1:
                TeamOneScore--;
                if(TeamOneScore == 0)
                {
                    Debug.Log("Team One Wins!");
                }
                break;
            case 2:
                TeamTwoScore--;
                if (TeamTwoScore == 0)
                {
                    Debug.Log("Team Two Wins!");
                }
                break;
            case 3:
                Debug.Log("GAME OVER!");
                break;
            case 4:
                Debug.Log("Turn over!");
                break;
        }
    }





}
