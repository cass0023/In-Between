using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CeilingGhost : MonoBehaviour
{
    public Transform ceilingGhostSpawn;
    public GameObject ceilingGhostPrefab;
    public int ceilingSpeed;

    void Update(){
        if(gameObject.tag == "Enemy"){
            //change animation
        }
    }

    public void SpawnCeilingGhost(){
        var currentEnemy = Instantiate(ceilingGhostPrefab, ceilingGhostSpawn.position, ceilingGhostSpawn.rotation);
        currentEnemy.GetComponent<Rigidbody>().velocity = transform.forward * ceilingSpeed;
        currentEnemy.transform.Translate(Vector3.forward * ceilingSpeed);
    }
}
