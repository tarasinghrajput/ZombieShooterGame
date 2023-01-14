using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float fireSpeed;
    public GameObject bullet;
    public Transform firePoint;
    // public Transform player;
    // // public float speed = 5.0f;
    // private bool touchStart = false;
    // private Vector2 pointA;
    // private Vector2 pointB;

    // public Transform rightInnerCircle;
    // public Transform rightOuterCircle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButtonDown(0)){
        //     pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

        //     leftInnerCircle.transform.position = pointA ;
        //     leftOuterCircle.transform.position = pointA ;
        //     leftInnerCircle.GetComponent<SpriteRenderer>().enabled = true;
        //     leftOuterCircle.GetComponent<SpriteRenderer>().enabled = true;
        // }
        // if(Input.GetMouseButton(0)){
        //     touchStart = true;
        //     pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        // }else{
        //     touchStart = false;
        // }
    }

    public void Shoot()
    {
        var newBullet = Instantiate(bullet, firePoint.position, transform.rotation);
        /* newBullet.GetComponent<Rigidbody2D>().velocity = firePoint.up * fireSpeed; */
        bullet.transform.Translate(Vector2.right * 20f * Time.deltaTime);
    }
}
