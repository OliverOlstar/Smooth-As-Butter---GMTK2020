using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickModifierTracker : MonoBehaviour
{
    [SerializeField] private Transform myCamera;
    [SerializeField] private Transform myPlayer;

    private static readonly int spinAmountCount = 100;
    private int[] spinAmount = new int[spinAmountCount];
    private Vector3 prevRotation;
    private int index = 0;

    private void FixedUpdate()
    {
        spinAmount[index] = Mathf.RoundToInt(Vector3.SignedAngle(myPlayer.forward, prevRotation, Vector3.up));

        index++;
        if (index == spinAmountCount)
            index = 0;

        prevRotation = myPlayer.forward;
    }

    public struct Modifer
    {
        public Modifer(string pName, float pScore)
        {
            name = pName;
            score = pScore;
        }

        public string name;
        public float score;
    }

    public Modifer side()
    {
        float dot = Vector3.Dot(myCamera.forward, myPlayer.forward);

        string dir = dot < 0.0f ? "FrontSide" : "BackSide";
        float score = dot < 0.0f ? 150 : 50;
        Modifer modifer = new Modifer(dir, 0);

        return modifer;
    }

    public Modifer spins()
    {
        int s = 0;
        foreach (int v in spinAmount)
            s += v;

        ClearSpinAmount();
        s = Mathf.RoundToInt(s / 90);

        Modifer modifer = new Modifer((s * 90).ToString(), 100 * s);
        return modifer;
    }

    private void ClearSpinAmount()
    {
        for (int i = 0; i < spinAmountCount; i++)
        {
            spinAmount[i] = 0;
        }
    }
}
