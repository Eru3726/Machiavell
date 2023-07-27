using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanceconfig : MonoBehaviour
{
    public Read readClass;
    public GameObject bookui;
    public GameObject configcanvas;
    public GameObject pausecanvas;
    void Start()
    {

    }

    void Update()
    {
        
    }
    public void OnActive()
    {
        //readClass.enabled = true;
        pausecanvas.SetActive(false);
        bookui.SetActive(true);
        configcanvas.SetActive(true);
    }
}
