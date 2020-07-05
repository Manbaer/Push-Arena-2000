using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject goCreate;

    [SerializeField]
    float fTimeIntervals;

    [SerializeField]
    UnityEngine.Vector3 spawnPosition;

    float timerForSpawning = 0 ;

    // Start is called before the first frame update
    void Start()
    {
        timerForSpawning = fTimeIntervals;
    }

    // Update is called once per frame
    void Update()
    {
        timerForSpawning -= Time.deltaTime; 
        if (timerForSpawning <= 0)
        {
            timerForSpawning = fTimeIntervals;

            UnityEngine.Vector3 v3SpawnPos = transform.position;
            v3SpawnPos += UnityEngine.Vector3.right * spawnPosition.x * (Random.value - 0.5f);
            v3SpawnPos += UnityEngine.Vector3.forward * spawnPosition.z * (Random.value - 0.5f);
            v3SpawnPos += UnityEngine.Vector3.up * spawnPosition.y * (Random.value - 0.5f);

            Instantiate(goCreate, v3SpawnPos, UnityEngine.Quaternion.identity);
        }
    }
}
