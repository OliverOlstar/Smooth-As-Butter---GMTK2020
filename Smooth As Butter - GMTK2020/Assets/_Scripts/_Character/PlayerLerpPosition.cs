using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLerpPosition : MonoBehaviour
{
    [SerializeField] private Transform[] targetTransforms = new Transform[0];
    [SerializeField] private Vector3 offset;
    [SerializeField] private float dampening = 5;

    private float startingHeight = 0;

    private void Start()
    {
        startingHeight = transform.position.y;
    }

    void Update()
    {
        // Smoothly transition position to target Pos
        transform.position = Vector3.Lerp(transform.position, GetAverage() + offset, Time.deltaTime * dampening);

        // Clamp the Y value
        transform.position = new Vector3(transform.position.x, startingHeight, transform.position.z);
    }
    
    // Gets Average pos of targets
    private Vector3 GetAverage()
    {
        // If not set return zero
        if (targetTransforms.Length == 0)
            return Vector3.zero;

        // Add up transforms
        Vector3 total = new Vector3();
        foreach(Transform t in targetTransforms)
            total += t.position;

        // Divide to get average
        return total / targetTransforms.Length;
    }

    private void UpdateStandingHeight()
    {

    }
}
