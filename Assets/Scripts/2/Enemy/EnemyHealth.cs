using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public int startHealth = 100;
    public int currentHealth;
    public AudioClip deathClip;
    public float sinkSpeed = 2.5f;
    Animator anim;
    AudioSource enemyAudio;
    bool isDead;
    bool isSinking;
    ParticleSystem hitparticle;
    CapsuleCollider capsuleCollider;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
        hitparticle = GetComponent<ParticleSystem>();
        currentHealth = startHealth;
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSinking)
        {
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        }
    }
    public void takeDamage(int amount, Vector3 hitpoint)
    {
        if (isDead)
            return;
        currentHealth -= amount;
        hitparticle.Play();
        enemyAudio.Play();
        if (currentHealth <= 0)
        {
            dealth();

        }
    }
    public void dealth()
    {
        isDead = true;
        anim.SetTrigger("Dead");
        enemyAudio.clip = deathClip;
        enemyAudio.Play();

    }
    public void StartSinking()
    {
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        isSinking = true;
        Destroy(gameObject, 2f);
        Scoremanager.score += 1;
    }
}