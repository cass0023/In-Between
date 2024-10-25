using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGhost : MonoBehaviour
{
    public int speed;
    private GameController gameController;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        gameController = GameObject.Find("Player").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider){
        if(collider.name == "DoorCheck"){
            audioSource.volume = 1f;
            this.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            //transform.Translate(Vector3.forward * speed);
            Destroy(gameObject, 5f);
        }
        if(collider.CompareTag("Flashlight")){
            Destroy(gameObject);
        }
        if(collider.name == "Player"){
            gameController.LoseLife();
            Destroy(gameObject);
        }
    }
}
