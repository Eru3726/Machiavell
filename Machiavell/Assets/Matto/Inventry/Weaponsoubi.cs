using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponsoubi : MonoBehaviour
{
    public bool read = false;
    public GameObject soubipos;
    public GameObject soubiobj;
    public DropWeapon dw;
    public weaponsannsyoufusion ws;
    public Kyoukasannsyou ks;
    private Vector3 pos1 = new Vector3(0, 0, 0);
    private Vector3 pos2 = new Vector3(0, 0, 0);
    private Vector3 pos3 = new Vector3(0, 0, 0);
    private Vector3 pos4 = new Vector3(0, 0, 0);
    private Vector3 pos5 = new Vector3(0, 0, 0);
    private Vector3 pos6 = new Vector3(0, 0, 0);
    private Vector3 pos7 = new Vector3(0, 0, 0);
    private Vector3 pos8 = new Vector3(0, 0, 0);
    private Vector3 pos9 = new Vector3(0, 0, 0);
    private Vector3 pos10 = new Vector3(0, 0, 0);
    void Start()
    {
        pos1 = new Vector3(-6.65f,2.75f,0);
        pos2 = pos1 + new Vector3 (2.4f, 0, 0);
        pos3 = pos2 + new Vector3 (2.4f, 0, 0);
        pos4 = pos3 + new Vector3 (2.4f, 0, 0);
        pos5 = pos4 + new Vector3 (2.4f, 0, 0);
        pos6 = pos5 + new Vector3 (-9.6f, -2.4f, 0);
        pos7 = pos6 + new Vector3(2.4f, 0, 0);
        pos8 = pos7 + new Vector3(2.4f, 0, 0);
        pos9 = pos8 + new Vector3(2.4f, 0, 0);
        pos10 = pos9 + new Vector3(2.4f, 0, 0);
        if (GameData.soubi == 1)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos1, Quaternion.identity);
        }
        else if (GameData.soubi == 2)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos2, Quaternion.identity);
        }
        else if (GameData.soubi == 3)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos3, Quaternion.identity);
        }
        else if (GameData.soubi == 4)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos4, Quaternion.identity);
        }
        else if (GameData.soubi == 5)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos5, Quaternion.identity);
        }
        else if (GameData.soubi == 6)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos6, Quaternion.identity);
        }
        else if (GameData.soubi == 7)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos7, Quaternion.identity);
        }
        else if (GameData.soubi == 8)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos8, Quaternion.identity);
        }
        else if (GameData.soubi == 9)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos9, Quaternion.identity);
        }
        else if (GameData.soubi == 10)
        {
            Destroy(soubipos);
            soubipos = Instantiate(soubiobj, pos10, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
    public void soubi()
    {
        if (ws)
        {
            if (read == true)
            {
                if (GameData.soubi == 1)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos1, Quaternion.identity);
                }
                else if (GameData.soubi == 2)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos2, Quaternion.identity);
                }
                else if (GameData.soubi == 3)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos3, Quaternion.identity);
                }
                else if (GameData.soubi == 4)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos4, Quaternion.identity);
                }
                else if (GameData.soubi == 5)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos5, Quaternion.identity);
                }
                else if (GameData.soubi == 6)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos6, Quaternion.identity);
                }
                else if (GameData.soubi == 7)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos7, Quaternion.identity);
                }
                else if (GameData.soubi == 8)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos8, Quaternion.identity);
                }
                else if (GameData.soubi == 9)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos9, Quaternion.identity);
                }
                else if (GameData.soubi == 10)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos10, Quaternion.identity);
                }
                read = false;
            }
            else if (dw.pos1 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos1, Quaternion.identity);
                GameData.soubi = 1;
            }
            else if (dw.pos2 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos2, Quaternion.identity);
                GameData.soubi = 2;
            }
            else if (dw.pos3 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos3, Quaternion.identity);
                GameData.soubi = 3;
            }
            else if (dw.pos4 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos4, Quaternion.identity);
                GameData.soubi = 4;
            }
            else if (dw.pos5 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos5, Quaternion.identity);
                GameData.soubi = 5;
            }
            else if (dw.pos6 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos6, Quaternion.identity);
                GameData.soubi = 6;
            }
            else if (dw.pos7 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos7, Quaternion.identity);
                GameData.soubi = 7;
            }
            else if (dw.pos8 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos8, Quaternion.identity);
                GameData.soubi = 8;
            }
            else if (dw.pos9 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos9, Quaternion.identity);
                GameData.soubi = 9;
            }
            else if (dw.pos10 == ws.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos10, Quaternion.identity);
                GameData.soubi = 10;
            }
            else
            {
                Debug.Log("‘•”õ‚Å‚«‚Ü‚¹‚ñ");
            }
        }
        if (ks)
        {
            if (read == true)
            {
                if (GameData.soubi == 1)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos1, Quaternion.identity);
                }
                else if (GameData.soubi == 2)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos2, Quaternion.identity);
                }
                else if (GameData.soubi == 3)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos3, Quaternion.identity);
                }
                else if (GameData.soubi == 4)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos4, Quaternion.identity);
                }
                else if (GameData.soubi == 5)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos5, Quaternion.identity);
                }
                else if (GameData.soubi == 6)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos6, Quaternion.identity);
                }
                else if (GameData.soubi == 7)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos7, Quaternion.identity);
                }
                else if (GameData.soubi == 8)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos8, Quaternion.identity);
                }
                else if (GameData.soubi == 9)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos9, Quaternion.identity);
                }
                else if (GameData.soubi == 10)
                {
                    Destroy(soubipos);
                    soubipos = Instantiate(soubiobj, pos10, Quaternion.identity);
                }
                read = false;
            }
            else if (dw.pos1 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos1, Quaternion.identity);
                GameData.soubi = 1;
            }
            else if (dw.pos2 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos2, Quaternion.identity);
                GameData.soubi = 2;
            }
            else if (dw.pos3 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos3, Quaternion.identity);
                GameData.soubi = 3;
            }
            else if (dw.pos4 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos4, Quaternion.identity);
                GameData.soubi = 4;
            }
            else if (dw.pos5 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos5, Quaternion.identity);
                GameData.soubi = 5;
            }
            else if (dw.pos6 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos6, Quaternion.identity);
                GameData.soubi = 6;
            }
            else if (dw.pos7 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos7, Quaternion.identity);
                GameData.soubi = 7;
            }
            else if (dw.pos8 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos8, Quaternion.identity);
                GameData.soubi = 8;
            }
            else if (dw.pos9 == ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos9, Quaternion.identity);
                GameData.soubi = 9;
            }
            else if (dw.pos10 ==ks.sannsyou)
            {
                Destroy(soubipos);
                soubipos = Instantiate(soubiobj, pos10, Quaternion.identity);
                GameData.soubi = 10;
            }
            else
            {
                Debug.Log("‘•”õ‚Å‚«‚Ü‚¹‚ñ");
            }
        }
    }
}
