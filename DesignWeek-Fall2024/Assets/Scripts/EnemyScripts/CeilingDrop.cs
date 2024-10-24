using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingDrop : MonoBehaviour
{
    public Camera cam;
    public Transform camPos;
    public int delay;
    void Start(){
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    void Update()
    {
        camPos = cam.transform;
        if (transform.position.z > camPos.position.z + delay){
            transform.position = new Vector3(camPos.position.x, camPos.position.y, camPos.position.z + delay);
        }
    }
}
