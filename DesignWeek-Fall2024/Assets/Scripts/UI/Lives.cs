using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    public Image[]lives;
    public int livesRemaining;
    public Transform respawnPoint;


    public void LoseLife()
    {
        livesRemaining--;
        lives[livesRemaining].enabled = false;

        if (livesRemaining == 0)
        {
            SceneManager.LoadScene("Lost");
        }
    }

  
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.transform.position = respawnPoint.position;
            LoseLife();
        }
    }

}
