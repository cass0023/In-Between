using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] possibleEnemy;
    [SerializeField]private GameObject currentEnemy;
    [SerializeField]private int randomNum;
    public CeilingGhost crawl;
    public SprintGhost run;
    void Start()
    {
        crawl = GetComponentInChildren<CeilingGhost>();
        run = GetComponentInChildren<SprintGhost>();
        currentEnemy = null;
    }

    // Update is called once per frame
    void Update()
    {
        //checks if any enemies are in the scene
        GameObject[] cEnemyInScene = GameObject.FindGameObjectsWithTag("CeilingEnemy");
        GameObject[] enemyInScene = GameObject.FindGameObjectsWithTag("Enemy");
        int temp = cEnemyInScene.Length + enemyInScene.Length;
        if(temp <= 0){
            currentEnemy = null;
        }
        if (currentEnemy == null){
            //randomly chooses an enemy to spawn if there isnt one in scene
            randomNum = Random.Range(0, possibleEnemy.Length);
            currentEnemy = possibleEnemy[randomNum];
            if(randomNum == 0){
                //first in array
                crawl.SpawnCeilingGhost();
            }
            if(randomNum == 1){
                //second in array
                run.SpawnRunGhost();
            }
        }
    }
}
