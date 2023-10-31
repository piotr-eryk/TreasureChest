using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBox : GrabbableObject
{
    [SerializeField]
    private int pointsForChest = 5;

    private void CollectChest()
    {
        GameEventsManager.instance.questEvents.PointsReceived(pointsForChest);
    }

    public override void Interact(GameObject interactedObject)
    {
        base.Interact(interactedObject);
        CollectChest();
    }
}
