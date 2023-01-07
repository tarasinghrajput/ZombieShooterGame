using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementJoystick : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public Transform leftInnerCircle;
    public Transform leftOuterCircle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            leftInnerCircle.transform.position = pointA ;
            leftOuterCircle.transform.position = pointA ;
            leftInnerCircle.GetComponent<SpriteRenderer>().enabled = true;
            leftOuterCircle.GetComponent<SpriteRenderer>().enabled = true; 
        }
        if(Input.GetMouseButton(0)){
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }else{
            touchStart = false;
        }
    }

    private void FixedUpdate(){
        if(touchStart){
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction);

            leftInnerCircle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y);
        }else{
            leftInnerCircle.GetComponent<SpriteRenderer>().enabled = false;
            leftOuterCircle.GetComponent<SpriteRenderer>().enabled = false;
        }

	}
    
	void moveCharacter(Vector2 direction){
        player.Translate(direction * speed * Time.deltaTime);
    }
}
