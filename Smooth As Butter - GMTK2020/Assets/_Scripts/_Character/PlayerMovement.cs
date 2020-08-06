using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private UnityEvent FootUp;
    [SerializeField] private UnityEvent FootDown;

	public CinemachineClearShot myClearShot;
	[SerializeField] private Transform myCamera;

    [SerializeField] private Transform LeftLegTarget;
    private Transform _leftLegTarget;
    private float leftTargetHeight = 0;
    private float leftHeightInput = 0;

    [SerializeField] private Transform RightLegTarget;
    private Transform _rightLegTarget;
    private float rightTargetHeight = 0;
    private float rightHeightInput = 0;

    [SerializeField] private Transform LeftArmTarget;
    private Transform _leftArmTarget;

    [SerializeField] private Transform RightArmTarget;
    private Transform _rightArmTarget;

    [SerializeField] private GameObject TargetPrefab;

    [Space]
    [SerializeField] private float maxArmReach = 1;
    [SerializeField] private float maxLegReach = 2;

    [Space]
    [SerializeField] private float movementDampening = 5;
    [SerializeField] private float movementSpeed = 5;
    [SerializeField] private float liftSpeed = 5;
    [SerializeField] private Vector2 liftMinMax = new Vector2(-0.5f, 0.5f);

    private enum LegState
    {
        Down,
        Request,
        Up
    }

    private LegState leftLegState = LegState.Down;
    private LegState rightLegState = LegState.Down;
    private bool liftLeftArm = false;
    private bool liftRightArm = false;
    private Vector2 leftStick = new Vector2();
    private Vector2 rightStick = new Vector2();

    private void Awake()
    {
        // Left Leg
        _leftLegTarget = CreateTarget(LeftLegTarget, "True LeftLegTarget");
        leftTargetHeight = _leftLegTarget.position.y;

        // Right Leg
        _rightLegTarget = CreateTarget(RightLegTarget, "True RightLegTarget");
        rightTargetHeight = _rightLegTarget.position.y;

        // Left Arm
        _leftArmTarget = CreateTarget(LeftArmTarget, "True LeftArmTarget");

        // Right Arm
        _rightArmTarget = CreateTarget(RightArmTarget, "True RightArmTarget");
    }

    private Transform CreateTarget(Transform pCloneOf, string pName = "Unnamed Target")
    {
        Transform trans = Instantiate(TargetPrefab).transform;
        trans.gameObject.name = pName;
        trans.position = pCloneOf.position;
        trans.rotation = pCloneOf.rotation;
        trans.SetParent(pCloneOf.parent);
        return trans;
    }

    private void Update()
    {
        // Left Stick Input
        if (leftLegState == LegState.Up)
            MoveLeg(leftStick, _leftLegTarget, _rightLegTarget, leftTargetHeight + leftHeightInput);
        else if (leftLegState == LegState.Down)
        {
            if (liftLeftArm)
                LiftArm(leftStick.y, _leftArmTarget);
            else
                MoveArm(leftStick, _leftArmTarget);
        }

        // Right Stick Input
        if (rightLegState == LegState.Up)
            MoveLeg(rightStick, _rightLegTarget, _leftLegTarget, rightTargetHeight + rightHeightInput);
        else if (rightLegState == LegState.Down)
        {
            if (liftRightArm)
                LiftArm(rightStick.y, _rightArmTarget);
            else
                MoveArm(rightStick, _rightArmTarget);
        }

        // Lerp Real Targets to their Clone's Positions
        LeftLegTarget.position = Vector3.Lerp(LeftLegTarget.position, _leftLegTarget.position, Time.deltaTime * movementDampening);
        RightLegTarget.position = Vector3.Lerp(RightLegTarget.position, _rightLegTarget.position, Time.deltaTime * movementDampening);
        LeftArmTarget.position = Vector3.Lerp(LeftArmTarget.position, _leftArmTarget.position, Time.deltaTime * movementDampening);
        RightArmTarget.position = Vector3.Lerp(RightArmTarget.position, _rightArmTarget.position, Time.deltaTime * movementDampening);
    }

    #region Movements
    private void MoveArm(Vector2 pInput, Transform pArm)
    {
        if (pInput != Vector2.zero)
        {
            Vector3 movement = RotateToCamera(new Vector3(pInput.x, 0, pInput.y));
            pArm.position += movement * Time.deltaTime * movementSpeed;
            pArm.localPosition = Vector3.ClampMagnitude(pArm.localPosition, maxArmReach);
        }
    }

    private void LiftArm(float pInput, Transform pArm)
    {
        if (pInput != 0)
        {
            float y = pArm.localPosition.y + pInput * Time.deltaTime * liftSpeed;
            SetPosY(pArm, Mathf.Clamp(y, liftMinMax.x, liftMinMax.y), true);
        }
    }

    private void MoveLeg(Vector2 pInput, Transform pLeg, Transform pOtherLeg, float pHeight)
    {
        // Set Height
        SetPosY(pLeg, pHeight);

        if (pInput != Vector2.zero)
        {
            Vector3 movement = RotateToCamera(new Vector3(pInput.x, 0, pInput.y));
            pLeg.position += movement * Time.deltaTime * movementSpeed;

            // Clamp Distance between legs
            Vector3 relPos = pLeg.position - pOtherLeg.position;
            relPos = Vector3.ClampMagnitude(relPos, maxLegReach);
            pLeg.position = relPos + pOtherLeg.position;
        }
    }

    private void RequestLiftLeftLeg()
    {
        if (leftLegState == LegState.Request && rightLegState == LegState.Down)
        {
            leftLegState = LegState.Up;
            FootUp.Invoke();
        }
    }

    private void RequestLiftRightLeg()
    {
        if (rightLegState == LegState.Request && leftLegState == LegState.Down)
        {
            rightLegState = LegState.Up;
            FootUp.Invoke();
        }
    }
    #endregion

    #region Inputs
    public void OnLeftStick(InputAction.CallbackContext ctx)
    {
        Vector2 input = ctx.ReadValue<Vector2>();
        leftStick = input;
    }

    public void OnRightStick(InputAction.CallbackContext ctx)
    {
        Vector2 input = ctx.ReadValue<Vector2>();
        rightStick = input;
    }

    public void OnPickupLeft(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (leftLegState == LegState.Down)
            {
                leftLegState = LegState.Request;
                RequestLiftLeftLeg();
            }

            leftHeightInput = ctx.ReadValue<float>() * 0.5f;
        }
        else if (ctx.canceled)
        {
            if (leftLegState == LegState.Up)
            {
                SetPosY(_leftLegTarget, leftTargetHeight);
                leftLegState = LegState.Down;
                RequestLiftRightLeg();

                FootDown.Invoke();
            }
            else
                leftLegState = LegState.Down;
        }
    }

    public void OnPickupRight(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (rightLegState == LegState.Down)
            {
                rightLegState = LegState.Request;
                RequestLiftRightLeg();
            }

            rightHeightInput = ctx.ReadValue<float>() * 0.5f;
        }
        else if(ctx.canceled)
        {
            if (rightLegState == LegState.Up)
            {
                SetPosY(_rightLegTarget, rightTargetHeight);
                rightLegState = LegState.Down;
                RequestLiftLeftLeg();

                FootDown.Invoke();
            }
            else
                rightLegState = LegState.Down;
        }
    }

    public void OnLiftLeft(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            liftLeftArm = true;
        }
        else if (ctx.canceled)
        {
            liftLeftArm = false;
            SetPosY(_leftArmTarget, 0, true);
        }
    }

    public void OnLiftRight(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            liftRightArm = true;
        }
        else if (ctx.canceled)
        {
            liftRightArm = false;
            SetPosY(_rightArmTarget, 0, true);
        }
    }
    #endregion

    private void SetPosY(Transform pTrans, float pY, bool pLocal = false)
    {
        if (pLocal)
            pTrans.localPosition = new Vector3(pTrans.localPosition.x, pY, pTrans.localPosition.z);
        else
            pTrans.position = new Vector3(pTrans.position.x, pY, pTrans.position.z);
    }

    private Vector3 RotateToCamera(Vector3 pVector)
    {
        float mag = pVector.magnitude;

		// Set myCamera to the active ClearShot virtual camera
        if (myClearShot != null)
		    myCamera = myClearShot.LiveChild.VirtualCameraGameObject.transform;

        pVector = myCamera.TransformDirection(pVector);
        pVector.y = 0;
        pVector.Normalize();
        pVector *= mag;

        return pVector;
    }
}
