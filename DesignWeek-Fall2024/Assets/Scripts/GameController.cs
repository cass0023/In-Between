using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public EnemyManager enemyManager;
    public Image[] lives;
    public int livesRemaining;
    
    Vector2 startPos;
    private void Start()
    {
       
        startPos = transform.position;
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.CompareTag("Enemy"))
        {         
            Die();
        }

    }

    

    public void LoseLife()
    {
        Destroy(GameObject.FindWithTag("Enemy"));
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
