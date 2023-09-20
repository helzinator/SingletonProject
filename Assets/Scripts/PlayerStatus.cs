using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatus : MonoBehaviour
{
    //Singleton pattern 
    [SerializeField] private TextMeshProUGUI textmesh;
    private float Score;
    public static PlayerStatus Instance; 
    [ContextMenu("Singleton")]
    void Singleton()
    {
        if(Instance is null)
        {
            Instance = this;
            return;
        }
        Destroy(this);
    }

    public void ScoreChange(float amount)
    {
        Score += amount;
        textmesh.text = $"Score={Score}";
    }
}
