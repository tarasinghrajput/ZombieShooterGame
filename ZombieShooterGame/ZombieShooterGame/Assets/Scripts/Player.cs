using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    public FixedJoystick aimJoystick;
    Vector3 moveVelocity;
    Vector3 aimVelocity;
    public Rigidbody2D rb;
    public float moveSpeed;
    // public Collision2D zombieRb;
    public Renderer rend;
    public Color colour;

    public float speed;
    public float fireSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        // zombieRb = GameObject.FindWithTag("Enemies").GetComponent<Collision2D>;
        rend = GetComponent<Renderer>();
        colour = rend.material.color;
        // StartCoroutine(Invincibility());
    }

    // Update is called once per frame
    void Update()
    {
        // WASD keys player movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal, vertical, 0) * Time.deltaTime * speed;



        // Moving mechanics
        moveVelocity = new Vector2(moveJoystick.Horizontal, moveJoystick.Vertical);
        Vector2 moveInput = new Vector2(moveVelocity.x, moveVelocity.y);
        Vector2 moveDir = moveInput.normalized * moveSpeed;
        rb.MovePosition(rb.position + moveDir * Time.deltaTime);


        // aimVelocity = new Vector3(aimJoystick.Horizontal, aimJoystick.Vertical);
        // Vector3 aimInput = new Vector3(aimVelocity.x, aimVelocity.y)* Mathf.Rad2Deg;
        // Vector3 lookAtPoint = transform.position + aimInput;
        // transform.LookAt(lookAtPoint);

        // Aiming Mechanics
        Vector3 moveVector = (Vector3.up * aimJoystick.Horizontal + Vector3.left * aimJoystick.Vertical);
        if (aimJoystick.Horizontal != 0 || aimJoystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }


        // If zombie hit the player
        
    }

    IEnumerator Invincibility()
    {
       /* for (int i = 0; i <= 5; i++)
        {
            gameObject.SetActive(false);
            yield return new WaitForSeconds(1);
            gameObject.SetActive(true);
        } */

        for(var n = 0; n < 5; n++)
        {
            rend.enabled = true;
            yield return new WaitForSeconds(.1f);
            rend.enabled = false;
            yield return new WaitForSeconds(.1f);
        }
            rend.enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(!(collision.gameObject.CompareTag("Enemies")))
        StartCoroutine(Invincibility());
        Debug.Log(collision.gameObject.CompareTag("Enemies"));
    }
}
