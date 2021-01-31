using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeHandler : MonoBehaviour
{
    public Animator anim;

    public TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void rotateCube()
    {
        anim.SetInteger("Spin", 1);
    }

}
