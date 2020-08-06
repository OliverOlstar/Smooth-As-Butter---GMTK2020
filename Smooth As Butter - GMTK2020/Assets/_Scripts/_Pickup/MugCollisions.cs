using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugCollisions : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    [SerializeField] private Color emptyColor;
    private string fullOf = "";

    [Space]
    public string id;
    public string idDrink;

    private void Start()
    {
        renderer.material.color = emptyColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        Combinable otherComb = other.gameObject.GetComponent<Combinable>();

        if (otherComb != null)
        {
            int i = otherComb.Compare(id);
            if (i != -1 && fullOf == "")
            {
                fullOf = otherComb.trickName[i];
                TrickManager._instance.AddTrick(otherComb.trickName[i], otherComb.score[i]);
                renderer.material.color = otherComb.color[i];
                return;
            }

            i = otherComb.Compare(idDrink);
            if (i != -1 && fullOf != "")
            {
                TrickManager._instance.AddTrick(otherComb.trickName[i] + " " + fullOf, otherComb.score[i]);
                renderer.material.color = emptyColor;
                fullOf = "";
            }
        }
    }
}
