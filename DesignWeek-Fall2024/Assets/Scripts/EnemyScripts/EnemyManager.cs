using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro.EditorUtilities;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] possibleEnemy;
    public GameObject currentEnemy;
    [SerializeField]private int randomNum;
    public CeilingGhost crawl;
    public SprintGhost run;
    public Footsteps walkCheck;
    public bool disableSpawn;
    public GameObject testDummy;
    void Start()
    {
        run = GetComponentInChildren<SprintGhost>();
        currentEnemy = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (disableSpawn == true){
            //stops enemies from spawning lol
            testDummy.tag = "Enemy";
            currentEnemy = testDummy;
        }
        //checks if any enemies are in the scene
        GameObject[] cEnemyInScene = GameObject.FindGameObjectsWithTag("CeilingEnemy");
        GameObject[] enemyInScene = GameObject.FindGameObjectsWithTag("Enemy");
        int temp = cEnemyInScene.Length + enemyInScene.Length;
        if(temp <= 0){
            currentEnemy = null;
        }
        if (currentEnemy == null && walkCheck.isWalking == true){
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
