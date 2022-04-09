using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject[] items;
    private int count = 0;
    public void Right()
    {
        if (count+1 >= items.Length) return;

        items[count].SetActive(false);
        count++;
        items[count].SetActive(true);
    }

    public void Left()
    {
        if (count-1 < 0) return;

        items[count].SetActive(false);
        count--;
        items[count].SetActive(true);
    }
}
