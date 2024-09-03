using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PulpitSpawner : MonoBehaviour
{
    public GameObject pulpitPrefab;
    public float minPulpitDestroyTime = 4f;
    public float maxPulpitDestroyTime = 5f;
    public float pulpitSpawnTime = 2.5f;
    public ScoreManager scoreManager;

    private Vector3 lastPulpitPosition;

    void Start()
    {
        lastPulpitPosition = transform.position;
        StartCoroutine(SpawnPulpit());
    }

    IEnumerator SpawnPulpit()
    {
        while (true)
        {
            yield return new WaitForSeconds(pulpitSpawnTime);

            Vector3 newPulpitPosition = GetNewPulpitPosition();
            GameObject newPulpit = Instantiate(pulpitPrefab, newPulpitPosition, Quaternion.identity);

            float destroyTime = Random.Range(minPulpitDestroyTime, maxPulpitDestroyTime);
            Destroy(newPulpit, destroyTime);

            lastPulpitPosition = newPulpitPosition;
        }
    }

    Vector3 GetNewPulpitPosition()
    {
        Vector3 newPosition = lastPulpitPosition;
        int randomDirection = Random.Range(0, 4);

        switch (randomDirection)
        {
            case 0: newPosition += new Vector3(3, 0, 0); break;
            case 1: newPosition += new Vector3(-3, 0, 0); break;
            case 2: newPosition += new Vector3(0, 0, 3); break;
            case 3: newPosition += new Vector3(0, 0, -3); break;
        }

        return newPosition;
    }

    public void OnPulpitDestroyed()
    {
        scoreManager.IncreaseScore(1); // Increase score by 1 (or any amount you prefer)
    }
}



