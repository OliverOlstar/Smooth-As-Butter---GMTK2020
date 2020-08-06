using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
	private LayerMask affectorLayer;
	private LayerMask playerLayer;
	private Affector affector;
	private int numberOfCollisions;
	public bool isGrounded;
	public bool isInBoostZone;
	public bool isInJumpZone;
	public bool isInWater;
	public bool isInOil;
	
	private void Awake()
	{
		affectorLayer = LayerMask.NameToLayer("Affector");
		playerLayer = LayerMask.NameToLayer("Player");
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.layer != playerLayer)
		{
			numberOfCollisions++;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.layer != playerLayer)
		{
			numberOfCollisions--;
		}
	}

	private void Update()
	{
		if (numberOfCollisions > 0)
		{
			isGrounded = true;
		}
		else
		{
			isGrounded = false;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == affectorLayer)
		{
			affector = other.GetComponent<Affector>();

			if (affector.isBoost)
			{
				isInBoostZone = true;
			}

			if (affector.isJump)
			{
				isInJumpZone = true;
			}

			if (affector.isWater)
			{
				isInWater = true;
			}

			if (affector.isOil)
			{
				isInOil = true;
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.layer == affectorLayer)
		{
			affector = other.GetComponent<Affector>();

			if (affector.isBoost)
			{
				isInBoostZone = false;
			}

			if (affector.isJump)
			{
				isInJumpZone = false;
			}

			if (affector.isWater)
			{
				isInWater = false;
			}

			if (affector.isOil)
			{
				isInOil = false;
			}
		}
	}
}
