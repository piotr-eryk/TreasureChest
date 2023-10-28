using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour, IGrabbable
{
    public void GrabObject()
    {
        gameObject.SetActive(false);//back to pool
    }
}
