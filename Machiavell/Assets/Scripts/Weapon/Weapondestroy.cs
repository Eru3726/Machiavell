using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapondestroy : MonoBehaviour
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
        sannsyou = sannsyouscript.GetComponent<weaponsannsyoufusion>().sannsyou;

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
            if (GameData.soubi == 1)
            {
                if (dw.pos1 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 2)
            {
                if (dw.pos2 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 3)
            {
                if (dw.pos3 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 4)
            {
                if (dw.pos4 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 5)
            {
                if (dw.pos5 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 6)
            {
                if (dw.pos6 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 7)
            {
                if (dw.pos7 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 8)
            {
                if (dw.pos8 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 9)
            {
                if (dw.pos9 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 10)
            {
                if (dw.pos10 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    sannsyouscript.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                    Debug.Log("デストローイ");
                }
            }
        }
    }
}
