using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject hitVFX;
    [SerializeField] GameObject deathVFX;
    [SerializeField] Transform parentGameObject;

    [SerializeField] int hitPoints = 3;
    [SerializeField] int hitScore = 5;

    ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        GameObject spawnAtRuntime = GameObject.FindGameObjectWithTag("SpawnAtRuntime");
        parentGameObject = spawnAtRuntime.transform;
        AddRigidbody();
    }

    void AddRigidbody()
    {
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        GameObject vfx = Instantiate(hitVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parentGameObject;
        hitPoints -= 1;
        if (hitPoints < 1) {
            KillEnemy();
        }
    }

    void KillEnemy()
    {
        scoreBoard.IncreaseScore(hitScore);
        GameObject vfx = Instantiate(deathVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parentGameObject;
        Destroy(gameObject);
    }

}
