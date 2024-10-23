using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public KeyCode flashlightInput;
    public GameObject flashlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(flashlightInput)){
            LightSource();
        }
        else{
            flashlight.SetActive(false);
        }
    }
    private void LightSource(){
        flashlight.SetActive(true);
    }
}
