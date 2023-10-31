using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private float grabbingDistance = 2f;
    [SerializeField]
    private Camera playerCamera;

    private void Awake()
    {
        GameEventsManager.instance.inputEvents.onInteractPressed += InteractWithObject;
    }

    public void InteractWithObject()
    {
        if (Physics.Raycast(
            transform.position,
            playerCamera.transform.forward,
            out RaycastHit hit,
            grabbingDistance) && hit.transform.GetComponent<GrabbableObject>())

        {
            var interactedObject = hit.transform.GetComponent<GrabbableObject>();
            interactedObject.Interact(interactedObject.gameObject);
        }

    }
}
