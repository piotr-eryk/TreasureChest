using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableBox : GrabbableObject
{
    [Header("Config")]
    [SerializeField] private float respawnTimeSeconds = 8;
    [SerializeField] private int goldGained = 1;

    private void CollectChest()
    {
      //  GameEventsManager.instance.goldEvents.GoldGained(goldGained);
      //  GameEventsManager.instance.miscEvents.CoinCollected();
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            CollectChest();
        }
    }
}
