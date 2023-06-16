using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentExplosion : MonoBehaviour
{
    [SerializeField] float fragmentsExplosionTranslationFactor = 3f;
    [SerializeField] float fragmentsExplosionRotationFactor = 2f;

    float xDtAngle, yDtAngle, zDtAngle;

    private void Awake()
    {
        enabled = false;
    }

    private void Start()
    {
        xDtAngle = Random.Range(0f, 1f) - 0.5f;
        xDtAngle = xDtAngle * fragmentsExplosionRotationFactor;
        yDtAngle = Random.Range(0f, 1f) - 0.5f;
        yDtAngle = yDtAngle * fragmentsExplosionRotationFactor;
        zDtAngle = Random.Range(0f, 1f) - 0.5f;
        zDtAngle = zDtAngle * fragmentsExplosionRotationFactor;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 normalizedVector = Vector3.Normalize(transform.localPosition);
        transform.localPosition += normalizedVector * Time.deltaTime * fragmentsExplosionTranslationFactor;

        // TODO: Modular Skript für jedes ShipFragment und hier nur starten
        Vector3 rot = new Vector3(
            transform.localEulerAngles.x + xDtAngle,
            transform.localEulerAngles.y + yDtAngle,
            transform.localEulerAngles.z + zDtAngle);
        transform.localEulerAngles = rot;
    }
}
