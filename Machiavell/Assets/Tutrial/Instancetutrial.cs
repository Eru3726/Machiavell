using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancetutrial : MonoBehaviour
{
    private float page = 1;
    public GameObject tutrialcanvas;
    public GameObject config;
    public GameObject fusion;
    public GameObject inventry;
    public GameObject statusplas;
    public GameObject save;
    public GameObject pausecanvas;
    void Start()
    {
        
    }

    void Update()
    {
        if (page == 1)
        {
            configtutrial();
        }
        else if (page == 2)
        {
            fusiontutrial();
        }
        else if (page == 3)
        {
            inventrytutrial();
        }
        else if (page == 4)
        {
            statusplastutrial();
        }
        else if (page == 5)
        {
            savetutrial();
        }
    }
    public void inastancetutrial()
    {
        tutrialcanvas.SetActive(true);
        pausecanvas.SetActive(false);
    }
    public void configtutrial()
    {
        fusion.SetActive(false);
        inventry.SetActive(false);
        statusplas.SetActive(false);
        save.SetActive(false);
        config.SetActive(true);
    }
    public void fusiontutrial()
    {
        fusion.SetActive(true);
        inventry.SetActive(false);
        statusplas.SetActive(false);
        save.SetActive(false);
        config.SetActive(false);
    }
    public void inventrytutrial()
    {
        fusion.SetActive(false);
        inventry.SetActive(true);
        statusplas.SetActive(false);
        save.SetActive(false);
        config.SetActive(false);
    }
    public void statusplastutrial()
    {
        fusion.SetActive(false);
        inventry.SetActive(false);
        statusplas.SetActive(true);
        save.SetActive(false);
        config.SetActive(false);
    }
    public void savetutrial()
    {
        fusion.SetActive(false);
        inventry.SetActive(false);
        statusplas.SetActive(false);
        save.SetActive(true);
        config.SetActive(false);
    }
    public void rightpage()
    {
        if (page == 5)
        {
            page = 1;
        }
        else
        {
            page += 1;
        }
    }
}
