using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerActivate : MonoBehaviour, IPickup
{
    [SerializeField] private UnityEvent triggered;
    [SerializeField] private string trickName;
    [SerializeField] private int score;

    public bool Pickup(PlayerPickup pOther)
    {
        if (trickName != "")
            TrickManager._instance.AddTrick(trickName, score);

        triggered.Invoke();
        return false;
    }

    public void Drop(Vector3 pVeloctiy)
    {

    }

    public GameObject GameObject()
    {
        return gameObject;
    }
}
