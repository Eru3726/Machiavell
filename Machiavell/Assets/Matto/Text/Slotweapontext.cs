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
                hp.text = "HP  "+GameData.weaponHp1.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina1.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack1.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard1.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck1.ToString();
            }
            //Debug.Log("buki1");
        }
         else if (ss.sannsyou == sd.pos2 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp2.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina2.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack2.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard2.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck2.ToString();
            }
            //Debug.Log("buki2");
        }
        else if (ss.sannsyou == sd.pos3 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp3.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina3.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack3.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard3.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck3.ToString();
            }
            //Debug.Log("buki3");
        }
        
        else if (ss.sannsyou == sd.pos4 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp4.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina4.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack4.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard4.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck4.ToString();
            }
            //Debug.Log("buki4");
        }
        else if (ss.sannsyou == sd.pos5 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp5.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina5.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack5.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard5.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck5.ToString();
            }
            //Debug.Log("buki5");
        }
        else if (ss.sannsyou == sd.pos6 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp6.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina6.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack6.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard6.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck6.ToString();
            }
            //Debug.Log("buki6");
        }
        else if (ss.sannsyou == sd.pos7 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp7.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina7.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack7.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard7.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck7.ToString();
            }
            //Debug.Log("buki7");
        }
        else if (ss.sannsyou == sd.pos8 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp8.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina8.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack8.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard8.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck8.ToString();
            }
            //Debug.Log("buki8");
        }
        else if (ss.sannsyou == sd.pos9 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp9.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina9.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack9.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard9.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck9.ToString();
            }
            //Debug.Log("buki9");
        }
        else if (ss.sannsyou == sd.pos10 && ss.sannsyou)
        {
            if (hp)
            {
                hp.text = "HP  " + GameData.weaponHp10.ToString();
            }
            if (st)
            {
                st.text = "ST  " + GameData.weaponStamina10.ToString();
            }
            if (atk)
            {
                atk.text = "ATK " + GameData.weaponAttack10.ToString();
            }
            if (def)
            {
                def.text = "DEF " + GameData.weaponGuard10.ToString();
            }
            if (luk)
            {
                luk.text = "LUK " + GameData.weaponLuck10.ToString();
            }
            //Debug.Log("buki10");
        }
    }
}