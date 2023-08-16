using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public Kyoukasannsyou ks;
    public DropWeapon dw;
    private float dcount;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void destroy()
    {
        dcount = 0;
        if (dw.pos1)
        {
            dcount += 1;
        }
        if (dw.pos2)
        {
            dcount += 1;
        }
        if (dw.pos3)
        {
            dcount += 1;
        }
        if (dw.pos4)
        {
            dcount += 1;
        }
        if (dw.pos5)
        {
            dcount += 1;
        }
        if (dw.pos6)
        {
            dcount += 1;
        }
        if (dw.pos7)
        {
            dcount += 1;
        }
        if (dw.pos8)
        {
            dcount += 1;
        }
        if (dw.pos9)
        {
            dcount += 1;
        }
        if (dw.pos10)
        {
            dcount += 1;
        }
        if (dcount <= 1)
        {
            Debug.Log("•Ší‚ª‚È‚­‚È‚é‚©‚çƒ_ƒ");
        }
        else if (ks.sannsyou == dw.pos1)
        {
            GameData.weaponHp[0] = 10;
            GameData.weaponneedHp[0] = 10;
            GameData.weaponhpcount[0] = 0;
            GameData.weaponStamina[0] = 10;
            GameData.weaponneedStamina[0] = 10;
            GameData.weaponStaminacount[0] = 0;
            GameData.weaponAttack[0] = 1;
            GameData.weaponneedAttack[0] = 1;
            GameData.weaponAttackcount[0] = 0;
            GameData.weaponGuard[0] = 1;
            GameData.weaponneedGuard[0] = 1;
            GameData.weaponGuardcount[0] = 0;
            GameData.weaponLuck[0] = 1;
            GameData.weaponneedLuck[0] = 1;
            GameData.weaponLuckcount[0] = 0;
        }
        else if (ks.sannsyou == dw.pos2)
        {
            GameData.weaponHp[1] = 10;
            GameData.weaponneedHp[1] = 10;
            GameData.weaponhpcount[1] = 0;
            GameData.weaponStamina[1] = 10;
            GameData.weaponneedStamina[1] = 10;
            GameData.weaponStaminacount[1] = 0;
            GameData.weaponAttack[1] = 1;
            GameData.weaponneedAttack[1] = 1;
            GameData.weaponAttackcount[1] = 0;
            GameData.weaponGuard[1] = 1;
            GameData.weaponneedGuard[1] = 1;
            GameData.weaponGuardcount[1] = 0;
            GameData.weaponLuck[1] = 1;
            GameData.weaponneedLuck[1] = 1;
            GameData.weaponLuckcount[1] = 0;
        }
        else if (ks.sannsyou == dw.pos3)
        {
            GameData.weaponHp[2] = 10;
            GameData.weaponneedHp[2] = 10;
            GameData.weaponhpcount[2] = 0;
            GameData.weaponStamina[2] = 10;
            GameData.weaponneedStamina[2] = 10;
            GameData.weaponStaminacount[2] = 0;
            GameData.weaponAttack[2] = 1;
            GameData.weaponneedAttack[2] = 1;
            GameData.weaponAttackcount[2] = 0;
            GameData.weaponGuard[2] = 1;
            GameData.weaponneedGuard[2] = 1;
            GameData.weaponGuardcount[2] = 0;
            GameData.weaponLuck[2] = 1;
            GameData.weaponneedLuck[2] = 1;
            GameData.weaponLuckcount[2] = 0;
        }
        else if (ks.sannsyou == dw.pos4)
        {
            GameData.weaponHp[3] = 10;
            GameData.weaponneedHp[3] = 10;
            GameData.weaponhpcount[3] = 0;
            GameData.weaponStamina[3] = 10;
            GameData.weaponneedStamina[3] = 10;
            GameData.weaponStaminacount[3] = 0;
            GameData.weaponAttack[3] = 1;
            GameData.weaponneedAttack[3] = 1;
            GameData.weaponAttackcount[3] = 0;
            GameData.weaponGuard[3] = 1;
            GameData.weaponneedGuard[3] = 1;
            GameData.weaponGuardcount[3] = 0;
            GameData.weaponLuck[3] = 1;
            GameData.weaponneedLuck[3] = 1;
            GameData.weaponLuckcount[3] = 0;
        }
        else if (ks.sannsyou == dw.pos5)
        {
            GameData.weaponHp[4] = 10;
            GameData.weaponneedHp[4] = 10;
            GameData.weaponhpcount[4] = 0;
            GameData.weaponStamina[4] = 10;
            GameData.weaponneedStamina[4] = 10;
            GameData.weaponStaminacount[4] = 0;
            GameData.weaponAttack[4] = 1;
            GameData.weaponneedAttack[4] = 1;
            GameData.weaponAttackcount[4] = 0;
            GameData.weaponGuard[4] = 1;
            GameData.weaponneedGuard[4] = 1;
            GameData.weaponGuardcount[4] = 0;
            GameData.weaponLuck[4] = 1;
            GameData.weaponneedLuck[4] = 1;
            GameData.weaponLuckcount[4] = 0;
        }
        else if (ks.sannsyou == dw.pos6)
        {
            GameData.weaponHp[5] = 10;
            GameData.weaponneedHp[5] = 10;
            GameData.weaponhpcount[5] = 0;
            GameData.weaponStamina[5] = 10;
            GameData.weaponneedStamina[5] = 10;
            GameData.weaponStaminacount[5] = 0;
            GameData.weaponAttack[5] = 1;
            GameData.weaponneedAttack[5] = 1;
            GameData.weaponAttackcount[5] = 0;
            GameData.weaponGuard[5] = 1;
            GameData.weaponneedGuard[5] = 1;
            GameData.weaponGuardcount[5] = 0;
            GameData.weaponLuck[5] = 1;
            GameData.weaponneedLuck[5] = 1;
            GameData.weaponLuckcount[5] = 0;
        }
        else if (ks.sannsyou == dw.pos7)
        {
            GameData.weaponHp[6] = 10;
            GameData.weaponneedHp[6] = 10;
            GameData.weaponhpcount[6] = 0;
            GameData.weaponStamina[6] = 10;
            GameData.weaponneedStamina[6] = 10;
            GameData.weaponStaminacount[6] = 0;
            GameData.weaponAttack[6] = 1;
            GameData.weaponneedAttack[6] = 1;
            GameData.weaponAttackcount[6] = 0;
            GameData.weaponGuard[6] = 1;
            GameData.weaponneedGuard[6] = 1;
            GameData.weaponGuardcount[6] = 0;
            GameData.weaponLuck[6] = 1;
            GameData.weaponneedLuck[6] = 1;
            GameData.weaponLuckcount[6] = 0;
        }
        else if (ks.sannsyou == dw.pos8)
        {
            GameData.weaponHp[7] = 10;
            GameData.weaponneedHp[7] = 10;
            GameData.weaponhpcount[7] = 0;
            GameData.weaponStamina[7] = 10;
            GameData.weaponneedStamina[7] = 10;
            GameData.weaponStaminacount[7] = 0;
            GameData.weaponAttack[7] = 1;
            GameData.weaponneedAttack[7] = 1;
            GameData.weaponAttackcount[7] = 0;
            GameData.weaponGuard[7] = 1;
            GameData.weaponneedGuard[7] = 1;
            GameData.weaponGuardcount[7] = 0;
            GameData.weaponLuck[7] = 1;
            GameData.weaponneedLuck[7] = 1;
            GameData.weaponLuckcount[7] = 0;
        }
        else if (ks.sannsyou == dw.pos9)
        {
            GameData.weaponHp[8] = 10;
            GameData.weaponneedHp[8] = 10;
            GameData.weaponhpcount[8] = 0;
            GameData.weaponStamina[8] = 10;
            GameData.weaponneedStamina[8] = 10;
            GameData.weaponStaminacount[8] = 0;
            GameData.weaponAttack[8] = 1;
            GameData.weaponneedAttack[8] = 1;
            GameData.weaponAttackcount[8] = 0;
            GameData.weaponGuard[8] = 1;
            GameData.weaponneedGuard[8] = 1;
            GameData.weaponGuardcount[8] = 0;
            GameData.weaponLuck[8] = 1;
            GameData.weaponneedLuck[8] = 1;
            GameData.weaponLuckcount[8] = 0;
        }
        else if (ks.sannsyou == dw.pos10)
        {
            GameData.weaponHp[9] = 10;
            GameData.weaponneedHp[9] = 10;
            GameData.weaponhpcount[9] = 0;
            GameData.weaponStamina[9] = 10;
            GameData.weaponneedStamina[9] = 10;
            GameData.weaponStaminacount[9] = 0;
            GameData.weaponAttack[9] = 1;
            GameData.weaponneedAttack[9] = 1;
            GameData.weaponAttackcount[9] = 0;
            GameData.weaponGuard[9] = 1;
            GameData.weaponneedGuard[9] = 1;
            GameData.weaponGuardcount[9] = 0;
            GameData.weaponLuck[9] = 1;
            GameData.weaponneedLuck[9] = 1;
            GameData.weaponLuckcount[9] = 0;
        }
    }
}
