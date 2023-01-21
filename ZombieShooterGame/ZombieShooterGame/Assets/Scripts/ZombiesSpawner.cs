using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesSpawner : MonoBehaviour
{
    public Transform topSpawner;
    public Transform bottomSpawner;
    public Transform leftSpawner;
    public Transform rightSpawner;
    public GameObject zombiePrefab;

    private int spawnPosition;


    private void PositionZombie()
    {
        spawnPosition = Random.Range(1, 4);

        if(spawnPosition == 1)
        zombiePrefab.transform.position = new Vector3();
        
    }
}
