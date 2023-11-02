using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestInfo", menuName = "ScriptableObjects/QuestInfo", order = 1)]
public class QuestInfo : ScriptableObject
{
    [field: SerializeField]
    public string id { get; private set; }

    public List<QuestInfo> questRequirements;
    public int scoreRequirement;
    public List<GameObject> questSteps;
    public int pointsReward;
}
