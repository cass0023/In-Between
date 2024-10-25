using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGhost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider){
        if(collider.name == "DoorCheck"){
            gameObject.transform.position = Vector3.forward;
        }
    }
}
