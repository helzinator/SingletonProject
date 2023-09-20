using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] private float scoreAmount;
    [ContextMenu("HAHAHAHAH")]

    void OnDestroy()=> PlayerStatus.Instance.ScoreChange(scoreAmount);        
}
