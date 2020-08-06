using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFollower : MonoBehaviour
{
	public Transform objectToFollow;
	public bool followPosition = true;
	public bool mirrorRotation = true;
	public bool mirrorScale = false;

    void Update()
    {
		if (followPosition)
		{
			transform.position = objectToFollow.position;
		}

		if (mirrorRotation)
		{
			transform.rotation = objectToFollow.rotation;
		}

		if (mirrorScale)
		{
			transform.localScale = objectToFollow.localScale;
		}
    }
}
