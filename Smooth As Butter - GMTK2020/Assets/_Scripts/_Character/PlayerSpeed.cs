using RootMotion.Dynamics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeed : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private PuppetMaster pm;

    [Space]
    [SerializeField] private float defaultPinWeight = 0.6f;
    [SerializeField] private float multPinWeightVelocity = 0.6f;
    [SerializeField] private float dampening = 1;

    void Update()
    {
        float targetValue = defaultPinWeight - (rb.velocity.magnitude * multPinWeightVelocity);
        pm.pinWeight = Mathf.Lerp(pm.pinWeight, targetValue, Time.deltaTime * dampening);
    }
}
