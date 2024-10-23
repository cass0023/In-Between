using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    public KeyCode flashlightInput;
    void Update()
    {
        if (Input.GetKeyUp(flashlightInput)){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
