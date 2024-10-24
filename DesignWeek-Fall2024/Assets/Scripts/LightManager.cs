using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightManager : MonoBehaviour
{
    public KeyCode flashlightInput;
    public GameObject flashlight;
    public float flashlightTimer = 10;

    public Image Battery;
    public float Light;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Ligth UI
    public void LoseLigth(int value)
    {
        Light -= value;
        Battery.fillAmount = Light / 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(flashlightInput) && flashlightTimer > 0)
        {
            LightSource();
            flashlightTimer -= Time.deltaTime;
            if(flashlightTimer <= 0){
                flashlightTimer = 0;
            }
        }
        else{
            flashlight.SetActive(false);
        }

    }
    private void LightSource(){
        flashlight.SetActive(true);
    }
}
