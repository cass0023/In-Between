using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestLightManager : MonoBehaviour
{
    public KeyCode flashlightInput;
    public KeyCode flashlightRech;
    public GameObject flashlight;
    public float ActualEnergy = 100;
    public float MaxEnergy = 100;
    public float Velocity = 20f;
    public float VelocityRech;
    public Light LigthFlash;

    public Image Battery;
  
    // Start is called before the first frame update
    void Start()
    {

    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(flashlightInput))
        {
            LightSource();
            if (LigthFlash.enabled == false)
            { 
                LigthFlash.enabled = true;
            }
        }
        else if (LigthFlash.enabled == true)
        {
            flashlight.SetActive(false);
            LigthFlash.enabled = false;
        }

        if (LigthFlash.enabled == true)
        {
            ActualEnergy -= Time.deltaTime * Velocity;

            if (ActualEnergy <= 0)
            {
                ActualEnergy = 0;
                LigthFlash.enabled = false;
                flashlight.SetActive(false);
            }
        }

        else if (Input.GetKey(flashlightRech))
        {
            ActualEnergy += Time.deltaTime * VelocityRech;
            if (ActualEnergy >= MaxEnergy) 
            { 
            ActualEnergy= MaxEnergy;
            }
        }

        Battery.fillAmount = ActualEnergy / MaxEnergy;

    }

    private void LightSource()
    {
        flashlight.SetActive(true);
    }

}
