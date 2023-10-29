using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest
{
    public QuestInfo questInfo;
    public QuestState questState;
    private int currentQuestStepIndex;

    public Quest(QuestInfo questInfo)
    {
        this.questInfo = questInfo;
        this.currentQuestStepIndex = 0;
        this.questState = QuestState.CantStart;
    }

    public void MoveToNextStep()
    {
        currentQuestStepIndex++;
    }

    public bool IsStepExist()
    {
        return (currentQuestStepIndex < questInfo.questSteps.Count);
    }

    public void CreateQuestStep(Transform parentTransform)
    {
        GameObject questStepPrefab = GetQuestStep();
        if (questStepPrefab != null)
        {
            QuestStep questStep = Object.Instantiate(questStepPrefab, parentTransform)
    .GetComponent<QuestStep>();
            questStep.InitializeQuestStep(questInfo.id);//maybe pooling
        }
    }

    private GameObject GetQuestStep()
    {
        GameObject questStep = null;
        if (IsStepExist())
        {
            questStep = questInfo.questSteps[currentQuestStepIndex];
        }
        else
        {
            Debug.LogError("Step index out of range");
        }
        return questStep;
    }
}