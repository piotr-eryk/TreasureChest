using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Quest
{
    public QuestInfo questInfo;
    public QuestState questState;
    private int currentQuestStepIndex;

    public ObjectPool<GameObject> questStepPool;

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
            questStepPool = new ObjectPool<GameObject>(createFunc: () => Object.Instantiate(questStepPrefab, parentTransform),
actionOnGet: (obj) => obj.SetActive(true), actionOnRelease: (obj) => obj.SetActive(false), collectionCheck: false);

            QuestStep questStep = questStepPool.Get().GetComponent<QuestStep>();
            questStep.InitializeQuestStep(questInfo.id);
            GameEventsManager.instance.questEvents.onFinishStep += ReturnToPool;
        }
    }

    private void ReturnToPool(QuestStep questStep)
    {
        GameEventsManager.instance.questEvents.onFinishStep -= ReturnToPool;
        questStepPool.Release(questStep.gameObject);
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