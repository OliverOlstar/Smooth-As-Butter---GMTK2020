using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMassSetter : MonoBehaviour {

	public Transform centerOfMassPoint;

	Rigidbody rigidbody;

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();

		if (centerOfMassPoint != null)
		{
			rigidbody.centerOfMass = centerOfMassPoint.localPosition;
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown("s"))
		{
			rigidbody.centerOfMass = centerOfMassPoint.localPosition;
		}
	}

	private void OnDrawGizmos()
	{
		//Gizmos.color = Color.green;
		//Gizmos.DrawSphere(m_rigidbody.worldCenterOfMass, .5f);
	}
}
