using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameInputs
{
    public class InputController : MonoBehaviour
    {
        [Header("Inputs")]
        [SerializeField] private Vector2ChannelSO OnMoveChannel;
        [SerializeField] private Vector2ChannelSO OnGridMoveChannel;
        [SerializeField] private VoidChannelSO OnRollChannel;
        [SerializeField] private VoidChannelSO OnPauseChannel;
        [SerializeField] private BoolChannelSO OnActionChannel;
        private Vector2 previousGridInput = Vector2.zero;

        public void OnMove(InputAction.CallbackContext ctx)
        {
            OnMoveChannel.RaiseEvent(ctx.ReadValue<Vector2>());
        }

        public void OnGridMove(InputAction.CallbackContext ctx)
        {
            if (ctx.performed)
            {
                Vector2 ctxInput = ctx.ReadValue<Vector2>();
                OnGridMoveChannel.RaiseEvent(ctxInput);
            }

            if (ctx.canceled)
            {
                OnGridMoveChannel.RaiseEvent(Vector2.zero);
            }
            
        }

        public void OnRollInput(InputAction.CallbackContext ctx)
        {
            if (ctx.performed)
            {
                OnRollChannel.RaiseEvent();
            }
        }

        public void OnAction(InputAction.CallbackContext ctx)
        {
            if (ctx.performed)
            {
                OnActionChannel.RaiseEvent(true);
            }
            else if (ctx.canceled)
            {
                OnActionChannel.RaiseEvent(false);
            }
        }

        public void OnPauseMode(InputAction.CallbackContext ctx)
        {
            if (ctx.performed)
            {
                OnPauseChannel.RaiseEvent();
            }
        }
    }
}