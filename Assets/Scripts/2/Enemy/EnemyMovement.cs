using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    NavMeshAgent nav;
    PlayerHealth playerHealth;
    EnemyHealth hp;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        hp = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.currentHealth > 0 && hp.currentHealth > 0)
        {
            nav.SetDestination(player.position);
        }
        else
        {
            nav.enabled = false;
        }


    }
}
