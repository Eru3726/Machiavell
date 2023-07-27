using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slotsannsyou : MonoBehaviour
{
    public GameObject parent;
    private float wheel;
    public Slotdrop sd;
    public Slotcontroll sc;
    public Slothyouji sh;
    public GameObject UI;
    private Vector3 uiposi = new Vector3(-11.04f, -8f, 10);
    public GameObject sannsyou;
    private float sannsyoucount = 1;
    private bool hyouji = true;
    void Start()
    {
        sc.hotbarUI = Instantiate(UI, uiposi, Quaternion.identity);
        sc.hotbarUI.SetActive(false);
        sc.hotbarUI.transform.parent = parent.transform;
        sc.hotbarUI.transform.localPosition = uiposi;
        sannsyoucount = 1;
    }

    void Update()
    {
        if (sc.hotbarUI.activeInHierarchy)
        {
            if (sannsyou == null)
            {
                Destroy(sh.hyoujibuki);
                Destroy(sh.sannsyoustar);
            }
            wheel = Input.GetAxis("Mouse ScrollWheel");
            if (wheel >= 0.1)
            {
                if (uiposi == new Vector3(-11.04f, -8f, 10))
                {
                    uiposi = new Vector3(14.88f, -8f, 10);
                    sc.hotbarUI.transform.localPosition = uiposi;
                    sannsyoucount = 10;
                }
                else
                {
                    uiposi -= new Vector3(2.88f, 0, 0);
                    sc.hotbarUI.transform.localPosition = uiposi;
                    sannsyoucount -= 1;
                }
                hyouji = true;
            }
            else if (wheel <= -0.1)
            {
                if (uiposi == new Vector3(14.88f, -8f, 10))
                {
                    uiposi = new Vector3(-11.04f, -8f, 10);
                    sc.hotbarUI.transform.localPosition = uiposi;
                    sannsyoucount = 1;
                }
                else
                {
                    uiposi += new Vector3(2.88f, 0, 0);
                    sc.hotbarUI.transform.localPosition = uiposi;
                    sannsyoucount += 1;
                }
                hyouji = true;
            }
            if (hyouji == true)
            {
                count();
                hyouji = false;
            }
        }
        else
        {
            Destroy(sh.hyoujibuki);
            Destroy(sh.sannsyoustar);
            hyouji = true;
        }
    }
    private void count()
    {
        if (sannsyoucount == 1 && sd.pos1)
        {
            sannsyou = sd.pos1;
            sh.hyouji();
        }
        else if (sannsyoucount == 2 && sd.pos2)
        {
            sannsyou = sd.pos2;
            sh.hyouji();
        }
        else if (sannsyoucount == 3 && sd.pos3)
        {
            sannsyou = sd.pos3;
            sh.hyouji();
        }
        else if (sannsyoucount == 4 && sd.pos4)
        {
            sannsyou = sd.pos4;
            sh.hyouji();
        }
        else if (sannsyoucount == 5 && sd.pos5)
        {
            sannsyou = sd.pos5;
            sh.hyouji();
        }
        else if (sannsyoucount == 6 && sd.pos6)
        {
            sannsyou = sd.pos6;
            sh.hyouji();
        }
        else if (sannsyoucount == 7 && sd.pos7)
        {
            sannsyou = sd.pos7;
            sh.hyouji();
        }
        else if (sannsyoucount == 8 && sd.pos8)
        {
            sannsyou = sd.pos8;
            sh.hyouji();
        }
        else if (sannsyoucount == 9 && sd.pos9)
        {
            sannsyou = sd.pos9;
            sh.hyouji();
        }
        else if (sannsyoucount == 10 && sd.pos)
        {
            sannsyou = sd.pos10;
            sh.hyouji();
        }
        else
        {
            sannsyou = null;
            Destroy(sh.hyoujibuki);
            Destroy(sh.sannsyoustar);
        }
    }
}

