using System;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

#nullable enable

namespace ForbiddenClient.Modules
{
    public class EnableDisableListener : MonoBehaviour
    {

        [method: HideFromIl2Cpp]
        public event Action? OnEnabled;

        [method: HideFromIl2Cpp]
        public event Action? OnDisabled;

        [method: HideFromIl2Cpp]
        public event Action? OnUpdate;

        public EnableDisableListener(IntPtr obj0) : base(obj0)
        {
        }

        private void OnEnable()
        {
            OnEnabled?.Invoke();
        }

        private void OnDisable()
        {
            OnDisabled?.Invoke();
        }

        private void Update()
        {
            OnUpdate?.Invoke();
        }
    }
}