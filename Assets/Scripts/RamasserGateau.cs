using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasserGateau : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float floatAmplitude = 0.5f;
    public float floatSpeed = 2f;
    public GameObject pickUpEffect;
    public AudioClip collectSound;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // rotation autour de l'axe Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // effet de flottement
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().GateauFinal();

            if (collectSound != null)
            {
                Debug.Log("Lecture du son...");
                FindObjectOfType<MusicManager>().PlaySoundEffect(collectSound);
            }
            else
            {
                Debug.LogWarning("Le son collectSound est manquant !");
            }

            Instantiate(pickUpEffect, transform.position, Quaternion.identity); // quaternion.identity = pas de rotation/réinitialisation de la rotation

            Destroy(gameObject);
        }
    }
}