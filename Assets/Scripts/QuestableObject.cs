using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestableObject : MonoBehaviour, IQuestable
{
    public Action OnInteract { get; set; }

    public virtual void Interact()
    {
        OnInteract?.Invoke();
    }
}
