using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slotweapontext : MonoBehaviour
{
    public Slotsannsyou ss;
    public Slotdrop sd;
    public Text hp;
    public Text st;
    public Text atk;
    public Text def;
    public Text luk;
    void Start()
    {

    }

    void Update()
    {
        if (!ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  ";
            }
            if (st)
            {
                st.text = "ST  ";
            }
            if (atk)
            {
                atk.text = "ATK ";
            }
            if (def)
            {
                def.text = "DEF ";
            }
            if (luk)
            {
                luk.text = "LUK ";
            }
            //Debug.Log("bukilost");
        }
        else if (ss.sannsyou == sd.pos1&&ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  "+GameData.weaponHp[0].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[0].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[0].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[0].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[0].ToString();
            }
            //Debug.Log("buki1");
        }
         else if (ss.sannsyou == sd.pos2 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[1].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[1].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[1].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[1].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[1].ToString();
            }
            //Debug.Log("buki2");
        }
        else if (ss.sannsyou == sd.pos3 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[2].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[2].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[2].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[2].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[2].ToString();
            }
            //Debug.Log("buki3");
        }
        
        else if (ss.sannsyou == sd.pos4 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[3].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[3].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[3].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[3].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[3].ToString();
            }
            //Debug.Log("buki4");
        }
        else if (ss.sannsyou == sd.pos5 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[4].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[4].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[4].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[4].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[4].ToString();
            }
            //Debug.Log("buki5");
        }
        else if (ss.sannsyou == sd.pos6 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[5].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[5].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[5].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[5].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[5].ToString();
            }
            //Debug.Log("buki6");
        }
        else if (ss.sannsyou == sd.pos7 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[6].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[6].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[6].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[6].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[6].ToString();
            }
            //Debug.Log("buki7");
        }
        else if (ss.sannsyou == sd.pos8 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[7].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[7].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[7].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[7].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[7].ToString();
            }
            //Debug.Log("buki8");
        }
        else if (ss.sannsyou == sd.pos9 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[8].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[8].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[8].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[8].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[8].ToString();
            }
            //Debug.Log("buki9");
        }
        else if (ss.sannsyou == sd.pos10 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp[9].ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina[9].ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack[9].ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard[9].ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck[9].ToString();
            }
            //Debug.Log("buki10");
        }
    }
}