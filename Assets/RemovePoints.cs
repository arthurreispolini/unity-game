using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePoints : MonoBehaviour
{
    public LixoSpawnerController lixoSpawnerController;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lixo"))
        {
            audioSource.PlayOneShot(audioSource.clip);

            collision.gameObject.tag = "Untagged";

            Destroy(collision.gameObject);

            lixoSpawnerController.AddToPoints(-1);
        }
    }
}