using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int damagePershoot = 20;
    public float timeBullet = 0.15f;
    public float range = 100f;
    float timer;
    Ray shootRay;
    RaycastHit shoothit;
    int shootableMask;
    ParticleSystem gunparticle;
    LineRenderer gunLine;
    AudioSource gunAudio;
    Light gunLight;
    float effectDisplayTime = 0.2f;

    // Use this for initialization
    void Start()
    {
        shootableMask = LayerMask.GetMask("Shootable");
        gunparticle = GetComponent<ParticleSystem>();
        gunLine = GetComponent<LineRenderer>();
        gunAudio = GetComponent<AudioSource>();
        gunLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer >= timeBullet)
        {
            shoot();
        }
        if (timer >= timeBullet * effectDisplayTime)
        {
            disableEffect();
        }
    }
    void shoot()
    {
        timer = 0f;
        gunAudio.Play();
        gunLine.enabled = true;
        gunLight.enabled = true;
        gunparticle.Stop();
        gunparticle.Play();
        gunLine.SetPosition(0, transform.position);
        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;
        if (Physics.Raycast(shootRay, out shoothit, range, shootableMask))
        {
            EnemyHealth enemyHealth = shoothit.collider.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.takeDamage(damagePershoot, shoothit.point);
            }
            gunLine.SetPosition(1, shoothit.point);
        }



        else
        {
            gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }

    }
    void disableEffect()
    {
        gunLine.enabled = false;
        gunLight.enabled = false;
    }
}
