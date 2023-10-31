using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IGrabbable
{
    Action <GameObject> OnInteract { get; set; }
}
