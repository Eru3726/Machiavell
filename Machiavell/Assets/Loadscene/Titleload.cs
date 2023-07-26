using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titleload : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }
    public void Titlesceneload()
    {
        SceneManager.LoadScene("titlescene");
    }
}
