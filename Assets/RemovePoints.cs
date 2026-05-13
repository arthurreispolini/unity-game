using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePoints : MonoBehaviour
{
    public LixoSpawnerController lixoSpawnerController;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lixo"))
        {
            collision.gameObject.tag = "Untagged";

            Destroy(collision.gameObject);

            lixoSpawnerController.AddToPoints(-1);
        }
    }
}