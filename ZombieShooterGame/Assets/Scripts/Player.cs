using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    public FixedJoystick aimJoystick;
    Vector3 moveVelocity;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float fireSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVelocity = new Vector2(moveJoystick.Horizontal, moveJoystick.Vertical);
        Vector2 moveInput = new Vector2(moveVelocity.x, moveVelocity.y);
        Vector2 moveDir = moveInput.normalized * moveSpeed;
        rb.MovePosition(rb.position + moveDir * Time.deltaTime);
    }
}
