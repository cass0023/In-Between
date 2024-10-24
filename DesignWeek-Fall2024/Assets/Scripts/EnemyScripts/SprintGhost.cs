using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintGhost : MonoBehaviour
{
    public Transform enemySpawnPoint;
    public GameObject enemyPrefab;
    public float enemySpeed = 10;
    private GameObject currentPrefab;
    // Start is called before the first frame update
    void Start()
    {
        currentPrefab = null;
    }

    // Update is called once per frame
    void Update()
    {
               if (currentPrefab == null)
        {
            var currentEnemy = Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
            currentEnemy.GetComponent<Rigidbody>().velocity = transform.forward * enemySpeed;
            currentEnemy.transform.Translate(Vector3.forward * enemySpeed);
            currentPrefab = currentEnemy;
        } 
    }
}
