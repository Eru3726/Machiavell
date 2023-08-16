using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fusionweapontext : MonoBehaviour
{
    public weaponsannsyoufusion ws;
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
                weaponhp.text = "HP  " + GameData.weaponHp[0].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[0].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[0].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[0].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[0].ToString();
        }
        else if (ws.sannsyou == dw.pos2)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[1].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[1].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[1].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[1].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[1].ToString();
        }
        else if (ws.sannsyou == dw.pos3)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[2].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[2].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[2].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[2].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[2].ToString();
        }
        else if (ws.sannsyou == dw.pos4)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[3].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[3].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[3].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[3].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[3].ToString();
        }
        else if (ws.sannsyou == dw.pos5)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[4].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[4].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[4].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[4].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[4].ToString();
        }
        else if (ws.sannsyou == dw.pos6)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[5].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[5].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[5].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[5].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[5].ToString();
        }
        else if (ws.sannsyou == dw.pos7)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[6].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[6].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[6].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[6].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[6].ToString();
        }
        else if (ws.sannsyou == dw.pos8)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[7].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[7].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[7].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[7].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[7].ToString();
        }
        else if (ws.sannsyou == dw.pos9)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[8].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[8].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[8].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[8].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[8].ToString();
        }
        else if (ws.sannsyou == dw.pos10)
        {
            if (weaponhp)
                weaponhp.text = "HP  " + GameData.weaponHp[9].ToString();
            if (weaponstamina)
                weaponstamina.text = "ST  " + GameData.weaponStamina[9].ToString();
            if (weaponoffence)
                weaponoffence.text = "ATK " + GameData.weaponAttack[9].ToString();
            if (weapondeffence)
                weapondeffence.text = "DEF " + GameData.weaponGuard[9].ToString();
            if (weaponluck)
                weaponluck.text = "LUK " + GameData.weaponLuck[9].ToString();
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
