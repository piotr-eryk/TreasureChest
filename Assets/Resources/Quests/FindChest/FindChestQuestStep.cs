using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindChestQuestStep : QuestStep
{
    private bool chestFound = false;

    private void OnEnable()
    {
        GameEventsManager.instance.questEvents.onChestCollected += ChestCollected;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.questEvents.onChestCollected -= ChestCollected;
    }

    private void ChestCollected()
    {
        FinishQuestStep();
    }
}
