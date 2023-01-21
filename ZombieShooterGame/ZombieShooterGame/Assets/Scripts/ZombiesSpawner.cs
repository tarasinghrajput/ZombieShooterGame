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

    private int spawnPosition = 1;
    private float randomX;
    private float randomY;
    private Vector3 tempPosX;
    private Vector3 tempPosY;


    void Start() 
    {
        // spawnPosition = Random.Range(1, 4);
        // randomX = Random.Range(12, -12);
        // randomY = Random.Range(4, -4);
        StartCoroutine(PositionZombie());
    }


    IEnumerator PositionZombie()
    {
        while (true)
        {
            
        yield return new WaitForSeconds(2f);
        SpawnZombie();
        switch (spawnPosition)
        {
            case 1:
            Instantiate(zombiePrefab, tempPosX, Quaternion.identity);
            break;

            default:
            break;
        }
        // spawnedZombie.transform.position = new Vector3(-12f, randomY, 0f);
        void SpawnZombie()
        {
            randomX = Random.Range(12, -12);
            randomY = Random.Range(4, -4);
            tempPosX = new Vector3(randomX, topSpawner.position.y, 0);
            tempPosX = new Vector3(topSpawner.position.x, randomY, 0);
        }
        }
    }
}
