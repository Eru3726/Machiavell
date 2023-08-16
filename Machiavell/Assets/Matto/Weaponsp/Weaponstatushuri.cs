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
            if (GameData.playerhp > GameData.weaponneedHp[0])
            {
                GameData.weaponHp[0] += 10;
                GameData.playerhp -= GameData.weaponneedHp[0];
                GameData.weaponhpcount[0] += 1;
                if (GameData.weaponhpcount[0] >= 5)
                {
                    GameData.weaponneedHp[0] += 10;
                    GameData.weaponhpcount[0] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playerhp > GameData.weaponneedHp[1])
            {
                GameData.weaponHp[1] += 10;
                GameData.playerhp -= GameData.weaponneedHp[1];
                GameData.weaponhpcount[1] += 1;
                if (GameData.weaponhpcount[1] >= 5)
                {
                    GameData.weaponneedHp[1] += 10;
                    GameData.weaponhpcount[1] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playerhp > GameData.weaponneedHp[2])
            {
                GameData.weaponHp[2] += 10;
                GameData.playerhp -= GameData.weaponneedHp[2];
                GameData.weaponhpcount[2] += 1;
                if (GameData.weaponhpcount[2] >= 5)
                {
                    GameData.weaponneedHp[2] += 10;
                    GameData.weaponhpcount[2] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playerhp > GameData.weaponneedHp[3])
            {
                GameData.weaponHp[3] += 10;
                GameData.playerhp -= GameData.weaponneedHp[3];
                GameData.weaponhpcount[3] += 1;
                if (GameData.weaponhpcount[3] >= 5)
                {
                    GameData.weaponneedHp[3] += 10;
                    GameData.weaponhpcount[3] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playerhp > GameData.weaponneedHp[4])
            {
                GameData.weaponHp[4] += 10;
                GameData.playerhp -= GameData.weaponneedHp[4];
                GameData.weaponhpcount[4] += 1;
                if (GameData.weaponhpcount[4] >= 5)
                {
                    GameData.weaponneedHp[4] += 10;
                    GameData.weaponhpcount[4] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playerhp > GameData.weaponneedHp[5])
            {
                GameData.weaponHp[5] += 10;
                GameData.playerhp -= GameData.weaponneedHp[5];
                GameData.weaponhpcount[5] += 1;
                if (GameData.weaponhpcount[5] >= 5)
                {
                    GameData.weaponneedHp[5] += 10;
                    GameData.weaponhpcount[5] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playerhp > GameData.weaponneedHp[6])
            {
                GameData.weaponHp[6] += 10;
                GameData.playerhp -= GameData.weaponneedHp[6];
                GameData.weaponhpcount[6] += 1;
                if (GameData.weaponhpcount[6] >= 5)
                {
                    GameData.weaponneedHp[6] += 10;
                    GameData.weaponhpcount[6] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playerhp > GameData.weaponneedHp[7])
            {
                GameData.weaponHp[7] += 10;
                GameData.playerhp -= GameData.weaponneedHp[7];
                GameData.weaponhpcount[7] += 1;
                if (GameData.weaponhpcount[7] >= 5)
                {
                    GameData.weaponneedHp[7] += 10;
                    GameData.weaponhpcount[7] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playerhp > GameData.weaponneedHp[8])
            {
                GameData.weaponHp[8] += 10;
                GameData.playerhp -= GameData.weaponneedHp[8];
                GameData.weaponhpcount[8] += 1;
                if (GameData.weaponhpcount[8] >= 5)
                {
                    GameData.weaponneedHp[8] += 10;
                    GameData.weaponhpcount[8] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playerhp > GameData.weaponneedHp[9])
            {
                GameData.weaponHp[9] += 10;
                GameData.playerhp -= GameData.weaponneedHp[9];
                GameData.weaponhpcount[9] += 1;
                if (GameData.weaponhpcount[9] >= 5)
                {
                    GameData.weaponneedHp[9] += 10;
                    GameData.weaponhpcount[9] = 0;
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
            if (GameData.playerstamina > GameData.weaponneedStamina[0])
            {
                GameData.weaponStamina[0] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[0];
                GameData.weaponStaminacount[0] += 1;
                if (GameData.weaponStaminacount[0] >= 5)
                {
                    GameData.weaponneedStamina[0] += 10;
                    GameData.weaponStaminacount[0] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[1])
            {
                GameData.weaponStamina[1] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[1];
                GameData.weaponStaminacount[1] += 1;
                if (GameData.weaponStaminacount[1] >= 5)
                {
                    GameData.weaponneedStamina[1] += 10;
                    GameData.weaponStaminacount[1] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[2])
            {
                GameData.weaponStamina[2] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[2];
                GameData.weaponStaminacount[2] += 1;
                if (GameData.weaponStaminacount[2] >= 5)
                {
                    GameData.weaponneedStamina[2] += 10;
                    GameData.weaponStaminacount[2] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[3])
            {
                GameData.weaponStamina[3] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[3];
                GameData.weaponStaminacount[3] += 1;
                if (GameData.weaponStaminacount[3] >= 5)
                {
                    GameData.weaponneedStamina[3] += 10;
                    GameData.weaponStaminacount[3] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[4])
            {
                GameData.weaponStamina[4] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[4];
                GameData.weaponStaminacount[4] += 1;
                if (GameData.weaponStaminacount[4] >= 5)
                {
                    GameData.weaponneedStamina[4] += 10;
                    GameData.weaponStaminacount[4] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[5])
            {
                GameData.weaponStamina[5] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[5];
                GameData.weaponStaminacount[5] += 1;
                if (GameData.weaponStaminacount[5] >= 5)
                {
                    GameData.weaponneedStamina[5] += 10;
                    GameData.weaponStaminacount[5] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[6])
            {
                GameData.weaponStamina[6] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[6];
                GameData.weaponStaminacount[6] += 1;
                if (GameData.weaponStaminacount[6] >= 5)
                {
                    GameData.weaponneedStamina[6] += 10;
                    GameData.weaponStaminacount[6] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[7])
            {
                GameData.weaponStamina[7] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[7];
                GameData.weaponStaminacount[7] += 1;
                if (GameData.weaponStaminacount[7] >= 5)
                {
                    GameData.weaponneedStamina[7] += 10;
                    GameData.weaponStaminacount[7] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[8])
            {
                GameData.weaponStamina[8] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[8];
                GameData.weaponStaminacount[8] += 1;
                if (GameData.weaponStaminacount[8] >= 5)
                {
                    GameData.weaponneedStamina[8] += 10;
                    GameData.weaponStaminacount[8] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playerstamina > GameData.weaponneedStamina[9])
            {
                GameData.weaponStamina[9] += 10;
                GameData.playerstamina -= GameData.weaponneedStamina[9];
                GameData.weaponStaminacount[9] += 1;
                if (GameData.weaponStaminacount[9] >= 5)
                {
                    GameData.weaponneedStamina[9] += 10;
                    GameData.weaponStaminacount[9] = 0;
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
            if (GameData.playeroffence > GameData.weaponneedAttack[0])
            {
                GameData.weaponAttack[0] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[0];
                GameData.weaponAttackcount[0] += 1;
                if (GameData.weaponAttackcount[0] >= 5)
                {
                    GameData.weaponneedAttack[0] += 1;
                    GameData.weaponAttackcount[0] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[1])
            {
                GameData.weaponAttack[1] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[1];
                GameData.weaponAttackcount[1] += 1;
                if (GameData.weaponAttackcount[1] >= 5)
                {
                    GameData.weaponneedAttack[1] += 1;
                    GameData.weaponAttackcount[1] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[2])
            {
                GameData.weaponAttack[2] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[2];
                GameData.weaponAttackcount[2] += 1;
                if (GameData.weaponAttackcount[2] >= 5)
                {
                    GameData.weaponneedAttack[2] += 1;
                    GameData.weaponAttackcount[2] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[3])
            {
                GameData.weaponAttack[3] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[3];
                GameData.weaponAttackcount[3] += 1;
                if (GameData.weaponAttackcount[3] >= 5)
                {
                    GameData.weaponneedAttack[3] += 1;
                    GameData.weaponAttackcount[3] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[4])
            {
                GameData.weaponAttack[4] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[4];
                GameData.weaponAttackcount[4] += 1;
                if (GameData.weaponAttackcount[4] >= 5)
                {
                    GameData.weaponneedAttack[4] += 1;
                    GameData.weaponAttackcount[4] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[5])
            {
                GameData.weaponAttack[5] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[5];
                GameData.weaponAttackcount[5] += 1;
                if (GameData.weaponAttackcount[5] >= 5)
                {
                    GameData.weaponneedAttack[5] += 1;
                    GameData.weaponAttackcount[5] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[6])
            {
                GameData.weaponAttack[6] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[6];
                GameData.weaponAttackcount[6] += 1;
                if (GameData.weaponAttackcount[6] >= 5)
                {
                    GameData.weaponneedAttack[6] += 1;
                    GameData.weaponAttackcount[6] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[7])
            {
                GameData.weaponAttack[7] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[7];
                GameData.weaponAttackcount[7] += 1;
                if (GameData.weaponAttackcount[7] >= 5)
                {
                    GameData.weaponneedAttack[7] += 1;
                    GameData.weaponAttackcount[7] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[8])
            {
                GameData.weaponAttack[8] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[8];
                GameData.weaponAttackcount[8] += 1;
                if (GameData.weaponAttackcount[8] >= 5)
                {
                    GameData.weaponneedAttack[8] += 1;
                    GameData.weaponAttackcount[8] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playeroffence > GameData.weaponneedAttack[9])
            {
                GameData.weaponAttack[9] += 1;
                GameData.playeroffence -= GameData.weaponneedAttack[9];
                GameData.weaponAttackcount[9] += 1;
                if (GameData.weaponAttackcount[9] >= 5)
                {
                    GameData.weaponneedAttack[9] += 1;
                    GameData.weaponAttackcount[9] = 0;
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
            if (GameData.playerdeffence > GameData.weaponneedGuard[0])
            {
                GameData.weaponGuard[0] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[0];
                GameData.weaponGuardcount[0] += 1;
                if (GameData.weaponGuardcount[0] >= 5)
                {
                    GameData.weaponneedGuard[0] += 1;
                    GameData.weaponGuardcount[0] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[1])
            {
                GameData.weaponGuard[1] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[1];
                GameData.weaponGuardcount[1] += 1;
                if (GameData.weaponGuardcount[1] >= 5)
                {
                    GameData.weaponneedGuard[1] += 1;
                    GameData.weaponGuardcount[1] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[2])
            {
                GameData.weaponGuard[2] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[2];
                GameData.weaponGuardcount[2] += 1;
                if (GameData.weaponGuardcount[2] >= 5)
                {
                    GameData.weaponneedGuard[2] += 1;
                    GameData.weaponGuardcount[2] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[3])
            {
                GameData.weaponGuard[3] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[3];
                GameData.weaponGuardcount[3] += 1;
                if (GameData.weaponGuardcount[3] >= 5)
                {
                    GameData.weaponneedGuard[3] += 1;
                    GameData.weaponGuardcount[3] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[4])
            {
                GameData.weaponGuard[4] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[4];
                GameData.weaponGuardcount[4] += 1;
                if (GameData.weaponGuardcount[4] >= 5)
                {
                    GameData.weaponneedGuard[4] += 1;
                    GameData.weaponGuardcount[4] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[5])
            {
                GameData.weaponGuard[5] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[5];
                GameData.weaponGuardcount[5] += 1;
                if (GameData.weaponGuardcount[5] >= 5)
                {
                    GameData.weaponneedGuard[5] += 1;
                    GameData.weaponGuardcount[5] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[6])
            {
                GameData.weaponGuard[6] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[6];
                GameData.weaponGuardcount[6] += 1;
                if (GameData.weaponGuardcount[6] >= 5)
                {
                    GameData.weaponneedGuard[6] += 1;
                    GameData.weaponGuardcount[6] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[7])
            {
                GameData.weaponGuard[7] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[7];
                GameData.weaponGuardcount[7] += 1;
                if (GameData.weaponGuardcount[7] >= 5)
                {
                    GameData.weaponneedGuard[7] += 1;
                    GameData.weaponGuardcount[7] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[8])
            {
                GameData.weaponGuard[8] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[8];
                GameData.weaponGuardcount[8] += 1;
                if (GameData.weaponGuardcount[8] >= 5)
                {
                    GameData.weaponneedGuard[8] += 1;
                    GameData.weaponGuardcount[8] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playerdeffence > GameData.weaponneedGuard[9])
            {
                GameData.weaponGuard[9] += 1;
                GameData.playerdeffence -= GameData.weaponneedGuard[9];
                GameData.weaponGuardcount[9] += 1;
                if (GameData.weaponGuardcount[9] >= 5)
                {
                    GameData.weaponneedGuard[9] += 1;
                    GameData.weaponGuardcount[9] = 0;
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
            if (GameData.playerluck > GameData.weaponneedLuck[0])
            {
                GameData.weaponLuck[0] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[0];
                GameData.weaponLuckcount[0] += 1;
                if (GameData.weaponLuckcount[0] >= 5)
                {
                    GameData.weaponneedLuck[0] += 1;
                    GameData.weaponLuckcount[0] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos2)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[1])
            {
                GameData.weaponLuck[1] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[1];
                GameData.weaponLuckcount[1] += 1;
                if (GameData.weaponLuckcount[1] >= 5)
                {
                    GameData.weaponneedLuck[1] += 1;
                    GameData.weaponLuckcount[1] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos3)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[2])
            {
                GameData.weaponLuck[2] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[2];
                GameData.weaponLuckcount[2] += 1;
                if (GameData.weaponLuckcount[2] >= 5)
                {
                    GameData.weaponneedLuck[2] += 1;
                    GameData.weaponLuckcount[2] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos4)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[3])
            {
                GameData.weaponLuck[3] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[3];
                GameData.weaponLuckcount[3] += 1;
                if (GameData.weaponLuckcount[3] >= 5)
                {
                    GameData.weaponneedLuck[3] += 1;
                    GameData.weaponLuckcount[3] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos5)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[4])
            {
                GameData.weaponLuck[4] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[4];
                GameData.weaponLuckcount[4] += 1;
                if (GameData.weaponLuckcount[4] >= 5)
                {
                    GameData.weaponneedLuck[4] += 1;
                    GameData.weaponLuckcount[4] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos6)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[5])
            {
                GameData.weaponLuck[5] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[5];
                GameData.weaponLuckcount[5] += 1;
                if (GameData.weaponLuckcount[5] >= 5)
                {
                    GameData.weaponneedLuck[5] += 1;
                    GameData.weaponLuckcount[5] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos7)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[6])
            {
                GameData.weaponLuck[6] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[6];
                GameData.weaponLuckcount[6] += 1;
                if (GameData.weaponLuckcount[6] >= 5)
                {
                    GameData.weaponneedLuck[6] += 1;
                    GameData.weaponLuckcount[6] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos8)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[7])
            {
                GameData.weaponLuck[7] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[7];
                GameData.weaponLuckcount[7] += 1;
                if (GameData.weaponLuckcount[7] >= 5)
                {
                    GameData.weaponneedLuck[7] += 1;
                    GameData.weaponLuckcount[7] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos9)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[8])
            {
                GameData.weaponLuck[8] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[8];
                GameData.weaponLuckcount[8] += 1;
                if (GameData.weaponLuckcount[8] >= 5)
                {
                    GameData.weaponneedLuck[8] += 1;
                    GameData.weaponLuckcount[8] = 0;
                }
            }
        }
        else if (ks.sannsyou == dw.pos10)
        {
            if (GameData.playerluck > GameData.weaponneedLuck[9])
            {
                GameData.weaponLuck[9] += 1;
                GameData.playerluck -= GameData.weaponneedLuck[9];
                GameData.weaponLuckcount[9] += 1;
                if (GameData.weaponLuckcount[9] >= 5)
                {
                    GameData.weaponneedLuck[9] += 1;
                    GameData.weaponLuckcount[9] = 0;
                }
            }
        }
    }
    public void statusreset()
    {
        GameData.weaponHp[0] = 10;
        GameData.weaponHp[1] = 10;
        GameData.weaponHp[2] = 10;
        GameData.weaponHp[3] = 10;
        GameData.weaponHp[4] = 10;
        GameData.weaponHp[5] = 10;
        GameData.weaponHp[6] = 10;
        GameData.weaponHp[7] = 10;
        GameData.weaponHp[8] = 10;
        GameData.weaponHp[9] = 10;
        GameData.weaponneedHp[0] = 10;
        GameData.weaponneedHp[1] = 10;
        GameData.weaponneedHp[2] = 10;
        GameData.weaponneedHp[3] = 10;
        GameData.weaponneedHp[4] = 10;
        GameData.weaponneedHp[5] = 10;
        GameData.weaponneedHp[6] = 10;
        GameData.weaponneedHp[7] = 10;
        GameData.weaponneedHp[8] = 10;
        GameData.weaponneedHp[9] = 10;
        GameData.weaponhpcount[0] = 0;
        GameData.weaponhpcount[1] = 0;
        GameData.weaponhpcount[2] = 0;
        GameData.weaponhpcount[3] = 0;
        GameData.weaponhpcount[4] = 0;
        GameData.weaponhpcount[5] = 0;
        GameData.weaponhpcount[6] = 0;
        GameData.weaponhpcount[7] = 0;
        GameData.weaponhpcount[8] = 0;
        GameData.weaponhpcount[9] = 0;

        GameData.weaponStamina[0] = 10;
        GameData.weaponStamina[1] = 10;
        GameData.weaponStamina[2] = 10;
        GameData.weaponStamina[3] = 10;
        GameData.weaponStamina[4] = 10;
        GameData.weaponStamina[5] = 10;
        GameData.weaponStamina[6] = 10;
        GameData.weaponStamina[7] = 10;
        GameData.weaponStamina[8] = 10;
        GameData.weaponStamina[9] = 10;
        GameData.weaponneedStamina[0] = 10;
        GameData.weaponneedStamina[1] = 10;
        GameData.weaponneedStamina[2] = 10;
        GameData.weaponneedStamina[3] = 10;
        GameData.weaponneedStamina[4] = 10;
        GameData.weaponneedStamina[5] = 10;
        GameData.weaponneedStamina[6] = 10;
        GameData.weaponneedStamina[7] = 10;
        GameData.weaponneedStamina[8] = 10;
        GameData.weaponneedStamina[9] = 10;
        GameData.weaponStaminacount[0] = 0;
        GameData.weaponStaminacount[1] = 0;
        GameData.weaponStaminacount[2] = 0;
        GameData.weaponStaminacount[3] = 0;
        GameData.weaponStaminacount[4] = 0;
        GameData.weaponStaminacount[5] = 0;
        GameData.weaponStaminacount[6] = 0;
        GameData.weaponStaminacount[7] = 0;
        GameData.weaponStaminacount[8] = 0;
        GameData.weaponStaminacount[9] = 0;

        GameData.weaponAttack[0] = 1;
        GameData.weaponAttack[1] = 1;
        GameData.weaponAttack[2] = 1;
        GameData.weaponAttack[3] = 1;
        GameData.weaponAttack[4] = 1;
        GameData.weaponAttack[5] = 1;
        GameData.weaponAttack[6] = 1;
        GameData.weaponAttack[7] = 1;
        GameData.weaponAttack[8] = 1;
        GameData.weaponAttack[9] = 1;
        GameData.weaponneedAttack[0] = 1;
        GameData.weaponneedAttack[1] = 1;
        GameData.weaponneedAttack[2] = 1;
        GameData.weaponneedAttack[3] = 1;
        GameData.weaponneedAttack[4] = 1;
        GameData.weaponneedAttack[5] = 1;
        GameData.weaponneedAttack[6] = 1;
        GameData.weaponneedAttack[7] = 1;
        GameData.weaponneedAttack[8] = 1;
        GameData.weaponneedAttack[9] = 1;
        GameData.weaponAttackcount[0] = 1;
        GameData.weaponAttackcount[1] = 1;
        GameData.weaponAttackcount[2] = 1;
        GameData.weaponAttackcount[3] = 1;
        GameData.weaponAttackcount[4] = 1;
        GameData.weaponAttackcount[5] = 1;
        GameData.weaponAttackcount[6] = 1;
        GameData.weaponAttackcount[7] = 1;
        GameData.weaponAttackcount[8] = 1;
        GameData.weaponAttackcount[9] = 1;

        GameData.weaponGuard[0] = 1;
        GameData.weaponGuard[1] = 1;
        GameData.weaponGuard[2] = 1;
        GameData.weaponGuard[3] = 1;
        GameData.weaponGuard[4] = 1;
        GameData.weaponGuard[5] = 1;
        GameData.weaponGuard[6] = 1;
        GameData.weaponGuard[7] = 1;
        GameData.weaponGuard[8] = 1;
        GameData.weaponGuard[9] = 1;
        GameData.weaponneedGuard[0] = 1;
        GameData.weaponneedGuard[1] = 1;
        GameData.weaponneedGuard[2] = 1;
        GameData.weaponneedGuard[3] = 1;
        GameData.weaponneedGuard[4] = 1;
        GameData.weaponneedGuard[5] = 1;
        GameData.weaponneedGuard[6] = 1;
        GameData.weaponneedGuard[7] = 1;
        GameData.weaponneedGuard[8] = 1;
        GameData.weaponneedGuard[9] = 1;
        GameData.weaponGuardcount[0] = 0;
        GameData.weaponGuardcount[1] = 0;
        GameData.weaponGuardcount[2] = 0;
        GameData.weaponGuardcount[3] = 0;
        GameData.weaponGuardcount[4] = 0;
        GameData.weaponGuardcount[5] = 0;
        GameData.weaponGuardcount[6] = 0;
        GameData.weaponGuardcount[7] = 0;
        GameData.weaponGuardcount[8] = 0;
        GameData.weaponGuardcount[9] = 0;

        GameData.weaponLuck[0] = 1;
        GameData.weaponLuck[1] = 1;
        GameData.weaponLuck[2] = 1;
        GameData.weaponLuck[3] = 1;
        GameData.weaponLuck[4] = 1;
        GameData.weaponLuck[5] = 1;
        GameData.weaponLuck[6] = 1;
        GameData.weaponLuck[7] = 1;
        GameData.weaponLuck[8] = 1;
        GameData.weaponLuck[9] = 1;
        GameData.weaponneedLuck[0] = 1;
        GameData.weaponneedLuck[1] = 1;
        GameData.weaponneedLuck[2] = 1;
        GameData.weaponneedLuck[3] = 1;
        GameData.weaponneedLuck[4] = 1;
        GameData.weaponneedLuck[5] = 1;
        GameData.weaponneedLuck[6] = 1;
        GameData.weaponneedLuck[7] = 1;
        GameData.weaponneedLuck[8] = 1;
        GameData.weaponneedLuck[9] = 1;
        GameData.weaponLuckcount[0] = 0;
        GameData.weaponLuckcount[1] = 0;
        GameData.weaponLuckcount[2] = 0;
        GameData.weaponLuckcount[3] = 0;
        GameData.weaponLuckcount[4] = 0;
        GameData.weaponLuckcount[5] = 0;
        GameData.weaponLuckcount[6] = 0;
        GameData.weaponLuckcount[7] = 0;
        GameData.weaponLuckcount[8] = 0;
        GameData.weaponLuckcount[9] = 0;
    }
}

