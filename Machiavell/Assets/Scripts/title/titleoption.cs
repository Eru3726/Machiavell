using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleoption : MonoBehaviour
{
    public GameObject pause;
    public GameObject titlecanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void option()
    {
        pause.SetActive(true);
        titlecanvas.SetActive(false);
    }
}
