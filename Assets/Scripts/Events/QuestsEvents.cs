using System;
using UnityEngine;

public class QuestsEvents
{
    public event Action<string> onStartQuest;
    public void StartQuest(string id)
    {
        onStartQuest?.Invoke(id);
    }

    public event Action<string> onAdvanceQuest;
    public void AdvanceQuest(string id)
    {
        onAdvanceQuest?.Invoke(id);
    }

    public event Action<string> onFinishQuest;
    public void FinishQuest(string id)
    {
        onFinishQuest?.Invoke(id);
    }

    public event Action<int> onPointsReceived;
    public void PointsReceived(int points)
    {
        onPointsReceived?.Invoke(points);
    }

    public event Action onChestCollected;
    public void ChestCollected()
    {
        onChestCollected?.Invoke();
    }

    public event Action<Quest> onQuestStateChange;
    public void QuestStateChange(Quest quest)
    {
        onQuestStateChange?.Invoke(quest);
    }
}
