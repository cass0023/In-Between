using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Image[] lives;
    public int livesRemaining;
    
    Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Die();
        }
    }
    public void LoseLife()
    {
        livesRemaining--;
        lives[livesRemaining].enabled = false;

        if (livesRemaining == 0)
        {
            SceneManager.LoadScene("Lost");
        }
    }

    void Die()
    {
        RespawnPos();
    }

    void RespawnPos()
    {
        transform.position = startPos;
        LoseLife();
    }
}
