using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDeth : MonoBehaviour
{
    public weaponsannsyoufusion ws;
    public Kyoukasannsyou ks;
    public DropWeapon dw;
    public Rarerity rare;
    public WeaponDestroy wd;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void dethstar()
    {
        if (wd.notdeth == false)
        {
            if (ws)
            {
                if (ws.sannsyou == dw.pos1)
                {
                    Destroy(rare.star1);
                }
                else if (ws.sannsyou == dw.pos2)
                {
                    Destroy(rare.star2);
                }
                else if (ws.sannsyou == dw.pos3)
                {
                    Destroy(rare.star3);
                }
                else if (ws.sannsyou == dw.pos4)
                {
                    Destroy(rare.star4);
                }
                else if (ws.sannsyou == dw.pos5)
                {
                    Destroy(rare.star5);
                }
                else if (ws.sannsyou == dw.pos6)
                {
                    Destroy(rare.star6);
                }
                else if (ws.sannsyou == dw.pos7)
                {
                    Destroy(rare.star7);
                }
                else if (ws.sannsyou == dw.pos8)
                {
                    Destroy(rare.star8);
                }
                else if (ws.sannsyou == dw.pos9)
                {
                    Destroy(rare.star9);
                }
                else if (ws.sannsyou == dw.pos10)
                {
                    Destroy(rare.star10);
                }
            }
            if (ks)
            {
                if (ks.sannsyou == dw.pos1)
                {
                    Destroy(rare.star1);
                }
                else if (ks.sannsyou == dw.pos2)
                {
                    Destroy(rare.star2);
                }
                else if (ks.sannsyou == dw.pos3)
                {
                    Destroy(rare.star3);
                }
                else if (ks.sannsyou == dw.pos4)
                {
                    Destroy(rare.star4);
                }
                else if (ks.sannsyou == dw.pos5)
                {
                    Destroy(rare.star5);
                }
                else if (ks.sannsyou == dw.pos6)
                {
                    Destroy(rare.star6);
                }
                else if (ks.sannsyou == dw.pos7)
                {
                    Destroy(rare.star7);
                }
                else if (ks.sannsyou == dw.pos8)
                {
                    Destroy(rare.star8);
                }
                else if (ks.sannsyou == dw.pos9)
                {
                    Destroy(rare.star9);
                }
                else if (ks.sannsyou == dw.pos10)
                {
                    Destroy(rare.star10);
                }
            }
        }
    }
}
