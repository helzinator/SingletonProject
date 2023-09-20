using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            Singleton.Instance.IncrementAttempts();
        }
        else if (collision.collider.gameObject.tag == "EnemyProjectile")
        {
            Debug.Log("I've hit the player");
            Singleton.Instance.IncrementAttempts();
        }
    }
}
