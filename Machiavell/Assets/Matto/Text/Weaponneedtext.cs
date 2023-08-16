using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weaponneedtext : MonoBehaviour
{
    public Kyoukasannsyou ks;
    public DropWeapon dw;
    public Text needhp;
    public Text needstamina;
    public Text needoffence;
    public Text needdeffence;
    public Text needluck;
    void Start()
    {
        
    }

    void Update()
    {
        if (ks.sannsyou == null)
        {
            if (needhp)
                needhp.text = "NHP  ";
            if (needstamina)
                needstamina.text = "NST  ";
            if (needoffence)
                needoffence.text = "NATK ";
            if (needdeffence)
                needdeffence.text = "NDEF ";
            if (needluck)
                needluck.text = "NLUK ";
        }
        else if(ks.sannsyou == dw.pos1) 
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[0].ToString();
            if (needstamina)
                needstamina.text = "NST  "+GameData.weaponneedStamina[0].ToString();
            if (needoffence)
                needoffence.text = "NATK "+GameData.weaponneedAttack[0].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF "+GameData.weaponneedGuard[0].ToString();
            if (needluck)
                needluck.text = "NLUK "+GameData.weaponneedLuck[0].ToString();
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[1].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[1].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[1].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[1].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[1].ToString();
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[2].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[2].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[2].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[2].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[2].ToString();
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[3].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[3].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[3].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[3].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[3].ToString();
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[4].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[4].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[4].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[4].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[4].ToString();
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[5].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[5].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[5].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[5].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[5].ToString();
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[6].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[6].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[6].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[6].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[6].ToString();
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[7].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[7].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[7].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[7].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[7].ToString();
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[8].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[8].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[8].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[8].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[8].ToString();
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp[9].ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina[9].ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack[9].ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard[9].ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck[9].ToString();
        }
        else
        {
            if (needhp)
                needhp.text = "NHP  ";
            if (needstamina)
                needstamina.text = "NST  ";
            if (needoffence)
                needoffence.text = "NATK ";
            if (needdeffence)
                needdeffence.text = "NDEF ";
            if (needluck)
                needluck.text = "NLUK ";
        }
    }
}
