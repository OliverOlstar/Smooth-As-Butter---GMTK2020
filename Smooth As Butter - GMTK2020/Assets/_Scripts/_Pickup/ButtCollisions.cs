using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtCollisions : MonoBehaviour
{
    public string id;

    private void OnTriggerEnter(Collider other)
    {
        Combinable otherComb = other.gameObject.GetComponent<Combinable>();

        if (otherComb != null)
        {
            int i = otherComb.Compare(id);
            if (i != -1)
                TrickManager._instance.AddTrick(otherComb.trickName[i], otherComb.score[i]);
        }
    }
}
