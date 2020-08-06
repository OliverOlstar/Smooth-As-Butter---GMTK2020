using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpPosition : MonoBehaviour
{
    private Vector3 position1;
    private Vector3 position2;

    private Quaternion rotation1;
    private Quaternion rotation2;

    private bool dir = false;

    [SerializeField] private float speed = 5;

    void Start()
    {
        position1 = transform.localPosition;
        position2 = transform.GetChild(0).localPosition;

        rotation1 = transform.localRotation;
        rotation2 = transform.GetChild(0).localRotation;
    }

    void Update()
    {
        if (dir)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, position1, Time.deltaTime * speed);
            transform.localRotation = Quaternion.Lerp(transform.localRotation, rotation1, Time.deltaTime * speed);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, position2, Time.deltaTime * speed);
            transform.localRotation = Quaternion.Lerp(transform.localRotation, rotation2, Time.deltaTime * speed);
        }
    }

    public void ToggleDir()
    {
        dir = !dir;
    }
}
