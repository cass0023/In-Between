using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintGhost : MonoBehaviour
{
    public Transform enemySpawnPoint;
    public GameObject enemyPrefab;
    public float enemySpeed = 10;
    void Start()
    {

        }
    void Update()
    {

    }
    public void SpawnRunGhost(){
            var currentEnemy = Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
            currentEnemy.GetComponent<Rigidbody>().velocity = transform.forward * enemySpeed;
            currentEnemy.transform.Translate(Vector3.forward * enemySpeed);
    }
}
