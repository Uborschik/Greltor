using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs : MonoBehaviour, Controls.IPlayerActions
{
    private Controls inputActions;

    public Vector2 MoveVector { get; private set; }
    public event Action OnLeftMouseButtonStarted;

    private void Awake()
    {
        inputActions = new Controls();
        inputActions.Player.SetCallbacks(this);
        inputActions.Player.Enable();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        //if (context.phase == InputActionPhase.Started)
        //{
            
        //}
        MoveVector = context.ReadValue<Vector2>();
    }

    public void OnLeftClick(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Started)
        {
            OnLeftMouseButtonStarted?.Invoke();
        }
    }
}
