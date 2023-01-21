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
        
        // randomX = Random.Range(12, -12);
        // randomY = Random.Range(4, -4);
        StartCoroutine(PositionZombie());
    }


    IEnumerator PositionZombie()
    {
        while (true)
        {
            spawnPosition = Random.Range(1, 4);
            
            yield return new WaitForSeconds(2f);
            switch (spawnPosition)
            {
                case 1:
                SpawnZombieAtTop();
                Instantiate(zombiePrefab, tempPosY, Quaternion.identity);
                break;
            
                case 2:
                SpawnZombieAtBottom();
                Instantiate(zombiePrefab, tempPosY, Quaternion.identity);
                break;
            
                case 3:
                SpawnZombieAtLeft();
                Instantiate(zombiePrefab, tempPosX, Quaternion.identity);
                break;

                default:
                SpawnZombieAtRight();
                Instantiate(zombiePrefab, tempPosX, Quaternion.identity);
                break;
            }
            // spawnedZombie.transform.position = new Vector3(-12f, randomY, 0f);
            void SpawnZombieAtTop()
            {
                randomX = Random.Range(12, -12);
                tempPosY = new Vector3(randomX, topSpawner.position.y, 0);
            }
            void SpawnZombieAtBottom()
            {
                randomX = Random.Range(12, -12);
                tempPosY = new Vector3(randomX, bottomSpawner.position.y, 0);
            }
            void SpawnZombieAtLeft()
            {
                randomY = Random.Range(4, -4);
                tempPosX = new Vector3(leftSpawner.position.x, randomY, 0);
            }
            void SpawnZombieAtRight()
            {
                randomY = Random.Range(4, -4);
                tempPosX = new Vector3(rightSpawner.position.x, randomY, 0);
            }
        }
    }
}
