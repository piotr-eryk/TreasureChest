using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
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

        movementAction.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();

        movementAction.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        movementAction.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();

        movementAction.TakingObject.performed += _ => playerAction.TakeObject();
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
}
