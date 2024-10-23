using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [Header ("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource, sfxSource;
    [Header("-------- Audio Clip --------")]
    public SoundManager[] musicSound, sfxSound;
    //will play music on start
    void Awake()
    {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    void Start(){
        PlayMusic(""); //**** Put sound name here
    }
    public void PlayMusic(string name){
        SoundManager s = Array.Find(musicSound, x => x.name == name);
        if(s == null){
            Debug.Log("Sound not found");
        }
        else{
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
        public void PlaySFX(string name){
        SoundManager s = Array.Find(sfxSound, x => x.name == name);
        if(s == null){
            Debug.Log("SFX not found");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
    }
}
