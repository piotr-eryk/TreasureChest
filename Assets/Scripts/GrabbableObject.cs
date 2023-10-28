using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour, IGrabbable
{
    [SerializeField]
    private float grabbingDistance = 2f;

    public void GrabObject()
    {
        gameObject.SetActive(false);//back to pool
    }
}
