using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDraw : MonoBehaviour
{
    public float x_Start, y_Start;

    public int width, height;

    public float x_Space, y_space;
    public GameObject gridEntry;
    public Transform parent;

    public List<GameObject> gridList = new List<GameObject>();

    private void Awake()
    {
        parent = this.gameObject.transform;

        for (int i = 0; i < width * height; i++)
        {
            float gridX = x_Start + (x_Space * (i % width));
            float gridY = y_Start + (-y_space * (i / width));

            
            GameObject newcube = Instantiate(gridEntry, new Vector3(gridX, gridY), Quaternion.identity, parent);
            gridList.Add(newcube);

        }
    }
}
