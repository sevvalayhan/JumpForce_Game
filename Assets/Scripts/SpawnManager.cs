using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    PlayerController playerController;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1, 2);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }



    void SpawnObstacle()
    {

        if (playerController.gameOver == true)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        }
    }
}
