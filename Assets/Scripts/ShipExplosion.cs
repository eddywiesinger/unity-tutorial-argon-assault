using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipExplosion : MonoBehaviour
{
    [Header("Ship Fragments")]
    [SerializeField] GameObject[] shipFragments;
    [Header("Particle Effect")]
    [SerializeField] ParticleSystem explosionVFX;
    [Header("Explosion Sound Effect")]
    [SerializeField] AudioClip explosionSFX;

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
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.volume = 0.5f;
        audioSource.PlayOneShot(explosionSFX);
    }
}
