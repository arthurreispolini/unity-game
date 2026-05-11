using System.Collections;
using UnityEngine;

public class LixoSpawnerController : MonoBehaviour
{
    public float maximumX;

    public float fixedY;

    public float fixedZ;

    public float timer;

    public GameObject Lixo;

    public int MaxPoints;

    public int points = 0;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

   IEnumerator SpawnRoutine()
{
    while (true)
    {
        Instantiate(
            Lixo,
            new Vector3(
                Random.Range(-maximumX, maximumX + 1),
                fixedY,
                fixedZ
            ),
            Quaternion.identity
        );

        yield return new WaitForSeconds(timer);
    }
}

    void Update()
    {

    }
}