using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slotstatusdeth : MonoBehaviour
{
    public Slotsannsyou ss;
    public Slotdrop sd;
    private float dcount;
    public bool notdeth = false;

    void Start()
    {

    }

    void Update()
    {

    }
    public void destroy()
    {
        notdeth = false;
        dcount = 0;
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
            Debug.Log("•Ší‚ª‚È‚­‚È‚é‚©‚çƒ_ƒ");
            notdeth = true;
        }
        if (ss.sannsyou == sd.pos1)
        {
            if (GameData.soubi == 1)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp1 = 10;
                GameData.weaponneedHp1 = 10;
                GameData.weaponhpcount1 = 0;
                GameData.weaponStamina1 = 10;
                GameData.weaponneedStamina1 = 10;
                GameData.weaponStaminacount1 = 0;
                GameData.weaponAttack1 = 1;
                GameData.weaponneedAttack1 = 1;
                GameData.weaponAttackcount1 = 0;
                GameData.weaponGuard1 = 1;
                GameData.weaponneedGuard1 = 1;
                GameData.weaponGuardcount1 = 0;
                GameData.weaponLuck1 = 1;
                GameData.weaponneedLuck1 = 1;
                GameData.weaponLuckcount1 = 0;
            }
        }
        else if (ss.sannsyou == sd.pos2)
        {
            if (GameData.soubi == 2)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp2 = 10;
                GameData.weaponneedHp2 = 10;
                GameData.weaponhpcount2 = 0;
                GameData.weaponStamina2 = 10;
                GameData.weaponneedStamina2 = 10;
                GameData.weaponStaminacount2 = 0;
                GameData.weaponAttack2 = 1;
                GameData.weaponneedAttack2 = 1;
                GameData.weaponAttackcount2 = 0;
                GameData.weaponGuard2 = 1;
                GameData.weaponneedGuard2 = 1;
                GameData.weaponGuardcount2 = 0;
                GameData.weaponLuck2 = 1;
                GameData.weaponneedLuck2 = 1;
                GameData.weaponLuckcount2 = 0;
                Debug.Log("ƒXƒe[ƒ^ƒXDESU!!");
            }
        }
        else if (ss.sannsyou == sd.pos3)
        {
            if (GameData.soubi == 3)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp3 = 10;
                GameData.weaponneedHp3 = 10;
                GameData.weaponhpcount3 = 0;
                GameData.weaponStamina3 = 10;
                GameData.weaponneedStamina3 = 10;
                GameData.weaponStaminacount3 = 0;
                GameData.weaponAttack3 = 1;
                GameData.weaponneedAttack3 = 1;
                GameData.weaponAttackcount3 = 0;
                GameData.weaponGuard3 = 1;
                GameData.weaponneedGuard3 = 1;
                GameData.weaponGuardcount3 = 0;
                GameData.weaponLuck3 = 1;
                GameData.weaponneedLuck3 = 1;
                GameData.weaponLuckcount3 = 0;
            }
        }
        else if (ss.sannsyou == sd.pos4)
        {
            if (GameData.soubi == 4)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp4 = 10;
                GameData.weaponneedHp4 = 10;
                GameData.weaponhpcount4 = 0;
                GameData.weaponStamina4 = 10;
                GameData.weaponneedStamina4 = 10;
                GameData.weaponStaminacount4 = 0;
                GameData.weaponAttack4 = 1;
                GameData.weaponneedAttack4 = 1;
                GameData.weaponAttackcount4 = 0;
                GameData.weaponGuard4 = 1;
                GameData.weaponneedGuard4 = 1;
                GameData.weaponGuardcount4 = 0;
                GameData.weaponLuck4 = 1;
                GameData.weaponneedLuck4 = 1;
                GameData.weaponLuckcount4 = 0;
            }
        }
        else if (ss.sannsyou == sd.pos5)
        {
            if (GameData.soubi == 5)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp5 = 10;
                GameData.weaponneedHp5 = 10;
                GameData.weaponhpcount5 = 0;
                GameData.weaponStamina5 = 10;
                GameData.weaponneedStamina5 = 10;
                GameData.weaponStaminacount5 = 0;
                GameData.weaponAttack5 = 1;
                GameData.weaponneedAttack5 = 1;
                GameData.weaponAttackcount5 = 0;
                GameData.weaponGuard5 = 1;
                GameData.weaponneedGuard5 = 1;
                GameData.weaponGuardcount5 = 0;
                GameData.weaponLuck5 = 1;
                GameData.weaponneedLuck5 = 1;
                GameData.weaponLuckcount5 = 0;
            }
        }
        else if (ss.sannsyou == sd.pos6)
        {
            if (GameData.soubi == 6)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp6 = 10;
                GameData.weaponneedHp6 = 10;
                GameData.weaponhpcount6 = 0;
                GameData.weaponStamina6 = 10;
                GameData.weaponneedStamina6 = 10;
                GameData.weaponStaminacount6 = 0;
                GameData.weaponAttack6 = 1;
                GameData.weaponneedAttack6 = 1;
                GameData.weaponAttackcount6 = 0;
                GameData.weaponGuard6 = 1;
                GameData.weaponneedGuard6 = 1;
                GameData.weaponGuardcount6 = 0;
                GameData.weaponLuck6 = 1;
                GameData.weaponneedLuck6 = 1;
                GameData.weaponLuckcount6 = 0;
            }
        }
        else if (ss.sannsyou == sd.pos7)
        {
            if (GameData.soubi == 7)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp7 = 10;
                GameData.weaponneedHp7 = 10;
                GameData.weaponhpcount7 = 0;
                GameData.weaponStamina7 = 10;
                GameData.weaponneedStamina7 = 10;
                GameData.weaponStaminacount7 = 0;
                GameData.weaponAttack7 = 1;
                GameData.weaponneedAttack7 = 1;
                GameData.weaponAttackcount7 = 0;
                GameData.weaponGuard7 = 1;
                GameData.weaponneedGuard7 = 1;
                GameData.weaponGuardcount7 = 0;
                GameData.weaponLuck7 = 1;
                GameData.weaponneedLuck7 = 1;
                GameData.weaponLuckcount7 = 0;
            }
        }
        else if (ss.sannsyou == sd.pos8)
        {
            if (GameData.soubi == 8)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp8 = 10;
                GameData.weaponneedHp8 = 10;
                GameData.weaponhpcount8 = 0;
                GameData.weaponStamina8 = 10;
                GameData.weaponneedStamina8 = 10;
                GameData.weaponStaminacount8 = 0;
                GameData.weaponAttack8 = 1;
                GameData.weaponneedAttack8 = 1;
                GameData.weaponAttackcount8 = 0;
                GameData.weaponGuard8 = 1;
                GameData.weaponneedGuard8 = 1;
                GameData.weaponGuardcount8 = 0;
                GameData.weaponLuck8 = 1;
                GameData.weaponneedLuck8 = 1;
                GameData.weaponLuckcount8 = 0;
            }
        }
        else if (ss.sannsyou == sd.pos9)
        {
            if (GameData.soubi == 9)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp9 = 10;
                GameData.weaponneedHp9 = 10;
                GameData.weaponhpcount9 = 0;
                GameData.weaponStamina9 = 10;
                GameData.weaponneedStamina9 = 10;
                GameData.weaponStaminacount9 = 0;
                GameData.weaponAttack9 = 1;
                GameData.weaponneedAttack9 = 1;
                GameData.weaponAttackcount9 = 0;
                GameData.weaponGuard9 = 1;
                GameData.weaponneedGuard9 = 1;
                GameData.weaponGuardcount9 = 0;
                GameData.weaponLuck9 = 1;
                GameData.weaponneedLuck9 = 1;
                GameData.weaponLuckcount9 = 0;
            }
        }
        else if (ss.sannsyou == sd.pos10)
        {
            if (GameData.soubi == 10)
            {
                Debug.Log("”jŠü‚¾‚ß");
                notdeth = true;
            }
            else
            {
                GameData.weaponHp10 = 10;
                GameData.weaponneedHp10 = 10;
                GameData.weaponhpcount10 = 0;
                GameData.weaponStamina10 = 10;
                GameData.weaponneedStamina10 = 10;
                GameData.weaponStaminacount10 = 0;
                GameData.weaponAttack10 = 1;
                GameData.weaponneedAttack10 = 1;
                GameData.weaponAttackcount10 = 0;
                GameData.weaponGuard10 = 1;
                GameData.weaponneedGuard10 = 1;
                GameData.weaponGuardcount10 = 0;
                GameData.weaponLuck10 = 1;
                GameData.weaponneedLuck10 = 1;
                GameData.weaponLuckcount10 = 0;
            }
        }
    }
}
