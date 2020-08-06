using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushCollisions : MonoBehaviour
{
    private string fullOf = "TOOTH";

    [Space]
    public string id;
    public string idDrink;

    private void OnTriggerEnter(Collider other)
    {
        Combinable otherComb = other.gameObject.GetComponent<Combinable>();

        if (otherComb != null)
        {
            int i = otherComb.Compare(id);
            if (i != -1 && fullOf == "TOOTH")
            {
                fullOf = otherComb.trickName[i];
                TrickManager._instance.AddTrick(otherComb.trickName[i], otherComb.score[i]);
                return;
            }

            i = otherComb.Compare(idDrink);
            if (i != -1)
            {
                TrickManager._instance.AddTrick(fullOf + " " + otherComb.trickName[i], otherComb.score[i]);
                fullOf = "TOOTH";
            }
        }
    }
}
