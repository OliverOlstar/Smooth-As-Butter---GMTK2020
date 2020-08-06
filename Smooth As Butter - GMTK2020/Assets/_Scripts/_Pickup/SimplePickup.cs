using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class SimplePickup : MonoBehaviour, IPickup
{
    private Rigidbody Rb;
    [SerializeField] private string trickName = "PICKUP";
    [SerializeField] private UnityEvent pickedUp;
    private PlayerPickup holder;

    private Transform parent;

    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
        parent = transform.parent;
    }

    public bool Pickup(PlayerPickup pOther)
    {
        if (transform.parent == parent)
        {
            holder = pOther;
            transform.SetParent(pOther.myTransform);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            gameObject.layer = 8;
            if (transform.childCount > 0)
                transform.GetChild(0).gameObject.layer = 8;
            Rb.isKinematic = true;
            StopAllCoroutines();

            TrickManager._instance.AddTrick(trickName, 500);

            pickedUp.Invoke();

            return true;
        }
        return false;
    }

    public void Drop(Vector3 pVeloctiy)
    {
        transform.SetParent(parent);
        Rb.isKinematic = false;
        Rb.velocity = pVeloctiy;
        StartCoroutine(ResetLayerDelay());
    }

    private IEnumerator ResetLayerDelay()
    {
        yield return new WaitForSeconds(0.45f);
        gameObject.layer = 10;
        if (transform.childCount > 0)
            transform.GetChild(0).gameObject.layer = 10;
    }

    public GameObject GameObject()
    {
        return gameObject;
    }

    public void ForceDrop()
    {
        if (holder != null)
            holder.Drop();
    }
}
