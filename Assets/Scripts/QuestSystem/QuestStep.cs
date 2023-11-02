using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public abstract class QuestStep : MonoBehaviour
{
    public Action<QuestStep> OnFinishStep { get; set; }

    private bool isFinished = false;
    private string questId;

    protected void FinishQuestStep()
    {
        if (!isFinished)
        {
            isFinished = true;
            GameEventsManager.instance.questEvents.AdvanceQuest(questId);
            GameEventsManager.instance.questEvents.FinishStep(this);
        }
    }

    public void InitializeQuestStep(string questId)
    {
        this.questId = questId;
    }
}
