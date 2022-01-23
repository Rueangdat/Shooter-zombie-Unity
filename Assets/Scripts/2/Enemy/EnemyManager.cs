using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHP;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnpoint;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawn()
    {
        if (playerHP.currentHealth <= 0)
        {
            return;
        }
        int spawnIndex = Random.Range(0, spawnpoint.Length);
        Instantiate(enemy, spawnpoint[spawnIndex].position, spawnpoint[spawnIndex].rotation);
    }
}
