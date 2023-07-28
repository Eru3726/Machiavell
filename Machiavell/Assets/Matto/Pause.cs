using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Slotcontroll sc;
    public GameObject HPbar;
    public GameObject hotbar;
    public GameObject configcanvas;
    public GameObject pausecanvas;
    public GameObject playercanvas;
    public GameObject tutrialcanvas;
    bool PauseFLG = true;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseFLG)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                pausecanvas.SetActive(true);
                HPbar.SetActive(false);
                Time.timeScale = 0;
                PauseFLG = false;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                tutrialcanvas.SetActive(false);
                playercanvas.SetActive(false);
                pausecanvas.SetActive(false);
                hotbar.SetActive(false);
                configcanvas.SetActive(false);
                sc.hotbarUI.SetActive(false);
                if (sc.buki1)
                    sc.buki1.SetActive(false);
                if (sc.buki2)
                    sc.buki2.SetActive(false);
                if (sc.buki3)
                    sc.buki3.SetActive(false);
                if (sc.buki4)
                    sc.buki4.SetActive(false);
                if (sc.buki5)
                    sc.buki5.SetActive(false);
                if (sc.buki6)
                    sc.buki6.SetActive(false);
                if (sc.buki7)
                    sc.buki7.SetActive(false);
                if (sc.buki8)
                    sc.buki8.SetActive(false);
                if (sc.buki9)
                    sc.buki9.SetActive(false);
                if (sc.buki10)
                    sc.buki10.SetActive(false);
                if (sc.hosi1)
                    sc.hosi1.SetActive(false);
                if (sc.hosi2)
                    sc.hosi2.SetActive(false);
                if (sc.hosi3)
                    sc.hosi3.SetActive(false);
                if (sc.hosi4)
                    sc.hosi4.SetActive(false);
                if (sc.hosi5)
                    sc.hosi5.SetActive(false);
                if (sc.hosi6)
                    sc.hosi6.SetActive(false);
                if (sc.hosi7)
                    sc.hosi7.SetActive(false);
                if (sc.hosi8)
                    sc.hosi8.SetActive(false);
                if (sc.hosi9)
                    sc.hosi9.SetActive(false);
                if (sc.hosi10)
                    sc.hosi10.SetActive(false);
                HPbar.SetActive(true);
                Time.timeScale = 1;
                PauseFLG = true;
            }
        }
    }
}