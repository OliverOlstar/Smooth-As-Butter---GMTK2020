using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerPickup : MonoBehaviour
{
    [SerializeField] private UnityEvent Pickuped;
    [SerializeField] private UnityEvent Dropped;

    private IPickup _pickup;
    private IPickup pickup
    {
        get
        {
            return _pickup;
        }

        set
        {
            _pickup = value;

            if (value == null)
            {
                Dropped.Invoke();
                StartCoroutine("RepickupDelay");
            }
            else
            {
                Pickuped.Invoke();
                StopCoroutine("RepickupDelay");
                lastPickup = value;
            }
        }
    }
    private IPickup lastPickup;

    private IEnumerator RepickupDelay() 
    {
        yield return new WaitForSeconds(0.5f);
        lastPickup = null;
    }

    public Transform myTransform;

    private void OnTriggerEnter(Collider other)
    {
        // Already holding something
        if (pickup != null)
            return;

        IPickup otherPickup = other.GetComponent<IPickup>();
        if (otherPickup == null)
            otherPickup = other.GetComponentInParent<IPickup>();

        if (otherPickup != null && otherPickup != lastPickup)
        {
            // Attempt Pickup
            if (otherPickup.Pickup(this))
                pickup = otherPickup;
        }
    }

    public void OnDrop(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && pickup != null)
        {
            Drop();
        }
    }

    public void Drop()
    {
        Vector3 vel = myTransform.GetComponent<Rigidbody>().velocity;
        pickup.Drop(vel);
        pickup = null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward);
    }
}
