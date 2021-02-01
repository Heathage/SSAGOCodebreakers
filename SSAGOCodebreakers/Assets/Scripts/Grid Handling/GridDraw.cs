using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridDraw : MonoBehaviour
{
    public Codenames codenames;

    public float x_Start, y_Start;

    public int width, height;

    public float x_Space, y_space;

    public GameObject gridEntry;
    public Transform parent;

    public List<GameObject> gridList = new List<GameObject>();

    private void Start()
    {
        codenames = FindObjectOfType<Codenames>();

        parent = this.gameObject.transform;

        for (int i = 0; i < width * height; i++)
        {
            float gridX = x_Start + (x_Space * (i % width));
            float gridY = y_Start + (-y_space * (i / width));


            GameObject newcube = Instantiate(gridEntry, new Vector3(gridX, gridY), Quaternion.identity, parent);
            gridList.Add(newcube);

        }

        AssignWords();

        AssignTeams();
    }

    public void AssignWords()
    {
        foreach (GameObject cube in gridList)
        {
            int tempRandom = Random.Range(0, codenames.wordChoosing.Count);
            string tempText = codenames.wordChoosing[tempRandom];
            Debug.Log(tempText);
            cube.GetComponentInChildren<TextMeshProUGUI>().text = tempText;
            codenames.wordChoosing.RemoveAt(tempRandom);
        }
    }

    public void AssignTeams()
    {
        TeamOne();
        TeamTwo();
        AutoFail();
        ExtraWords();

    }

    private void AssignTeamIDtoSquare(int IDnumber)
    {
        int random = Random.Range(0, gridList.Count);
        gridList[random].gameObject.GetComponent<CubeHandler>().buttonTeamID = IDnumber;
        gridList.RemoveAt(random);
    }

    private void TeamOne()
    {
        for (int i = 0; i < 9; i++)
        {
            AssignTeamIDtoSquare(1);

        }
    }

    private void TeamTwo()
    {
        for (int i = 0; i < 9; i++)
        {
            AssignTeamIDtoSquare(2);
        }
    }

    private void AutoFail()
    {
        AssignTeamIDtoSquare(3);

    }

    private void ExtraWords()
    {
        for (int i = 0; i < 6; i++)
        {
            AssignTeamIDtoSquare(4);
        }
    }


}
