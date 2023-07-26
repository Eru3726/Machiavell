using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponstatushuri : MonoBehaviour
{
    public Kyoukasannsyou ks;
    public DropWeapon dw;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void whpup()
    {
        if (ks.sannsyou == null)
        {
            Debug.Log("‚¾‚ß");
        }
        else if (ks.sannsyou == dw.pos1)
        {
            if (GameData.playerhp > GameData.weaponneedHp1)
            {
                GameData.weaponHp1 += 10;
                GameData.playerhp -= GameData.weaponneedHp1;
                GameData.weaponhpcount1 += 1;
                if (GameData.weaponhpcount1 >= 5)
                {
                    GameData.weaponneedHp1 += 10;
                    GameData.weaponhpcount1 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playerhp > GameData.weaponneedHp2)
            {
                GameData.weaponHp2 += 10;
                GameData.playerhp -= GameData.weaponneedHp2;
                GameData.weaponhpcount2 += 1;
                if (GameData.weaponhpcount2 >= 5)
                {
                    GameData.weaponneedHp2 += 10;
                    GameData.weaponhpcount2 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playerhp > GameData.weaponneedHp3)
            {
                GameData.weaponHp3 += 10;
                GameData.playerhp -= GameData.weaponneedHp3;
                GameData.weaponhpcount3 += 1;
                if (GameData.weaponhpcount3 >= 5)
                {
                    GameData.weaponneedHp3 += 10;
                    GameData.weaponhpcount3 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playerhp > GameData.weaponneedHp4)
            {
                GameData.weaponHp4 += 10;
                GameData.playerhp -= GameData.weaponneedHp4;
                GameData.weaponhpcount4 += 1;
                if (GameData.weaponhpcount4 >= 5)
                {
                    GameData.weaponneedHp4 += 10;
                    GameData.weaponhpcount4 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playerhp > GameData.weaponneedHp5)
            {
                GameData.weaponHp5 += 10;
                GameData.playerhp -= GameData.weaponneedHp5;
                GameData.weaponhpcount5 += 1;
                if (GameData.weaponhpcount5 >= 5)
                {
                    GameData.weaponneedHp5 += 10;
                    GameData.weaponhpcount5 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playerhp > GameData.weaponneedHp6)
            {
                GameData.weaponHp6 += 10;
                GameData.playerhp -= GameData.weaponneedHp6;
                GameData.weaponhpcount6 += 1;
                if (GameData.weaponhpcount6 >= 5)
                {
                    GameData.weaponneedHp6 += 10;
                    GameData.weaponhpcount6 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playerhp > GameData.weaponneedHp7)
            {
                GameData.weaponHp7 += 10;
                GameData.playerhp -= GameData.weaponneedHp7;
                GameData.weaponhpcount7 += 1;
                if (GameData.weaponhpcount7 >= 5)
                {
                    GameData.weaponneedHp7 += 10;
                    GameData.weaponhpcount7 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playerhp > GameData.weaponneedHp8)
            {
                GameData.weaponHp8 += 10;
                GameData.playerhp -= GameData.weaponneedHp8;
                GameData.weaponhpcount8 += 1;
                if (GameData.weaponhpcount8 >= 5)
                {
                    GameData.weaponneedHp8 += 10;
                    GameData.weaponhpcount8 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playerhp > GameData.weaponneedHp9)
            {
                GameData.weaponHp9 += 10;
                GameData.playerhp -= GameData.weaponneedHp9;
                GameData.weaponhpcount9 += 1;
                if (GameData.weaponhpcount9 >= 5)
                {
                    GameData.weaponneedHp9 += 10;
                    GameData.weaponhpcount9 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playerhp > GameData.weaponneedHp10)
            {
                GameData.weaponHp10 += 10;
                GameData.playerhp -= GameData.weaponneedHp10;
                GameData.weaponhpcount10 += 1;
                if (GameData.weaponhpcount10 >= 5)
                {
                    GameData.weaponneedHp10 += 10;
                    GameData.weaponhpcount10 = 0;
                }
            }
        }
    }
    public void WSTup()
    {
        if (ks.sannsyou == null)
        {
            Debug.Log("‚¾‚ß");
        }
        else if (ks.sannsyou == dw.pos1)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina1)
            {
                GameData.weaponStamina1 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina1;
                GameData.weaponStaminacount1 += 1;
                if (GameData.weaponStaminacount1 >= 5)
                {
                    GameData.weaponneedStamina1 += 10;
                    GameData.weaponStaminacount1 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina2)
            {
                GameData.weaponStamina2 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina2;
                GameData.weaponStaminacount2 += 1;
                if (GameData.weaponStaminacount2 >= 5)
                {
                    GameData.weaponneedStamina2 += 10;
                    GameData.weaponStaminacount2 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina3)
            {
                GameData.weaponStamina3 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina3;
                GameData.weaponStaminacount3 += 1;
                if (GameData.weaponStaminacount3 >= 5)
                {
                    GameData.weaponneedStamina3 += 10;
                    GameData.weaponStaminacount3 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina4)
            {
                GameData.weaponStamina4 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina4;
                GameData.weaponStaminacount4 += 1;
                if (GameData.weaponStaminacount4 >= 5)
                {
                    GameData.weaponneedStamina4 += 10;
                    GameData.weaponStaminacount4 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina5)
            {
                GameData.weaponStamina5 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina5;
                GameData.weaponStaminacount5 += 1;
                if (GameData.weaponStaminacount5 >= 5)
                {
                    GameData.weaponneedStamina5 += 10;
                    GameData.weaponStaminacount5 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina6)
            {
                GameData.weaponStamina6 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina6;
                GameData.weaponStaminacount6 += 1;
                if (GameData.weaponStaminacount6 >= 5)
                {
                    GameData.weaponneedStamina6 += 10;
                    GameData.weaponStaminacount6 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina7)
            {
                GameData.weaponStamina7 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina7;
                GameData.weaponStaminacount7 += 1;
                if (GameData.weaponStaminacount7 >= 5)
                {
                    GameData.weaponneedStamina7 += 10;
                    GameData.weaponStaminacount7 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina8)
            {
                GameData.weaponStamina8 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina8;
                GameData.weaponStaminacount8 += 1;
                if (GameData.weaponStaminacount8 >= 5)
                {
                    GameData.weaponneedStamina8 += 10;
                    GameData.weaponStaminacount8 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina9)
            {
                GameData.weaponStamina9 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina9;
                GameData.weaponStaminacount9 += 1;
                if (GameData.weaponStaminacount9 >= 5)
                {
                    GameData.weaponneedStamina9 += 10;
                    GameData.weaponStaminacount9 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina10)
            {
                GameData.weaponStamina10 += 10;
                GameData.playerstamina -= GameData.weaponneedStamina10;
                GameData.weaponStaminacount10 += 1;
                if (GameData.weaponStaminacount10 >= 5)
                {
                    GameData.weaponneedStamina10 += 10;
                    GameData.weaponStaminacount10 = 0;
                }
            }
        }
    }
    public void WATKup()
    {
        if (ks.sannsyou == null)
        {
            Debug.Log("‚¾‚ß");
        }
        else if (ks.sannsyou == dw.pos1)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack1)
            {
                GameData.weaponAttack1 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack1;
                GameData.weaponAttackcount1 += 1;
                if (GameData.weaponAttackcount1 >= 5)
                {
                    GameData.weaponneedAttack1 += 1;
                    GameData.weaponAttackcount1 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack2)
            {
                GameData.weaponAttack2 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack2;
                GameData.weaponAttackcount2 += 1;
                if (GameData.weaponAttackcount2 >= 5)
                {
                    GameData.weaponneedAttack2 += 1;
                    GameData.weaponAttackcount2 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack3)
            {
                GameData.weaponAttack3 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack3;
                GameData.weaponAttackcount3 += 1;
                if (GameData.weaponAttackcount3 >= 5)
                {
                    GameData.weaponneedAttack3 += 1;
                    GameData.weaponAttackcount3 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack4)
            {
                GameData.weaponAttack4 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack4;
                GameData.weaponAttackcount4 += 1;
                if (GameData.weaponAttackcount4 >= 5)
                {
                    GameData.weaponneedAttack4 += 1;
                    GameData.weaponAttackcount4 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack5)
            {
                GameData.weaponAttack5 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack5;
                GameData.weaponAttackcount5 += 1;
                if (GameData.weaponAttackcount5 >= 5)
                {
                    GameData.weaponneedAttack5 += 1;
                    GameData.weaponAttackcount5 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack6)
            {
                GameData.weaponAttack6 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack6;
                GameData.weaponAttackcount6 += 1;
                if (GameData.weaponAttackcount6 >= 5)
                {
                    GameData.weaponneedAttack6 += 1;
                    GameData.weaponAttackcount6 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack7)
            {
                GameData.weaponAttack7 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack7;
                GameData.weaponAttackcount7 += 1;
                if (GameData.weaponAttackcount7 >= 5)
                {
                    GameData.weaponneedAttack7 += 1;
                    GameData.weaponAttackcount7 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack8)
            {
                GameData.weaponAttack8 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack8;
                GameData.weaponAttackcount8 += 1;
                if (GameData.weaponAttackcount8 >= 5)
                {
                    GameData.weaponneedAttack8 += 1;
                    GameData.weaponAttackcount8 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack9)
            {
                GameData.weaponAttack9 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack9;
                GameData.weaponAttackcount9 += 1;
                if (GameData.weaponAttackcount9 >= 5)
                {
                    GameData.weaponneedAttack9 += 1;
                    GameData.weaponAttackcount9 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack10)
            {
                GameData.weaponAttack10 += 1;
                GameData.playeroffence -= GameData.weaponneedAttack10;
                GameData.weaponAttackcount10 += 1;
                if (GameData.weaponAttackcount10 >= 5)
                {
                    GameData.weaponneedAttack10 += 1;
                    GameData.weaponAttackcount10 = 0;
                }
            }
        }
    }
    public void WDEFup()
    {
        if (ks.sannsyou == null)
        {
            Debug.Log("‚¾‚ß");
        }
        else if (ks.sannsyou == dw.pos1)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard1)
            {
                GameData.weaponGuard1 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard1;
                GameData.weaponGuardcount1 += 1;
                if (GameData.weaponGuardcount1 >= 5)
                {
                    GameData.weaponneedGuard1 += 1;
                    GameData.weaponGuardcount1 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard2)
            {
                GameData.weaponGuard2 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard2;
                GameData.weaponGuardcount2 += 1;
                if (GameData.weaponGuardcount2 >= 5)
                {
                    GameData.weaponneedGuard1 += 1;
                    GameData.weaponGuardcount1 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard3)
            {
                GameData.weaponGuard3 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard3;
                GameData.weaponGuardcount3 += 1;
                if (GameData.weaponGuardcount3 >= 5)
                {
                    GameData.weaponneedGuard3 += 1;
                    GameData.weaponGuardcount3 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard4)
            {
                GameData.weaponGuard4 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard4;
                GameData.weaponGuardcount4 += 1;
                if (GameData.weaponGuardcount4 >= 5)
                {
                    GameData.weaponneedGuard4 += 1;
                    GameData.weaponGuardcount4 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard5)
            {
                GameData.weaponGuard5 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard5;
                GameData.weaponGuardcount5 += 1;
                if (GameData.weaponGuardcount5 >= 5)
                {
                    GameData.weaponneedGuard5 += 1;
                    GameData.weaponGuardcount5 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard6)
            {
                GameData.weaponGuard6 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard6;
                GameData.weaponGuardcount6 += 1;
                if (GameData.weaponGuardcount6 >= 5)
                {
                    GameData.weaponneedGuard6 += 1;
                    GameData.weaponGuardcount6 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard7)
            {
                GameData.weaponGuard7 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard7;
                GameData.weaponGuardcount7 += 1;
                if (GameData.weaponGuardcount7 >= 5)
                {
                    GameData.weaponneedGuard7 += 1;
                    GameData.weaponGuardcount7 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard8)
            {
                GameData.weaponGuard8 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard8;
                GameData.weaponGuardcount8 += 1;
                if (GameData.weaponGuardcount8 >= 5)
                {
                    GameData.weaponneedGuard8 += 1;
                    GameData.weaponGuardcount8 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard9)
            {
                GameData.weaponGuard9 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard9;
                GameData.weaponGuardcount9 += 1;
                if (GameData.weaponGuardcount9 >= 5)
                {
                    GameData.weaponneedGuard9 += 1;
                    GameData.weaponGuardcount9 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard10)
            {
                GameData.weaponGuard10 += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard10;
                GameData.weaponGuardcount10 += 1;
                if (GameData.weaponGuardcount10 >= 5)
                {
                    GameData.weaponneedGuard10 += 1;
                    GameData.weaponGuardcount10 = 0;
                }
            }
        }
    }
    public void WLUKup()
    {
        if (ks.sannsyou == null)
        {
            Debug.Log("‚¾‚ß");
        }
        else if (ks.sannsyou == dw.pos1)
        {
            if (GameData.playerluck > GameData.weaponneedLuck1)
            {
                GameData.weaponLuck1 += 1;
                GameData.playerluck -= GameData.weaponneedLuck1;
                GameData.weaponLuckcount1 += 1;
                if (GameData.weaponLuckcount1 >= 5)
                {
                    GameData.weaponneedLuck1 += 1;
                    GameData.weaponLuckcount1 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playerluck > GameData.weaponneedLuck2)
            {
                GameData.weaponLuck2 += 1;
                GameData.playerluck -= GameData.weaponneedLuck2;
                GameData.weaponLuckcount2 += 1;
                if (GameData.weaponLuckcount2 >= 5)
                {
                    GameData.weaponneedLuck2 += 1;
                    GameData.weaponLuckcount2 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playerluck > GameData.weaponneedLuck3)
            {
                GameData.weaponLuck3 += 1;
                GameData.playerluck -= GameData.weaponneedLuck3;
                GameData.weaponLuckcount3 += 1;
                if (GameData.weaponLuckcount3 >= 5)
                {
                    GameData.weaponneedLuck3 += 1;
                    GameData.weaponLuckcount3 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playerluck > GameData.weaponneedLuck4)
            {
                GameData.weaponLuck4 += 1;
                GameData.playerluck -= GameData.weaponneedLuck4;
                GameData.weaponLuckcount4 += 1;
                if (GameData.weaponLuckcount4 >= 5)
                {
                    GameData.weaponneedLuck4 += 1;
                    GameData.weaponLuckcount4 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playerluck > GameData.weaponneedLuck5)
            {
                GameData.weaponLuck5 += 1;
                GameData.playerluck -= GameData.weaponneedLuck5;
                GameData.weaponLuckcount5 += 1;
                if (GameData.weaponLuckcount5 >= 5)
                {
                    GameData.weaponneedLuck5 += 1;
                    GameData.weaponLuckcount5 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playerluck > GameData.weaponneedLuck6)
            {
                GameData.weaponLuck6 += 1;
                GameData.playerluck -= GameData.weaponneedLuck6;
                GameData.weaponLuckcount6 += 1;
                if (GameData.weaponLuckcount6 >= 5)
                {
                    GameData.weaponneedLuck6 += 1;
                    GameData.weaponLuckcount6 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playerluck > GameData.weaponneedLuck7)
            {
                GameData.weaponLuck7 += 1;
                GameData.playerluck -= GameData.weaponneedLuck7;
                GameData.weaponLuckcount7 += 1;
                if (GameData.weaponLuckcount7 >= 5)
                {
                    GameData.weaponneedLuck7 += 1;
                    GameData.weaponLuckcount7 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playerluck > GameData.weaponneedLuck8)
            {
                GameData.weaponLuck8 += 1;
                GameData.playerluck -= GameData.weaponneedLuck8;
                GameData.weaponLuckcount8 += 1;
                if (GameData.weaponLuckcount8 >= 5)
                {
                    GameData.weaponneedLuck8 += 1;
                    GameData.weaponLuckcount8 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playerluck > GameData.weaponneedLuck9)
            {
                GameData.weaponLuck9 += 1;
                GameData.playerluck -= GameData.weaponneedLuck9;
                GameData.weaponLuckcount9 += 1;
                if (GameData.weaponLuckcount9 >= 5)
                {
                    GameData.weaponneedLuck9 += 1;
                    GameData.weaponLuckcount9 = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playerluck > GameData.weaponneedLuck10)
            {
                GameData.weaponLuck10 += 1;
                GameData.playerluck -= GameData.weaponneedLuck10;
                GameData.weaponLuckcount10 += 1;
                if (GameData.weaponLuckcount10 >= 5)
                {
                    GameData.weaponneedLuck10 += 1;
                    GameData.weaponLuckcount10 = 0;
                }
            }
        }
    }
    public void statusreset()
    {
        GameData.weaponHp1 = 10;
        GameData.weaponHp2 = 10;
        GameData.weaponHp3 = 10;
        GameData.weaponHp4 = 10;
        GameData.weaponHp5 = 10;
        GameData.weaponHp6 = 10;
        GameData.weaponHp7 = 10;
        GameData.weaponHp8 = 10;
        GameData.weaponHp9 = 10;
        GameData.weaponHp10 = 10;
        GameData.weaponneedHp1 = 10;
        GameData.weaponneedHp2 = 10;
        GameData.weaponneedHp3 = 10;
        GameData.weaponneedHp4 = 10;
        GameData.weaponneedHp5 = 10;
        GameData.weaponneedHp6 = 10;
        GameData.weaponneedHp7 = 10;
        GameData.weaponneedHp8 = 10;
        GameData.weaponneedHp9 = 10;
        GameData.weaponneedHp10 = 10;
        GameData.weaponhpcount1 = 0;
        GameData.weaponhpcount2 = 0;
        GameData.weaponhpcount3 = 0;
        GameData.weaponhpcount4 = 0;
        GameData.weaponhpcount5 = 0;
        GameData.weaponhpcount6 = 0;
        GameData.weaponhpcount7 = 0;
        GameData.weaponhpcount8 = 0;
        GameData.weaponhpcount9 = 0;
        GameData.weaponhpcount10 = 0;

        GameData.weaponStamina1 = 10;
        GameData.weaponStamina2 = 10;
        GameData.weaponStamina3 = 10;
        GameData.weaponStamina4 = 10;
        GameData.weaponStamina5 = 10;
        GameData.weaponStamina6 = 10;
        GameData.weaponStamina7 = 10;
        GameData.weaponStamina8 = 10;
        GameData.weaponStamina9 = 10;
        GameData.weaponStamina10 = 10;
        GameData.weaponneedStamina1 = 10;
        GameData.weaponneedStamina2 = 10;
        GameData.weaponneedStamina3 = 10;
        GameData.weaponneedStamina4 = 10;
        GameData.weaponneedStamina5 = 10;
        GameData.weaponneedStamina6 = 10;
        GameData.weaponneedStamina7 = 10;
        GameData.weaponneedStamina8 = 10;
        GameData.weaponneedStamina9 = 10;
        GameData.weaponneedStamina10 = 10;
        GameData.weaponStaminacount1 = 0;
        GameData.weaponStaminacount2 = 0;
        GameData.weaponStaminacount3 = 0;
        GameData.weaponStaminacount4 = 0;
        GameData.weaponStaminacount5 = 0;
        GameData.weaponStaminacount6 = 0;
        GameData.weaponStaminacount7 = 0;
        GameData.weaponStaminacount8 = 0;
        GameData.weaponStaminacount9 = 0;
        GameData.weaponStaminacount10 = 0;

        GameData.weaponAttack1 = 1;
        GameData.weaponAttack2 = 1;
        GameData.weaponAttack3 = 1;
        GameData.weaponAttack4 = 1;
        GameData.weaponAttack5 = 1;
        GameData.weaponAttack6 = 1;
        GameData.weaponAttack7 = 1;
        GameData.weaponAttack8 = 1;
        GameData.weaponAttack9 = 1;
        GameData.weaponAttack10 = 1;
        GameData.weaponneedAttack1 = 1;
        GameData.weaponneedAttack2 = 1;
        GameData.weaponneedAttack3 = 1;
        GameData.weaponneedAttack4 = 1;
        GameData.weaponneedAttack5 = 1;
        GameData.weaponneedAttack6 = 1;
        GameData.weaponneedAttack7 = 1;
        GameData.weaponneedAttack8 = 1;
        GameData.weaponneedAttack9 = 1;
        GameData.weaponneedAttack10 = 1;
        GameData.weaponAttackcount1 = 1;
        GameData.weaponAttackcount2 = 1;
        GameData.weaponAttackcount3 = 1;
        GameData.weaponAttackcount4 = 1;
        GameData.weaponAttackcount5 = 1;
        GameData.weaponAttackcount6 = 1;
        GameData.weaponAttackcount7 = 1;
        GameData.weaponAttackcount8 = 1;
        GameData.weaponAttackcount9 = 1;
        GameData.weaponAttackcount10 = 1;

        GameData.weaponGuard1 = 1;
        GameData.weaponGuard2 = 1;
        GameData.weaponGuard3 = 1;
        GameData.weaponGuard4 = 1;
        GameData.weaponGuard5 = 1;
        GameData.weaponGuard6 = 1;
        GameData.weaponGuard7 = 1;
        GameData.weaponGuard8 = 1;
        GameData.weaponGuard9 = 1;
        GameData.weaponGuard10 = 1;
        GameData.weaponneedGuard1 = 1;
        GameData.weaponneedGuard2 = 1;
        GameData.weaponneedGuard3 = 1;
        GameData.weaponneedGuard4 = 1;
        GameData.weaponneedGuard5 = 1;
        GameData.weaponneedGuard6 = 1;
        GameData.weaponneedGuard7 = 1;
        GameData.weaponneedGuard8 = 1;
        GameData.weaponneedGuard9 = 1;
        GameData.weaponneedGuard10 = 1;
        GameData.weaponGuardcount1 = 0;
        GameData.weaponGuardcount2 = 0;
        GameData.weaponGuardcount3 = 0;
        GameData.weaponGuardcount4 = 0;
        GameData.weaponGuardcount5 = 0;
        GameData.weaponGuardcount6 = 0;
        GameData.weaponGuardcount7 = 0;
        GameData.weaponGuardcount8 = 0;
        GameData.weaponGuardcount9 = 0;
        GameData.weaponGuardcount10 = 0;

        GameData.weaponLuck1 = 1;
        GameData.weaponLuck2 = 1;
        GameData.weaponLuck3 = 1;
        GameData.weaponLuck4 = 1;
        GameData.weaponLuck5 = 1;
        GameData.weaponLuck6 = 1;
        GameData.weaponLuck7 = 1;
        GameData.weaponLuck8 = 1;
        GameData.weaponLuck9 = 1;
        GameData.weaponLuck10 = 1;
        GameData.weaponneedLuck1 = 1;
        GameData.weaponneedLuck2 = 1;
        GameData.weaponneedLuck3 = 1;
        GameData.weaponneedLuck4 = 1;
        GameData.weaponneedLuck5 = 1;
        GameData.weaponneedLuck6 = 1;
        GameData.weaponneedLuck7 = 1;
        GameData.weaponneedLuck8 = 1;
        GameData.weaponneedLuck9 = 1;
        GameData.weaponneedLuck10 = 1;
        GameData.weaponLuckcount1 = 0;
        GameData.weaponLuckcount2 = 0;
        GameData.weaponLuckcount3 = 0;
        GameData.weaponLuckcount4 = 0;
        GameData.weaponLuckcount5 = 0;
        GameData.weaponLuckcount6 = 0;
        GameData.weaponLuckcount7 = 0;
        GameData.weaponLuckcount8 = 0;
        GameData.weaponLuckcount9 = 0;
        GameData.weaponLuckcount10 = 0;
    }
}

