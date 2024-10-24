using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightCount : MonoBehaviour
{
    public Image fillBar;
    public float Light;


    public void LoseLigth(int value)
    {
        Light -= value;
        fillBar.fillAmount = Light / 100;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseLigth(25);
        }
    }

}
