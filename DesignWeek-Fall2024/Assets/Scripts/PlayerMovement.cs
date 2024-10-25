using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public EnemyManager enemyManager;
    public Transform target;
    public float t;
    public float speed;
    public GameObject ScaryMonster;
    bool ifStart = false;
    public KeyCode flashlightInput;
    public AudioClip[] sounds;
    private AudioSource source;

    void Start()
    {
        ScaryMonster.SetActive(false);
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Enemy")
        {
            Destroy(Player.gameObject);
            ScaryMonster.SetActive(true);
            StartCoroutine(restart());
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.Play();
            ifStart = false;
        }
        if(Player.gameObject.tag == "StopSpawn"){
            enemyManager.disableSpawn = true;
        }
    }

        IEnumerator restart()
    {
        yield return new WaitForSeconds(7f);
        ScaryMonster.SetActive(false);
    }

    private void FixedUpdate()
    {
        // Starts game
        if (Input.GetKey(flashlightInput) && ifStart == false)
        {
            ifStart = true;
        }

        if (ifStart == true)

        {
            Vector3 a = transform.position;
            Vector3 b = target.position;
            transform.position = Vector3.MoveTowards(a, b, speed);
        }

    }

   
}
