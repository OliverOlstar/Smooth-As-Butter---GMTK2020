using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacingDirection : MonoBehaviour
{
    [SerializeField] private Transform transform1;
    [SerializeField] private Transform transform2;
    [SerializeField] private float dampening = 5;

    void Update()
    {
        // Smoothly transition position to target Pos
        Quaternion targetQ = Quaternion.LookRotation(GetForward());
        transform.rotation = Quaternion.Lerp(transform.rotation, targetQ, Time.deltaTime * dampening);
    }

    // Gets Average pos of targets
    private Vector3 GetForward()
    {
        Vector2 forward = Vector2.Perpendicular(Horizontal(transform1.position - transform2.position));
        return new Vector3(forward.x, 0, forward.y);
    }

    private Vector2 Horizontal(Vector3 pVector)
    {
        return new Vector2(pVector.x, pVector.z);
    }
}
