using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Footsteps : MonoBehaviour
{
    public GameObject steps;
    public KeyCode SInput;
    public bool isWalking;

    // Start is called before the first frame update
    void Start()
    {
       steps.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(SInput))
        {
            Walking();
        }

    }
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Enemy")
        {
           StopWalking();
        }
    }
    void Walking()
    {
        isWalking = true;
        steps.SetActive(true);
    }

    void StopWalking()
    {
        isWalking = false;
        steps.SetActive(false);
    }
}
