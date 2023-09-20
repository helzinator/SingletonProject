using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI attemptsText;
    public int Score;
    public int Attempts;
    public GameObject EnemyCount;

    private void Awake()
    {
        EnemyCount = GameObject.FindGameObjectWithTag ("EnemyFlock");
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementScore()
    { 
        Debug.Log("You gained one point!");
        Score++;
        scoreText.text = $"Score={Score}";
        if(EnemyCount.transform.childCount < 0)
        {
            Debug.Log("On to the next level");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void IncrementAttempts()
    {
        Debug.Log(Attempts);
        Attempts++;
        attemptsText.text = $"Attempts={Attempts}";
        SceneManager.LoadScene("LoseMenu");
    }
}
