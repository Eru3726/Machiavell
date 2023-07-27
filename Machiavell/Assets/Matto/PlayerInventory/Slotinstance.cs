using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slotinstance : MonoBehaviour
{
    public Slotread sr;
    public Slotcontroll sc;
    public GameObject hotbar;
    public GameObject weaponcanvas;
    public GameObject pausecanvas;
    public Read readClass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void slotactive()
    {
        pausecanvas.SetActive(false);
        hotbar.SetActive(true);
        weaponcanvas.SetActive(true);
        sc.hotbarUI.SetActive(true);
        //readClass.enabled = true;
        sr.SlotDelete();
        Debug.Log("ì«Ç›çûÇ›Ç™Ç®ÇÌÇËÇ‹ÇµÇΩ");
        if (sc.buki1)
            sc.buki1.SetActive(true);
        if (sc.buki2)
            sc.buki2.SetActive(true);
        if (sc.buki3)
            sc.buki3.SetActive(true);
        if (sc.buki4)
            sc.buki4.SetActive(true);
        if (sc.buki5)
            sc.buki5.SetActive(true);
        if (sc.buki6)
            sc.buki6.SetActive(true);
        if (sc.buki7)
            sc.buki7.SetActive(true);
        if (sc.buki8)
            sc.buki8.SetActive(true);
        if (sc.buki9)
            sc.buki9.SetActive(true);
        if (sc.buki10)
            sc.buki10.SetActive(true);
        if (sc.hosi1)
            sc.hosi1.SetActive(true);
        if (sc.hosi2)
            sc.hosi2.SetActive(true);
        if (sc.hosi3)
            sc.hosi3.SetActive(true);
        if (sc.hosi4)
            sc.hosi4.SetActive(true);
        if (sc.hosi5)
            sc.hosi5.SetActive(true);
        if (sc.hosi6)
            sc.hosi6.SetActive(true);
        if (sc.hosi7)
            sc.hosi7.SetActive(true);
        if (sc.hosi8)
            sc.hosi8.SetActive(true);
        if (sc.hosi9)
            sc.hosi9.SetActive(true);
        if (sc.hosi10)
            sc.hosi10.SetActive(true);
    }
}
