using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerBridge : MonoBehaviour
{
    [SerializeField]
    private PlayerMotor playerMotor;
    [SerializeField]
    private PlayerLook playerLook;
    [SerializeField]
    private PlayerAction playerAction;

    private PlayerInput playerInput;
    private PlayerInput.MovementActions movementAction;
    private Vector2 horizontalInput;
    private Vector2 mouseInput;

    private void Awake()
    {
        playerInput = new PlayerInput();
        movementAction = playerInput.Movement;

        movementAction.HorizontalMovement.performed += ReadMovementValue;

        movementAction.MouseX.performed += ReadMouseXValue;
        movementAction.MouseY.performed += ReadMouseYValue;

        movementAction.TakingObject.performed += InteractPressed;
    }

    private void Update()
    {
        playerMotor.ReceiveInput(horizontalInput);
        playerLook.ReceiveInput(mouseInput);
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    private void OnDestroy()
    {
        movementAction.HorizontalMovement.performed -= ReadMovementValue;

        movementAction.MouseX.performed -= ReadMouseXValue;
        movementAction.MouseY.performed -= ReadMouseYValue;

        movementAction.TakingObject.performed -= InteractPressed;
    }

    public void InteractPressed(InputAction.CallbackContext _)
    {
        GameEventsManager.instance.inputEvents.InteractPressed();
    }

    public void ReadMovementValue(InputAction.CallbackContext ctx)
    {
        horizontalInput = ctx.ReadValue<Vector2>();
    }

    public void ReadMouseXValue(InputAction.CallbackContext ctx)
    {
        mouseInput.x = ctx.ReadValue<float>();
    }

    public void ReadMouseYValue(InputAction.CallbackContext ctx)
    {
        mouseInput.y = ctx.ReadValue<float>();
    }
}
