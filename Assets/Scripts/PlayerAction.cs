using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private float grabbingDistance = 2f;
    [SerializeField]
    private Camera playerCamera;

    public void InteractWithObject()
    {
        if (Physics.Raycast(
            transform.position,
            playerCamera.transform.forward,
            out RaycastHit hit,
            grabbingDistance) && hit.transform.GetComponent<GrabbableObject>())

        {
            hit.transform.GetComponent<GrabbableObject>().Interact();
        }

    }
}
