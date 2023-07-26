using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slotweapondeth : MonoBehaviour
{
    public Slotsannsyou sannsyouscript;
    private GameObject sannsyou;　　　　　　　　　　//クリックで参照してるオブジェクト
    public Slotdrop sd;
    private float dcount;
    void Start()
    {

    }
    void Update()
    {

    }
    public void OnClick()
    {
        sannsyou = sannsyouscript.sannsyou;
        dcount = 0;
        if (sannsyou)
        {
            dcount += 1;
        }
        if (sd.pos1)
        {
            dcount += 1;
        }
        if (sd.pos2)
        {
            dcount += 1;
        }
        if (sd.pos3)
        {
            dcount += 1;
        }
        if (sd.pos4)
        {
            dcount += 1;
        }
        if (sd.pos5)
        {
            dcount += 1;
        }
        if (sd.pos6)
        {
            dcount += 1;
        }
        if (sd.pos7)
        {
            dcount += 1;
        }
        if (sd.pos8)
        {
            dcount += 1;
        }
        if (sd.pos9)
        {
            dcount += 1;
        }
        if (sd.pos10)
        {
            dcount += 1;
        }

        if (dcount <= 1)
        {
            Debug.Log("dcount"+dcount);
            Debug.Log("武器がなくなるからダメ");
        }
        else
        {
            if (GameData.soubi == 1)
            {
                if (sd.pos1 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 2)
            {
                if (sd.pos2 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 3)
            {
                if (sd.pos3 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 4)
            {
                if (sd.pos4 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 5)
            {
                if (sd.pos5 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 6)
            {
                if (sd.pos6 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 7)
            {
                if (sd.pos7 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 8)
            {
                if (sd.pos8 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 9)
            {
                if (sd.pos9 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
            else if (GameData.soubi == 10)
            {
                if (sd.pos10 == sannsyou)
                {
                    Debug.Log("装備してる武器は破棄できません");
                }
                else
                {
                    Destroy(sannsyou);
                    Debug.Log("デストローイ");
                }
            }
        }
    }
}
