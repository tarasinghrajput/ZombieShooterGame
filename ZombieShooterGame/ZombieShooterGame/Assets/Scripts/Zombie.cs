using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float zombieSpeed = 1.5f;

    private void Awake() {
        player = GameObject.FindWithTag("Player");
    }

    void Update() 
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, zombieSpeed * Time.deltaTime);
        transform.up = player.transform.position - transform.position;
    }
}
