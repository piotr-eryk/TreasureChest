using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGrabbableBox : GrabbableObject
{
    private void CollectBox()
    {
        GameEventsManager.instance.questEvents.ChestCollected();
       // Destroy(gameObject);
    }

    public override void Interact()
    {
        CollectBox();
        base.Interact();

    }
}
