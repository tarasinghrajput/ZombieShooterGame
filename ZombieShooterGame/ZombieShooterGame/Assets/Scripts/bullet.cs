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
        Invoke("DestroyBullet", 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * 20f * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        // destroys the gameobject that the bullet clone collides with
        Destroy(collision.gameObject);
        // destroys the bullet clone
        Destroy(gameObject);
    }

    public void DestroyBullet() 
    {
       Destroy(this.gameObject);
    }
}
