using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichCollisions : MonoBehaviour
{
    private string fullOf = "SANDWICH";
    private Vector3 defaultPos;
    private Quaternion defaultRot;

    [Space]
    public string id;
    public string idDrink;
    public string idDrink2;

    [SerializeField] private SimplePickup pickup;

    private void Start()
    {
        defaultPos = transform.position;
        defaultRot = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        Combinable otherComb = other.gameObject.GetComponent<Combinable>();

        if (otherComb != null)
        {
            int i = otherComb.Compare(id);
            if (i != -1 && fullOf == "SANDWICH")
            {
                fullOf = otherComb.trickName[i];
                TrickManager._instance.AddTrick(otherComb.trickName[i], otherComb.score[i]);
                return;
            }

            i = otherComb.Compare(idDrink);
            if (i != -1)
            {
                TrickManager._instance.AddTrick(fullOf + " " + otherComb.trickName[i], otherComb.score[i]);
                fullOf = "SANDWICH";

                if (pickup != null)
                    pickup.ForceDrop();

                transform.position = defaultPos;
                transform.rotation = defaultRot;

                return;
            }

            i = otherComb.Compare(idDrink2);
            if (i != -1)
            {
                TrickManager._instance.AddTrick(otherComb.trickName[i], otherComb.score[i]);
                fullOf = "SANDWICH";

                if (pickup != null)
                    pickup.ForceDrop();

                transform.position = defaultPos;
                transform.rotation = defaultRot;
            }
        }
    }
}
