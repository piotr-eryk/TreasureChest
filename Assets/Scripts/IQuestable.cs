using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IQuestable
{
    Action OnInteract { get; set; }
}
