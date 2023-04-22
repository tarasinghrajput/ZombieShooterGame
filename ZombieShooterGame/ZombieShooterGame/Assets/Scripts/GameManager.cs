using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
   private GameObject gameOverPanel;

    [SerializeField]
   private GameObject moveJoystick;

    [SerializeField]
   private GameObject shootJoystick;

    [SerializeField]
   private GameObject heartCont;
   private GameObject player;

   private Health healthScript;

   int currentIndex;

   private void Awake() 
   {
        gameOverPanel.SetActive(false);
        player = GameObject.FindWithTag("Player");
        moveJoystick.SetActive(true);
        shootJoystick.SetActive(true);
        heartCont.SetActive(true);
        currentIndex = SceneManager.GetActiveScene().buildIndex;
   }

   private void Update() 
   {
    // using this type of method to show the game over screen because the player still sometimes destroys itself with its own bullet
        if(player == null)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
            moveJoystick.SetActive(false);
            shootJoystick.SetActive(false);
            heartCont.SetActive(false);
            player.SetActive(false);
        }
   }


// ****************** This method should be used once the above issue is resolved *****************
/*   private void GameOver()
   {
        if(healthScript.health < 1)
        {
            
        }
   }
   */

   public void Restart()
   {
        SceneManager.LoadScene(currentIndex);
   }
}
