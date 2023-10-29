using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPoint : MonoBehaviour
{
    [Header("Quest")]
    [SerializeField] 
    private QuestInfo questInfo;
    [SerializeField] 
    private QuestableObject questableObject;

    [Header("Config")]
    [SerializeField] 
    private bool startPoint = true;
    [SerializeField] 
    private bool finishPoint = true;

    private string questId;
    private QuestState currentQuestState;

    private void Awake()
    {
        questId = questInfo.id;
    }

    private void OnEnable()
    {
        GameEventsManager.instance.questEvents.onQuestStateChange += QuestStateChange;
        questableObject.OnInteract += ChangeQuestState;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.questEvents.onQuestStateChange -= QuestStateChange;
        questableObject.OnInteract -= ChangeQuestState;
    }

    public void ChangeQuestState()
    {
        if (currentQuestState.Equals(QuestState.CanStart) && startPoint)
        {
            GameEventsManager.instance.questEvents.StartQuest(questId);
        }
        else if (currentQuestState.Equals(QuestState.CanFinish) && finishPoint)
        {
            GameEventsManager.instance.questEvents.FinishQuest(questId);
        }
    }

    private void QuestStateChange(Quest quest)
    {
        if (quest.questInfo.id.Equals(questId))
        {
            currentQuestState = quest.questState;
        }
    }
}