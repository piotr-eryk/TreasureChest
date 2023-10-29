using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private float grabbingDistance = 2f;
    [SerializeField]
    private Camera playerCamera;

    private GrabbableObject grabbableObject;

    public void TakeObject()
    {
        if (Physics.Raycast(
            transform.position,
            playerCamera.transform.forward,
            out RaycastHit hit,
            grabbingDistance) && hit.transform.GetComponent<GrabbableObject>())

        {
            grabbableObject = hit.transform.GetComponent<GrabbableObject>();
            grabbableObject?.OnInteract();
        }

    }
}
