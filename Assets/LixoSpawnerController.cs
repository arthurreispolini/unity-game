using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LixoSpawnerController : MonoBehaviour
{
    public float maximumX;

    public float fixedY;

    public float fixedZ;

    public float timer;

    public GameObject Lixo;

    public int MaxPoints;

    public int points = 0;

    public TMP_Text pointsText;

    public TMP_Text victoryText;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(SpawnRoutine());
        victoryText.gameObject.SetActive(false);
    }

   IEnumerator SpawnRoutine()
{
    while (points<MaxPoints)
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
    victoryText.gameObject.SetActive(true);
}
 public void AddToPoints(int value)
    {
        points += value;
        pointsText.text = "Points: "+points.ToString();
    }
}