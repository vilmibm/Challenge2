using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float spawnIntervalMinimum = 3.0f;
    private float spawnIntervalMaximum = 3.0f;


    private int ballIx;

    void Update() {
        if (!IsInvoking("SpawnRandomBall")) {
            Invoke("SpawnRandomBall", Random.Range(spawnIntervalMinimum, spawnIntervalMaximum));
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        ballIx = Random.Range(0, 3);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIx], spawnPos, ballPrefabs[ballIx].transform.rotation);
    }

}
