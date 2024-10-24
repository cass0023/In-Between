using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingDrop : MonoBehaviour
{
    public Camera cam;
    public Transform camPos;
    public int delay;
    private Rigidbody rb;
    void Start(){
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        camPos = cam.transform;
        if (transform.position.z > camPos.position.z + delay){
            transform.position = new Vector3(camPos.position.x, camPos.position.y, camPos.position.z + delay);
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
