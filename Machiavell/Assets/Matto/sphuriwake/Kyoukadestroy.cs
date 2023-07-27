using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kyoukadestroy : MonoBehaviour
{
    public GameObject sannsyouscript;
    private GameObject sannsyou;　　　　　　　　　　//クリックで参照してるオブジェクト
    public DropWeapon dw;
    private float dcount;
    void Start()
    {
        
    }
    void Update()
    {

    }
    public void OnClick()
    {
        dcount = 0;
        if (dw.pos2)
        {
            dcount += 1;
        }
        if (dw.pos3)
        {
            dcount += 1;
        }
        if (dw.pos4)
        {
            dcount += 1;
        }
        if (dw.pos5)
        {
            dcount += 1;
        }
        if (dw.pos6)
        {
            dcount += 1;
        }
        if (dw.pos7)
        {
            dcount += 1;
        }
        if (dw.pos8)
        {
            dcount += 1;
        }
        if (dw.pos9)
        {
            dcount += 1;
        }
        if (dw.pos10)
        {
            dcount += 1;
        }
        if (dw.pos1)
        {
            dcount += 1;
        }
        if (dcount <= 1)
        {
            Debug.Log("武器がなくなるからダメ");
        }
        else
        {
            sannsyou = sannsyouscript.GetComponent<Kyoukasannsyou>().sannsyou;
            Destroy(sannsyou);
            sannsyouscript.GetComponent<Kyoukasannsyou>().firstnotsannsyou = false;
            Debug.Log("デストローイ");
        }
    }
}
