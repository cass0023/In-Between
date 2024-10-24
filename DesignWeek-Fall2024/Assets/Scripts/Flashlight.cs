using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public KeyCode flashlightInput;

    void OnTriggerEnter(Collider collider)
    {
        if (Input.GetKey(flashlightInput)) 
        {
            if (collider.gameObject.CompareTag("Enemy"))
            {
                Destroy(collider.gameObject);
            }
        }
    }
}
