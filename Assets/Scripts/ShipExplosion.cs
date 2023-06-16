using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipExplosion : MonoBehaviour
{
    [Header("Ship Fragments")]
    [SerializeField] GameObject[] shipFragments;
    [Header("Particle Effect")]
    [SerializeField] ParticleSystem explosionVFX;

    private void Awake()
    {
        enabled = false;
    }

    private void OnEnable()
    {
        foreach (GameObject shipFragment in shipFragments)
        {
            shipFragment.GetComponent<FragmentExplosion>().enabled = true;
        }
        explosionVFX.Play();
    }
}
