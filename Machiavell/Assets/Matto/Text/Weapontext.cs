using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapontext : MonoBehaviour
{
    public weaponsannsyoufusion ws;
    public Kyoukasannsyou ks;
    public DropWeapon dw;
    public Text weaponhp;
    public Text weaponstamina;
    public Text weaponoffence;
    public Text weapondeffence;
    public Text weaponluck;
    void Start()
    {
        
    }

    void Update()
    {
        if (ks)
        {
            if (ks.sannsyou == null)
            {
                if (weaponhp)
                    weaponhp.text = "HP";
                if (weaponstamina)
                    weaponstamina.text = "ST";
                if (weaponoffence)
                    weaponoffence.text = "ATK";
                if (weapondeffence)
                    weapondeffence.text = "DEF";
                if (weaponluck)
                    weaponluck.text = "LUK";
            }
            else if (ks.sannsyou == dw.pos1)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp1.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina1.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack1.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard1.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck1.ToString();
            }
            else if (ks.sannsyou == dw.pos2)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp2.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina2.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack2.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard2.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck2.ToString();
            }
            else if (ks.sannsyou == dw.pos3)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp3.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina3.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack3.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard3.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck3.ToString();
            }
            else if (ks.sannsyou == dw.pos4)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp4.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina4.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack4.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard4.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck4.ToString();
            }
            else if (ks.sannsyou == dw.pos5)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp5.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina5.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack5.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard5.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck5.ToString();
            }
            else if (ks.sannsyou == dw.pos6)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp6.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina6.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack6.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard6.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck6.ToString();
            }
            else if (ks.sannsyou == dw.pos7)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp7.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina7.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack7.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard7.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck7.ToString();
            }
            else if (ks.sannsyou == dw.pos8)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp8.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina8.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack8.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard8.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck8.ToString();
            }
            else if (ks.sannsyou == dw.pos9)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp9.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina9.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack9.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard9.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck9.ToString();
            }
            else if (ks.sannsyou == dw.pos10)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp10.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina10.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack10.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard10.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck10.ToString();
            }
            else
            {
                if (weaponhp)
                    weaponhp.text = "HP";
                if (weaponstamina)
                    weaponstamina.text = "ST";
                if (weaponoffence)
                    weaponoffence.text = "ATK";
                if (weapondeffence)
                    weapondeffence.text = "DEF";
                if (weaponluck)
                    weaponluck.text = "LUK";
            }
        }
        else if (ws)
        {
            if (ws.sannsyou == null)
            {
                if (weaponhp)
                    weaponhp.text = "HP";
                if (weaponstamina)
                    weaponstamina.text = "ST";
                if (weaponoffence)
                    weaponoffence.text = "ATK";
                if (weapondeffence)
                    weapondeffence.text = "DEF";
                if (weaponluck)
                    weaponluck.text = "LUK";
            }
            else if (ws.sannsyou == dw.pos1)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp1.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina1.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack1.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard1.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck1.ToString();
            }
            else if (ws.sannsyou == dw.pos2)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp2.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina2.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack2.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard2.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck2.ToString();
            }
            else if (ws.sannsyou == dw.pos3)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp3.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina3.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack3.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard3.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck3.ToString();
            }
            else if (ws.sannsyou == dw.pos4)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp4.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina4.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack4.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard4.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck4.ToString();
            }
            else if (ws.sannsyou == dw.pos5)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp5.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina5.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack5.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard5.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck5.ToString();
            }
            else if (ws.sannsyou == dw.pos6)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp6.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina6.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack6.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard6.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck6.ToString();
            }
            else if (ws.sannsyou == dw.pos7)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp7.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina7.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack7.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard7.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck7.ToString();
            }
            else if (ws.sannsyou == dw.pos8)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp8.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina8.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack8.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard8.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck8.ToString();
            }
            else if (ws.sannsyou == dw.pos9)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp9.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina9.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack9.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard9.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck9.ToString();
            }
            else if (ws.sannsyou == dw.pos10)
            {
                if (weaponhp)
                    weaponhp.text = "HP  " + GameData.weaponHp10.ToString();
                if (weaponstamina)
                    weaponstamina.text = "ST  " + GameData.weaponStamina10.ToString();
                if (weaponoffence)
                    weaponoffence.text = "ATK " + GameData.weaponAttack10.ToString();
                if (weapondeffence)
                    weapondeffence.text = "DEF " + GameData.weaponGuard10.ToString();
                if (weaponluck)
                    weaponluck.text = "LUK " + GameData.weaponLuck10.ToString();
            }
            else
            {
                if (weaponhp)
                    weaponhp.text = "HP";
                if (weaponstamina)
                    weaponstamina.text = "ST";
                if (weaponoffence)
                    weaponoffence.text = "ATK";
                if (weapondeffence)
                    weapondeffence.text = "DEF";
                if (weaponluck)
                    weaponluck.text = "LUK";
            }
        }
    }
}
