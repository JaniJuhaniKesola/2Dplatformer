//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Config/InputActions.inputactions
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

namespace Platformer
{
    public partial class @Inputs: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Inputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""New action map"",
            ""id"": ""b93dfd50-204e-4e78-b43c-5308af271df1"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""adf8bd67-2823-4ec6-ba2d-7b3cfd48ce86"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fb0fdd75-3e3f-4a45-9f20-3441a3a939d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""da41ef11-2da7-49cf-9b86-8c687a163c9f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c344ce74-a9c3-4856-9570-02815d74c1f3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8ffd75a-e7f5-45f8-852e-5e8f76bb3d85"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""New action map1"",
            ""id"": ""b17c8be8-71ae-4df2-8412-82d0109fdcdc"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""cd07e69a-cb00-420c-a259-75129db48815"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1ffe0206-5bc6-40ac-b3c1-dbc6684e627f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // New action map
            m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
            m_Newactionmap_Move = m_Newactionmap.FindAction("Move", throwIfNotFound: true);
            m_Newactionmap_Jump = m_Newactionmap.FindAction("Jump", throwIfNotFound: true);
            // New action map1
            m_Newactionmap1 = asset.FindActionMap("New action map1", throwIfNotFound: true);
            m_Newactionmap1_Newaction = m_Newactionmap1.FindAction("New action", throwIfNotFound: true);
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

        // New action map
        private readonly InputActionMap m_Newactionmap;
        private List<INewactionmapActions> m_NewactionmapActionsCallbackInterfaces = new List<INewactionmapActions>();
        private readonly InputAction m_Newactionmap_Move;
        private readonly InputAction m_Newactionmap_Jump;
        public struct NewactionmapActions
        {
            private @Inputs m_Wrapper;
            public NewactionmapActions(@Inputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Newactionmap_Move;
            public InputAction @Jump => m_Wrapper.m_Newactionmap_Jump;
            public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
            public void AddCallbacks(INewactionmapActions instance)
            {
                if (instance == null || m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }

            private void UnregisterCallbacks(INewactionmapActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
            }

            public void RemoveCallbacks(INewactionmapActions instance)
            {
                if (m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(INewactionmapActions instance)
            {
                foreach (var item in m_Wrapper.m_NewactionmapActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public NewactionmapActions @Newactionmap => new NewactionmapActions(this);

        // New action map1
        private readonly InputActionMap m_Newactionmap1;
        private List<INewactionmap1Actions> m_Newactionmap1ActionsCallbackInterfaces = new List<INewactionmap1Actions>();
        private readonly InputAction m_Newactionmap1_Newaction;
        public struct Newactionmap1Actions
        {
            private @Inputs m_Wrapper;
            public Newactionmap1Actions(@Inputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_Newactionmap1_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_Newactionmap1; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(Newactionmap1Actions set) { return set.Get(); }
            public void AddCallbacks(INewactionmap1Actions instance)
            {
                if (instance == null || m_Wrapper.m_Newactionmap1ActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_Newactionmap1ActionsCallbackInterfaces.Add(instance);
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }

            private void UnregisterCallbacks(INewactionmap1Actions instance)
            {
                @Newaction.started -= instance.OnNewaction;
                @Newaction.performed -= instance.OnNewaction;
                @Newaction.canceled -= instance.OnNewaction;
            }

            public void RemoveCallbacks(INewactionmap1Actions instance)
            {
                if (m_Wrapper.m_Newactionmap1ActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(INewactionmap1Actions instance)
            {
                foreach (var item in m_Wrapper.m_Newactionmap1ActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_Newactionmap1ActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public Newactionmap1Actions @Newactionmap1 => new Newactionmap1Actions(this);
        public interface INewactionmapActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
        public interface INewactionmap1Actions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
    }
}
