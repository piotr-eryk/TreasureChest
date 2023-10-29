using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableBox : QuestableObject
{
    [SerializeField]
    private int pointsForChest = 5;
    [SerializeField] 
    private QuestPoint questPoint;

    private void CollectChest()
    {
        GameEventsManager.instance.questEvents.PointsReceived(pointsForChest);
        Destroy(gameObject);
    }

    public override void Interact()
    {
        base.Interact();
        CollectChest();
    }
}
