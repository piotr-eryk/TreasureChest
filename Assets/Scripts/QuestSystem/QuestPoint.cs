using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class QuestPoint : MonoBehaviour
{
    [Header("Quest")]
    [SerializeField] 
    private QuestInfo questInfo;
    [SerializeField] 
    private GrabbableObject questableObject;

    [Header("Config")]
    [SerializeField] 
    private bool startPoint = true;
    [SerializeField] 
    private bool finishPoint = true;
    [SerializeField]
    private bool destroyAfterInteract = true;

    private string questId;
    private QuestState currentQuestState;

    private void Awake()
    {
        questId = questInfo.id;
    }

    private void OnEnable()
    {
        GameEventsManager.instance.questEvents.onQuestStateChange += QuestStateChange;
        questableObject.OnInteract += StartOrFinishQuest;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.questEvents.onQuestStateChange -= QuestStateChange;
        questableObject.OnInteract -= StartOrFinishQuest;
    }

    public void StartOrFinishQuest(GameObject interactedObject)
    {
        if (currentQuestState.Equals(QuestState.CanStart) && startPoint)
        {
            GameEventsManager.instance.questEvents.StartQuest(questId);
        }
        else if (currentQuestState.Equals(QuestState.CanFinish) && finishPoint)
        {
            GameEventsManager.instance.questEvents.FinishQuest(questId);
        }

        interactedObject.SetActive(!destroyAfterInteract);
    }

    private void QuestStateChange(Quest quest)
    {
        if (quest.questInfo.id.Equals(questId))
        {
            currentQuestState = quest.questState;
        }
    }
}