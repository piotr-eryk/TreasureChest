using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private Dictionary<string, Quest> questMap;

    private int currentPlayerScore;

    private void Awake()
    {
        questMap = CreateQuestMap();
    }

    private void OnEnable()
    {
        StartCoroutine(InitializeWithDelay());
    }

    private IEnumerator InitializeWithDelay()
    {
        yield return null;
        GameEventsManager.instance.questEvents.onStartQuest += StartQuest;
        GameEventsManager.instance.questEvents.onAdvanceQuest += AdvanceQuest;
        GameEventsManager.instance.questEvents.onFinishQuest += FinishQuest;
        GameEventsManager.instance.questEvents.onPointsReceived += PointsChange;
    }

    private void OnDisable()
    {
        GameEventsManager.instance.questEvents.onStartQuest -= StartQuest;
        GameEventsManager.instance.questEvents.onAdvanceQuest -= AdvanceQuest;
        GameEventsManager.instance.questEvents.onFinishQuest -= FinishQuest;
        GameEventsManager.instance.questEvents.onPointsReceived -= PointsChange;
    }

    private void Start()
    {
        foreach (Quest quest in questMap.Values)
        {
            if (quest.questState == QuestState.InProgress)
            {
                quest.CreateQuestStep(transform);
            }
            GameEventsManager.instance.questEvents.QuestStateChange(quest);
        }
    }

    private void Update()
    {
        foreach (Quest quest in questMap.Values)
        {
            if (quest.questState == QuestState.CantStart && IsRequirementMet(quest))
            {
                ChangeQuestState(quest.questInfo.id, QuestState.CanStart);
            }
        }
    }

    private void ChangeQuestState(string id, QuestState state)
    {
        Quest quest = GetQuestById(id);
        quest.questState = state;
        GameEventsManager.instance.questEvents.QuestStateChange(quest);
    }

    private void PointsChange(int points)
    {
        currentPlayerScore += points;
    }

    private bool IsRequirementMet(Quest quest)
    {
        bool meetsRequirements = true;

        if (currentPlayerScore < quest.questInfo.scoreRequirement)
        {
            meetsRequirements = false;
        }

        foreach (QuestInfo prerequisiteQuestInfo in quest.questInfo.questRequirements)
        {
            if (GetQuestById(prerequisiteQuestInfo.id).questState != QuestState.Finished)
            {
                meetsRequirements = false;
            }
        }
        return meetsRequirements;
    }

    private void StartQuest(string id)
    {
        Quest quest = GetQuestById(id);
        quest.CreateQuestStep(transform);
        ChangeQuestState(quest.questInfo.id, QuestState.InProgress);
    }

    private void AdvanceQuest(string id)
    {
        Quest quest = GetQuestById(id);
        quest.MoveToNextStep();

        if (quest.IsStepExist())
        {
            quest.CreateQuestStep(this.transform);
        }
        else
        {
            ChangeQuestState(quest.questInfo.id, QuestState.CanFinish);
        }
    }

    private void FinishQuest(string id)
    {
        Quest quest = GetQuestById(id);
        ClaimRewards(quest);
        ChangeQuestState(quest.questInfo.id, QuestState.Finished);
    }

    private void ClaimRewards(Quest quest)
    {
        GameEventsManager.instance.questEvents.PointsReceived(quest.questInfo.pointsReward);
    }

    private Dictionary<string, Quest> CreateQuestMap()
    {
        QuestInfo[] allQuests = Resources.LoadAll<QuestInfo>("Quests");
        Dictionary<string, Quest> idToQuestMap = new Dictionary<string, Quest>();
        foreach (QuestInfo questInfo in allQuests)
        {
            if (idToQuestMap.ContainsKey(questInfo.id))
            {
                Debug.LogWarning("Duplicate ID found when creating quest map: " + questInfo.id);
            }
            idToQuestMap.Add(questInfo.id, new Quest(questInfo));
        }
        return idToQuestMap;
    }

    private Quest GetQuestById(string id)
    {
        Quest quest = questMap[id];
        if (quest == null)
        {
            Debug.LogError("ID not found in the Quest Map: " + id);
        }
        return quest;
    }
}
