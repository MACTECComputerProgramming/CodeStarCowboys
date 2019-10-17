using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{

    public GameObject targetPrefab;
    public Transform[] spawnPoints;

    public float minDelay = .1f;
    public float maxDelay = 1f;
    public float timeBDestroy;


    void Start()
    {
        StartCoroutine(SpawnTargets());
    }

    
    IEnumerator SpawnTargets()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(1f);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedTarget = Instantiate(targetPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedTarget, timeBDestroy);
        }
    }
}
