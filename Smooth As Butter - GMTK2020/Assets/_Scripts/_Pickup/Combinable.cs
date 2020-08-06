using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combinable : MonoBehaviour
{
    public string[] trickName = new string[1];
    public int[] score = new int[1];
    public Color[] color = new Color[1];

    [Space]
    public string[] ids = new string[1];

    public int Compare(string pId)
    {
        for (int i = 0; i < ids.Length; i++)
        {
            if (ids[i] == pId)
                return i;
        }
        return -1;
    }
}
