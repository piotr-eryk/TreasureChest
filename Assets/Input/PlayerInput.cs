//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""b283ab7b-9856-46f9-ba3d-c7d39f3793c7"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b2d225d4-63c1-43ca-8258-12d6b77cb0b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""795f3485-62b5-4ced-9f90-18c7ea3c824a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""020fd66f-b2ce-46a4-b654-7be4514235ae"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TakingObject"",
                    ""type"": ""Button"",
                    ""id"": ""91f39319-04c4-4cbe-8920-35b053849df7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""426b856f-423b-4a91-8f03-1117948715a6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e20b035d-3d7c-4960-b332-d493b6aa84de"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""096dfa4b-76f1-446c-9373-ab17944cf089"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""33149bf8-ea91-47a4-b507-7bbac11f8125"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""921b2996-238e-4bfa-b06f-bdc9aa572e14"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8c0999d9-57cf-4e95-9ae9-b3cdfb313ab3"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""231bff13-1246-4005-98bf-cc03c92dbf9d"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73af2713-d0c8-41dd-997f-071402dd1916"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakingObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_HorizontalMovement = m_Movement.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_Movement_MouseX = m_Movement.FindAction("MouseX", throwIfNotFound: true);
        m_Movement_MouseY = m_Movement.FindAction("MouseY", throwIfNotFound: true);
        m_Movement_TakingObject = m_Movement.FindAction("TakingObject", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_HorizontalMovement;
    private readonly InputAction m_Movement_MouseX;
    private readonly InputAction m_Movement_MouseY;
    private readonly InputAction m_Movement_TakingObject;
    public struct MovementActions
    {
        private @PlayerInput m_Wrapper;
        public MovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Movement_HorizontalMovement;
        public InputAction @MouseX => m_Wrapper.m_Movement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Movement_MouseY;
        public InputAction @TakingObject => m_Wrapper.m_Movement_TakingObject;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMovement;
                @MouseX.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
                @TakingObject.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnTakingObject;
                @TakingObject.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnTakingObject;
                @TakingObject.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnTakingObject;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @TakingObject.started += instance.OnTakingObject;
                @TakingObject.performed += instance.OnTakingObject;
                @TakingObject.canceled += instance.OnTakingObject;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnTakingObject(InputAction.CallbackContext context);
    }
}
