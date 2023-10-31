using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGrabbableBox : GrabbableObject
{
    private void CollectBox()
    {
        GameEventsManager.instance.questEvents.ChestCollected();
    }

    public override void Interact(GameObject interactedObject)
    {
        CollectBox();
        base.Interact(interactedObject);

    }
}
