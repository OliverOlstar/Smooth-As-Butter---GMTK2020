using UnityEngine;

public interface IPickup
{
    bool Pickup(PlayerPickup pOther);
    void Drop(Vector3 pVeloctiy);
    GameObject GameObject();
}
