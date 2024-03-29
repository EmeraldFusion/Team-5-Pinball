//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""3487e429-a99b-48e2-a2e4-cf9be0ddcebd"",
            ""actions"": [
                {
                    ""name"": ""FlipL"",
                    ""type"": ""Button"",
                    ""id"": ""83345ea2-4675-4c12-9625-a4d2733d2314"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlipR"",
                    ""type"": ""Button"",
                    ""id"": ""4b8e92aa-713e-457a-9463-6775e0ef4ab8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LaunchB"",
                    ""type"": ""Button"",
                    ""id"": ""b06ebd35-02e2-41b3-a04c-b9bc3807264d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ExtraR"",
                    ""type"": ""Button"",
                    ""id"": ""efd06694-ca9e-42b3-b1c9-744389bf41a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ExtraL"",
                    ""type"": ""Button"",
                    ""id"": ""d2e0e585-128f-4e79-b979-ba909e6955a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""3701e27e-5802-4e21-ab25-ccf9caa206c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e8304716-c393-4ba1-add2-a94353de1b4f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed7b5e1a-bd2b-4708-9217-c70879a89809"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b18cad32-e9d9-4a87-ba61-993ea131fb6d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51e4bb4e-3d75-459e-9334-855cf01aeb97"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10444a4e-f61f-4da5-892b-3ab96b50849e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaunchB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3667b0c-d896-4183-b3ff-ad4958daa9b2"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaunchB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""037cf34c-ff24-4f4f-843d-4a08f08cd72f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaunchB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1dedaacb-03ed-4894-9ce3-eb7548dd0355"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExtraR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""818974ec-3b70-42ad-b66e-4df5bfa4ef41"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExtraR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd36af16-2047-4417-acdc-b2f8ecb6d4f2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExtraL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a031c9b3-fb5a-478e-98c6-458629200540"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExtraL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8322df2-be2b-465b-b4f7-6a323fde8a8d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
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
        m_Default_FlipL = m_Default.FindAction("FlipL", throwIfNotFound: true);
        m_Default_FlipR = m_Default.FindAction("FlipR", throwIfNotFound: true);
        m_Default_LaunchB = m_Default.FindAction("LaunchB", throwIfNotFound: true);
        m_Default_ExtraR = m_Default.FindAction("ExtraR", throwIfNotFound: true);
        m_Default_ExtraL = m_Default.FindAction("ExtraL", throwIfNotFound: true);
        m_Default_Restart = m_Default.FindAction("Restart", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Default
    private readonly InputActionMap m_Default;
    private List<IDefaultActions> m_DefaultActionsCallbackInterfaces = new List<IDefaultActions>();
    private readonly InputAction m_Default_FlipL;
    private readonly InputAction m_Default_FlipR;
    private readonly InputAction m_Default_LaunchB;
    private readonly InputAction m_Default_ExtraR;
    private readonly InputAction m_Default_ExtraL;
    private readonly InputAction m_Default_Restart;
    public struct DefaultActions
    {
        private @Controls m_Wrapper;
        public DefaultActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FlipL => m_Wrapper.m_Default_FlipL;
        public InputAction @FlipR => m_Wrapper.m_Default_FlipR;
        public InputAction @LaunchB => m_Wrapper.m_Default_LaunchB;
        public InputAction @ExtraR => m_Wrapper.m_Default_ExtraR;
        public InputAction @ExtraL => m_Wrapper.m_Default_ExtraL;
        public InputAction @Restart => m_Wrapper.m_Default_Restart;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void AddCallbacks(IDefaultActions instance)
        {
            if (instance == null || m_Wrapper.m_DefaultActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Add(instance);
            @FlipL.started += instance.OnFlipL;
            @FlipL.performed += instance.OnFlipL;
            @FlipL.canceled += instance.OnFlipL;
            @FlipR.started += instance.OnFlipR;
            @FlipR.performed += instance.OnFlipR;
            @FlipR.canceled += instance.OnFlipR;
            @LaunchB.started += instance.OnLaunchB;
            @LaunchB.performed += instance.OnLaunchB;
            @LaunchB.canceled += instance.OnLaunchB;
            @ExtraR.started += instance.OnExtraR;
            @ExtraR.performed += instance.OnExtraR;
            @ExtraR.canceled += instance.OnExtraR;
            @ExtraL.started += instance.OnExtraL;
            @ExtraL.performed += instance.OnExtraL;
            @ExtraL.canceled += instance.OnExtraL;
            @Restart.started += instance.OnRestart;
            @Restart.performed += instance.OnRestart;
            @Restart.canceled += instance.OnRestart;
        }

        private void UnregisterCallbacks(IDefaultActions instance)
        {
            @FlipL.started -= instance.OnFlipL;
            @FlipL.performed -= instance.OnFlipL;
            @FlipL.canceled -= instance.OnFlipL;
            @FlipR.started -= instance.OnFlipR;
            @FlipR.performed -= instance.OnFlipR;
            @FlipR.canceled -= instance.OnFlipR;
            @LaunchB.started -= instance.OnLaunchB;
            @LaunchB.performed -= instance.OnLaunchB;
            @LaunchB.canceled -= instance.OnLaunchB;
            @ExtraR.started -= instance.OnExtraR;
            @ExtraR.performed -= instance.OnExtraR;
            @ExtraR.canceled -= instance.OnExtraR;
            @ExtraL.started -= instance.OnExtraL;
            @ExtraL.performed -= instance.OnExtraL;
            @ExtraL.canceled -= instance.OnExtraL;
            @Restart.started -= instance.OnRestart;
            @Restart.performed -= instance.OnRestart;
            @Restart.canceled -= instance.OnRestart;
        }

        public void RemoveCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDefaultActions instance)
        {
            foreach (var item in m_Wrapper.m_DefaultActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnFlipL(InputAction.CallbackContext context);
        void OnFlipR(InputAction.CallbackContext context);
        void OnLaunchB(InputAction.CallbackContext context);
        void OnExtraR(InputAction.CallbackContext context);
        void OnExtraL(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
}
