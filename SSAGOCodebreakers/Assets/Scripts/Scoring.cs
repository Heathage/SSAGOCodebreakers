using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;

public class Scoring : MonoBehaviour
{
    public GameObject winner;

    public int TeamOneScore, TeamTwoScore;
    public int tempChoice;

    public TextMeshProUGUI TeamOneRemaining, TeamTwoRemaining;

    public UnityEvent OnValueChanged;

    private void Start()
    {
        TeamOneScore = 9;
        TeamTwoScore = 9;

        TeamOneRemaining.text = TeamOneScore.ToString();
        TeamTwoRemaining.text = TeamTwoScore.ToString();
        Debug.Log("Team One starts!");
    }

    public void RemoveFromTotal(int buttonTeamID)
    {
        switch(buttonTeamID)
        {
            case 1:
                TeamOneScore--;
                TeamOneRemaining.text = TeamOneScore.ToString();
                if (TeamOneScore == 0)
                {
                    winner.GetComponentInChildren<TextMeshProUGUI>().text = "Detective Frengo WINS!";
                    winner.SetActive(true);
                    Invoke("Endgame", 5f);

                }
                break;
            case 2:
                TeamTwoScore--;
                TeamTwoRemaining.text = TeamTwoScore.ToString();
                if (TeamTwoScore == 0)
                {
                    winner.GetComponentInChildren<TextMeshProUGUI>().text = "Detective Santiago WINS!";
                    winner.SetActive(true);
                }
                break;
            case 3:
                Debug.Log("GAME OVER!");
                winner.GetComponentInChildren<TextMeshProUGUI>().text = "THE CODE IS UNBREAKABLE";
                winner.SetActive(true);
                break;
            case 4:
                Debug.Log("Turn over!");
                break;
        }
    }

    private void Endgame()
    {
        SceneManager.LoadScene(0);
    }





}
