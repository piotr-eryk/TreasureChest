using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GrabbableObject : MonoBehaviour, IGrabbable
{
    public Action <GameObject> OnInteract { get; set; }

    public virtual void Interact(GameObject interactedObject)
    {
        OnInteract?.Invoke(interactedObject);
    }
}
