// GENERATED AUTOMATICALLY FROM 'Assets/_Scripts/_Character/_Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""5cdf6a01-3783-49ee-8186-5fb23583d93f"",
            ""actions"": [
                {
                    ""name"": ""Left Stick"",
                    ""type"": ""Value"",
                    ""id"": ""2b50c107-553f-4647-8826-b53eb039b91d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Stick"",
                    ""type"": ""Value"",
                    ""id"": ""761cd18f-d819-4a64-93aa-3e8757b755f2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup Left"",
                    ""type"": ""Value"",
                    ""id"": ""aeebb4a0-c02b-4557-ba1d-c649e585ac4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup Right"",
                    ""type"": ""Value"",
                    ""id"": ""36e9ca13-74a1-459e-8cb8-f46e5f39450b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LiftArm Right"",
                    ""type"": ""Button"",
                    ""id"": ""ff8246c5-b69c-491b-8f9b-80e75efa5d99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LiftArm Left"",
                    ""type"": ""Button"",
                    ""id"": ""ea4e4c55-3a63-4cb0-b663-f9fef6305bcb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DropLeft"",
                    ""type"": ""Button"",
                    ""id"": ""104ab591-0e5a-481e-b879-2f05348c2614"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DropRight"",
                    ""type"": ""Button"",
                    ""id"": ""4183a1db-6302-44de-b067-87f070d1905b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""949dcbb2-ae7c-48aa-afe5-26c6cb8a34b9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""af0290b9-f7ec-4bec-a669-de9d81c37081"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""12fdcd62-28b5-40cc-bc2d-d1360254998a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""65936c0b-fb9a-4953-92c2-a4051cfdc24b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3beaf1bb-0066-42ae-b197-27a2c053b621"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0eda34bc-2ccb-4de5-84c0-7957fcbd2403"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ac7880ae-171b-4972-8e32-fb1a61da2c9c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""7d209d86-d9fa-4ee9-8af3-1a0315944fe3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e7c61c72-0dfc-4791-a941-ff285618500b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f7a04f28-18d2-4cd0-a6fa-879b232109bc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4abf057a-2a04-4854-a75e-c5202715dbf5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7c04c888-4830-4440-aed0-1a699cda79e3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""89814112-e2b3-4bad-a05e-bd3a8940a09b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b64629b-ffd6-4e29-87f7-20216f0d0ee6"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7b2ae79-a963-4607-ac4c-4f27e703c995"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b864eb1-982c-4dd4-a57e-a20ce4e7d98a"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0556c2b7-d2a6-46b8-994f-db1996b3ba0f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""938cf5af-477a-4b26-ab86-baefc02f5382"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35a3a30e-0279-4419-a74a-c95473fb872e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7e6180f-436d-4cf0-8589-c1625a77f2b3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9729b6b2-6b18-4c8e-9e83-bd00fb5385ac"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b889d711-ac9a-4a09-ad65-6470eed4fd5c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da5fcab0-cf11-435a-b283-3a20d57b6559"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c61b6b5c-c01d-4007-ada6-904c51745080"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99882f24-3e76-44d2-a404-963a1d70b4a6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba101948-c894-46cb-95a2-028c59b11e95"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9423f008-6e6f-4089-8927-48e03420bae2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftArm Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28b29ab2-47fd-467d-ab95-03dbc1f1b513"",
                    ""path"": ""<Keyboard>/numpadPeriod"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftArm Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""021956e7-6358-4996-b2cf-4b1719a9f5c8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftArm Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1c12c27-e3b1-40e4-bc01-c1e196a2caf8"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftArm Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Intro"",
            ""id"": ""a5ba1f43-497d-4c22-9e01-835e872f5acc"",
            ""actions"": [
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""3f5e0a35-abc6-4679-a3dd-0f426f8fecd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""89eb8022-d24a-43ea-a478-4d4f9db1489c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2c8484c-8250-45ed-98f5-ae1b734a05c3"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d994f046-00fb-450f-8aa8-7b63f5bb4bc2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5411451-0fe7-489d-8bf3-1deebb21846b"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_LeftStick = m_Default.FindAction("Left Stick", throwIfNotFound: true);
        m_Default_RightStick = m_Default.FindAction("Right Stick", throwIfNotFound: true);
        m_Default_PickupLeft = m_Default.FindAction("Pickup Left", throwIfNotFound: true);
        m_Default_PickupRight = m_Default.FindAction("Pickup Right", throwIfNotFound: true);
        m_Default_LiftArmRight = m_Default.FindAction("LiftArm Right", throwIfNotFound: true);
        m_Default_LiftArmLeft = m_Default.FindAction("LiftArm Left", throwIfNotFound: true);
        m_Default_DropLeft = m_Default.FindAction("DropLeft", throwIfNotFound: true);
        m_Default_DropRight = m_Default.FindAction("DropRight", throwIfNotFound: true);
        // Intro
        m_Intro = asset.FindActionMap("Intro", throwIfNotFound: true);
        m_Intro_Skip = m_Intro.FindAction("Skip", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_LeftStick;
    private readonly InputAction m_Default_RightStick;
    private readonly InputAction m_Default_PickupLeft;
    private readonly InputAction m_Default_PickupRight;
    private readonly InputAction m_Default_LiftArmRight;
    private readonly InputAction m_Default_LiftArmLeft;
    private readonly InputAction m_Default_DropLeft;
    private readonly InputAction m_Default_DropRight;
    public struct DefaultActions
    {
        private @PlayerControls m_Wrapper;
        public DefaultActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftStick => m_Wrapper.m_Default_LeftStick;
        public InputAction @RightStick => m_Wrapper.m_Default_RightStick;
        public InputAction @PickupLeft => m_Wrapper.m_Default_PickupLeft;
        public InputAction @PickupRight => m_Wrapper.m_Default_PickupRight;
        public InputAction @LiftArmRight => m_Wrapper.m_Default_LiftArmRight;
        public InputAction @LiftArmLeft => m_Wrapper.m_Default_LiftArmLeft;
        public InputAction @DropLeft => m_Wrapper.m_Default_DropLeft;
        public InputAction @DropRight => m_Wrapper.m_Default_DropRight;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @LeftStick.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftStick;
                @RightStick.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightStick;
                @PickupLeft.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPickupLeft;
                @PickupLeft.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPickupLeft;
                @PickupLeft.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPickupLeft;
                @PickupRight.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPickupRight;
                @PickupRight.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPickupRight;
                @PickupRight.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPickupRight;
                @LiftArmRight.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLiftArmRight;
                @LiftArmRight.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLiftArmRight;
                @LiftArmRight.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLiftArmRight;
                @LiftArmLeft.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLiftArmLeft;
                @LiftArmLeft.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLiftArmLeft;
                @LiftArmLeft.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLiftArmLeft;
                @DropLeft.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDropLeft;
                @DropLeft.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDropLeft;
                @DropLeft.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDropLeft;
                @DropRight.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDropRight;
                @DropRight.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDropRight;
                @DropRight.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDropRight;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
                @PickupLeft.started += instance.OnPickupLeft;
                @PickupLeft.performed += instance.OnPickupLeft;
                @PickupLeft.canceled += instance.OnPickupLeft;
                @PickupRight.started += instance.OnPickupRight;
                @PickupRight.performed += instance.OnPickupRight;
                @PickupRight.canceled += instance.OnPickupRight;
                @LiftArmRight.started += instance.OnLiftArmRight;
                @LiftArmRight.performed += instance.OnLiftArmRight;
                @LiftArmRight.canceled += instance.OnLiftArmRight;
                @LiftArmLeft.started += instance.OnLiftArmLeft;
                @LiftArmLeft.performed += instance.OnLiftArmLeft;
                @LiftArmLeft.canceled += instance.OnLiftArmLeft;
                @DropLeft.started += instance.OnDropLeft;
                @DropLeft.performed += instance.OnDropLeft;
                @DropLeft.canceled += instance.OnDropLeft;
                @DropRight.started += instance.OnDropRight;
                @DropRight.performed += instance.OnDropRight;
                @DropRight.canceled += instance.OnDropRight;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);

    // Intro
    private readonly InputActionMap m_Intro;
    private IIntroActions m_IntroActionsCallbackInterface;
    private readonly InputAction m_Intro_Skip;
    public struct IntroActions
    {
        private @PlayerControls m_Wrapper;
        public IntroActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Skip => m_Wrapper.m_Intro_Skip;
        public InputActionMap Get() { return m_Wrapper.m_Intro; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IntroActions set) { return set.Get(); }
        public void SetCallbacks(IIntroActions instance)
        {
            if (m_Wrapper.m_IntroActionsCallbackInterface != null)
            {
                @Skip.started -= m_Wrapper.m_IntroActionsCallbackInterface.OnSkip;
                @Skip.performed -= m_Wrapper.m_IntroActionsCallbackInterface.OnSkip;
                @Skip.canceled -= m_Wrapper.m_IntroActionsCallbackInterface.OnSkip;
            }
            m_Wrapper.m_IntroActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Skip.started += instance.OnSkip;
                @Skip.performed += instance.OnSkip;
                @Skip.canceled += instance.OnSkip;
            }
        }
    }
    public IntroActions @Intro => new IntroActions(this);
    public interface IDefaultActions
    {
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
        void OnPickupLeft(InputAction.CallbackContext context);
        void OnPickupRight(InputAction.CallbackContext context);
        void OnLiftArmRight(InputAction.CallbackContext context);
        void OnLiftArmLeft(InputAction.CallbackContext context);
        void OnDropLeft(InputAction.CallbackContext context);
        void OnDropRight(InputAction.CallbackContext context);
    }
    public interface IIntroActions
    {
        void OnSkip(InputAction.CallbackContext context);
    }
}
