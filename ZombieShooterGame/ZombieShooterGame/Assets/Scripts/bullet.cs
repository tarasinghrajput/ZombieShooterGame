using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // public float life = 3;

    // private void Awake() 
    // {
    //     Destroy(gameObject);
    // }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
