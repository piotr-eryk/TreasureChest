using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEvents
{
    public event Action onInteractPressed;
    public void InteractPressed()
    {
        onInteractPressed?.Invoke();
    }
}