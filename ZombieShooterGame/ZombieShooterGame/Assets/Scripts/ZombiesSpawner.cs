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


    void Start() 
    {
        // spawnPosition = Random.Range(1, 4);
        randomX = Random.Range(12, -12);
        randomY = Random.Range(4, -4);
        StartCoroutine(PositionZombie());
    }


    IEnumerator PositionZombie()
    {
        while (true)
        {
            
        yield return new WaitForSeconds(2f);
        if(spawnPosition == 1){
        var spawnedZombie =  Instantiate(zombiePrefab, transform.position, Quaternion.identity);
        spawnedZombie.transform.position = new Vector3(-12f, randomY, 0f);

        }
        }
    }
}
