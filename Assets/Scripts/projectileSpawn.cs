using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileSpawn : MonoBehaviour
{
    public GameObject enemyProjectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(enemyProjectile, transform.position, Quaternion.identity);
    }
}
