// GENERATED AUTOMATICALLY FROM 'Assets/Custom Assets/Scenes/Car_NewInput/Profiles/Player_Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Controls"",
    ""maps"": [
        {
            ""name"": ""Vehicle Movement"",
            ""id"": ""34722019-bec9-4c83-a272-f3ab97e47861"",
            ""actions"": [
                {
                    ""name"": ""Car Movement"",
                    ""type"": ""Value"",
                    ""id"": ""26c5207b-b460-4bc8-b901-ca5f156d7118"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Hand Break"",
                    ""type"": ""Value"",
                    ""id"": ""180e09d7-4d3b-4a07-9d5b-775bacb74231"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9aa7e06a-6748-4edc-94ce-7aa271b463ac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Car Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""35d95a84-aaac-4cd3-87c9-0e205bfd3ddb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Car Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eed9c2d1-f713-42f6-abab-131a24835494"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Car Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f564031e-02b2-4d3d-bb9d-616ce6b5dbad"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Car Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0932a70-47f2-4aac-8f8c-ac317b6384d4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Car Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""31cf1f54-ced3-4b4e-a9c5-24140ab085ef"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Car Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0a577ad-b06e-482f-9ddc-92dcdaf1dfa7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hand Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c83c0e1e-e98f-4711-b6fe-cc9fd7fb85ce"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hand Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Vehicle Movement
        m_VehicleMovement = asset.FindActionMap("Vehicle Movement", throwIfNotFound: true);
        m_VehicleMovement_CarMovement = m_VehicleMovement.FindAction("Car Movement", throwIfNotFound: true);
        m_VehicleMovement_HandBreak = m_VehicleMovement.FindAction("Hand Break", throwIfNotFound: true);
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

    // Vehicle Movement
    private readonly InputActionMap m_VehicleMovement;
    private IVehicleMovementActions m_VehicleMovementActionsCallbackInterface;
    private readonly InputAction m_VehicleMovement_CarMovement;
    private readonly InputAction m_VehicleMovement_HandBreak;
    public struct VehicleMovementActions
    {
        private @Player_Controls m_Wrapper;
        public VehicleMovementActions(@Player_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CarMovement => m_Wrapper.m_VehicleMovement_CarMovement;
        public InputAction @HandBreak => m_Wrapper.m_VehicleMovement_HandBreak;
        public InputActionMap Get() { return m_Wrapper.m_VehicleMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleMovementActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleMovementActions instance)
        {
            if (m_Wrapper.m_VehicleMovementActionsCallbackInterface != null)
            {
                @CarMovement.started -= m_Wrapper.m_VehicleMovementActionsCallbackInterface.OnCarMovement;
                @CarMovement.performed -= m_Wrapper.m_VehicleMovementActionsCallbackInterface.OnCarMovement;
                @CarMovement.canceled -= m_Wrapper.m_VehicleMovementActionsCallbackInterface.OnCarMovement;
                @HandBreak.started -= m_Wrapper.m_VehicleMovementActionsCallbackInterface.OnHandBreak;
                @HandBreak.performed -= m_Wrapper.m_VehicleMovementActionsCallbackInterface.OnHandBreak;
                @HandBreak.canceled -= m_Wrapper.m_VehicleMovementActionsCallbackInterface.OnHandBreak;
            }
            m_Wrapper.m_VehicleMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CarMovement.started += instance.OnCarMovement;
                @CarMovement.performed += instance.OnCarMovement;
                @CarMovement.canceled += instance.OnCarMovement;
                @HandBreak.started += instance.OnHandBreak;
                @HandBreak.performed += instance.OnHandBreak;
                @HandBreak.canceled += instance.OnHandBreak;
            }
        }
    }
    public VehicleMovementActions @VehicleMovement => new VehicleMovementActions(this);
    public interface IVehicleMovementActions
    {
        void OnCarMovement(InputAction.CallbackContext context);
        void OnHandBreak(InputAction.CallbackContext context);
    }
}
