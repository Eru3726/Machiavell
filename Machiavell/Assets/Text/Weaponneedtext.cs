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
                needhp.text = "NHP  " + GameData.weaponneedHp1.ToString();
            if (needstamina)
                needstamina.text = "NST  "+GameData.weaponneedStamina1.ToString();
            if (needoffence)
                needoffence.text = "NATK "+GameData.weaponneedAttack1.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF "+GameData.weaponneedGuard1.ToString();
            if (needluck)
                needluck.text = "NLUK "+GameData.weaponneedLuck1.ToString();
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp2.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina2.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack2.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard2.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck2.ToString();
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp3.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina3.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack3.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard3.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck3.ToString();
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp4.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina4.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack4.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard4.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck4.ToString();
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp5.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina5.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack5.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard5.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck5.ToString();
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp6.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina6.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack6.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard6.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck6.ToString();
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp7.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina7.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack7.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard7.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck7.ToString();
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp8.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina8.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack8.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard8.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck8.ToString();
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp9.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina9.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack9.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard9.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck9.ToString();
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (needhp)
                needhp.text = "NHP  " + GameData.weaponneedHp10.ToString();
            if (needstamina)
                needstamina.text = "NST  " + GameData.weaponneedStamina10.ToString();
            if (needoffence)
                needoffence.text = "NATK " + GameData.weaponneedAttack10.ToString();
            if (needdeffence)
                needdeffence.text = "NDEF " + GameData.weaponneedGuard10.ToString();
            if (needluck)
                needluck.text = "NLUK " + GameData.weaponneedLuck10.ToString();
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
