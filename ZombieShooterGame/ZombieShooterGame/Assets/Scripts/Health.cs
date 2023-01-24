using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;

    public Renderer rend;

    private void Awake() 
    {
        rend = GetComponent<Renderer>();
    }

    private void Update() 
    {
        if(health > numOfHearts)
        health = numOfHearts;
        
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else 
            {
                hearts[i].enabled = false;

            }
        }
    }


    IEnumerator Invincibility()
    {
        for(var n = 0; n < 10; n++)
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
        {
            StartCoroutine(Invincibility());
            health -= 1;
            numOfHearts -= 1;
        }
        Debug.Log(collision.gameObject.CompareTag("Enemies"));
    }

}
