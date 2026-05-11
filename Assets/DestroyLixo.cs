using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLixo : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.CompareTag("Lixo"))
        {
            Destroy(collision.gameObject);
        }
  }
}
