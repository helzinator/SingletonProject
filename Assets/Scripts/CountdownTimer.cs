using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    // Start is called before the first frame update
    float currentTime;
    float startTime;
    [SerializeField] TextMeshProUGUI countdown;


    private void Start()
    {
        currentTime = startTime;
    }

    private void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countdown.text = $"{currentTime}"; 
    }
}
