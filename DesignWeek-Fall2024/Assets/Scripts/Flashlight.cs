using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Enemy")|| collider.gameObject.CompareTag("DoorEnemy"))
        {
            Destroy(collider.gameObject);
        }

    }
}
