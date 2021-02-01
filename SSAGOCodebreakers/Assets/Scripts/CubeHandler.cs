using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeHandler : MonoBehaviour
{
    public int buttonTeamID; 

    public Animator anim;

    public TextMeshProUGUI text;

    public GameObject image;

    public Sprite teamOne, teamTwo, autoFail, extraWords;

    private void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Update()
    {
        switch(buttonTeamID)
        {
            case 1:
                image.GetComponent<Image>().sprite = teamOne;
                break;
            case 2:
                image.GetComponent<Image>().sprite = teamTwo;
                break;
            case 3:
                image.GetComponent<Image>().sprite = autoFail;
                break;
            case 4:
                image.GetComponent<Image>().sprite = extraWords;
                break;
        }
    }

    public void rotateCube()
    {
        anim.SetInteger("Spin", 1);
    }

}
