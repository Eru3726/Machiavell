using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusion : MonoBehaviour
{
    public GameObject fusionscripts;
    GameObject moto;                 //合成して強化するオブジェクト
    GameObject sozai;　　　　　　　　//合成するための素材のオブジェクト
    public GameObject sannsyou;      //クリックして参照したオブジェクト
    public DropWeapon dw;
    public Rarerity rare;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fusionclick()
    {
        moto = fusionscripts.GetComponent<FusionSetting>().fusionmoto;
        sozai = fusionscripts.GetComponent<FusionSetting>().fusionsozai;
        if (moto.transform.position != fusionscripts.GetComponent<FusionSetting>().fusionposi)
        {
            //合成元と素材の種類が同じなら合成
            if (moto.tag == "weapon1")
            {
                if (sozai.tag == moto.tag)
                {
                    if (sozai.layer == moto.layer)
                    {
                        if (sozai == dw.pos1)
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
                            Destroy(dw.pos1);
                            dw.pos1 = null;
                            GameData.inventoryWeapon[0] = 999;
                            Destroy(rare.star1);
                        }
                        else if (sozai == dw.pos2)
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
                            Destroy(dw.pos2);
                            dw.pos2 = null;
                            GameData.inventoryWeapon[1] = 999;
                            Destroy(rare.star2);
                        }
                        else if (sozai == dw.pos3)
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
                            Destroy(dw.pos3);
                            dw.pos3 = null;
                            GameData.inventoryWeapon[2] = 999;
                            Destroy(rare.star3);
                        }
                        else if (sozai == dw.pos4)
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
                            Destroy(dw.pos4);
                            dw.pos4 = null;
                            GameData.inventoryWeapon[3] = 999;
                            Destroy(rare.star4);
                        }
                        else if (sozai == dw.pos5)
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
                            Destroy(dw.pos5);
                            dw.pos5 = null;
                            GameData.inventoryWeapon[4] = 999;
                            Destroy(rare.star5);
                        }
                        else if (sozai == dw.pos6)
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
                            Destroy(dw.pos6);
                            dw.pos6 = null;
                            GameData.inventoryWeapon[5] = 999;
                            Destroy(rare.star6);
                        }
                        else if (sozai == dw.pos7)
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
                            Destroy(dw.pos7);
                            dw.pos7 = null;
                            GameData.inventoryWeapon[6] = 999;
                            Destroy(rare.star7);
                        }
                        else if (sozai == dw.pos8)
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
                            Destroy(dw.pos8);
                            dw.pos8 = null;
                            GameData.inventoryWeapon[7] = 999;
                            Destroy(rare.star8);
                        }
                        else if (sozai == dw.pos9)
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
                            Destroy(dw.pos9);
                            dw.pos9 = null;
                            GameData.inventoryWeapon[8] = 999;
                            Destroy(rare.star9);
                        }
                        else if (sozai == dw.pos10)
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
                            Destroy(dw.pos10);
                            dw.pos10 = null;
                            GameData.inventoryWeapon[9] = 999;
                            Destroy(rare.star10);
                        }

                        if (moto == dw.pos1)
                        {
                            GameData.weaponneedHp[0] = 10;
                            GameData.weaponhpcount[0] = 0;
                            GameData.weaponneedStamina[0] = 10;
                            GameData.weaponStaminacount[0] = 0;
                            GameData.weaponneedAttack[0] = 1;
                            GameData.weaponAttackcount[0] = 0;
                            GameData.weaponneedGuard[0] = 1;
                            GameData.weaponGuardcount[0] = 0;
                            GameData.weaponneedLuck[0] = 1;
                            GameData.weaponLuckcount[0] = 0;
                            Destroy(rare.star1);
                        }
                        else if (moto == dw.pos2)
                        {
                            GameData.weaponneedHp[1] = 10;
                            GameData.weaponhpcount[1] = 0;
                            GameData.weaponneedStamina[1] = 10;
                            GameData.weaponStaminacount[1] = 0;
                            GameData.weaponneedAttack[1] = 1;
                            GameData.weaponAttackcount[1] = 0;
                            GameData.weaponneedGuard[1] = 1;
                            GameData.weaponGuardcount[1] = 0;
                            GameData.weaponneedLuck[1] = 1;
                            GameData.weaponLuckcount[1] = 0;
                            Destroy(rare.star2);
                        }
                        else if (moto == dw.pos3)
                        {
                            GameData.weaponneedHp[2] = 10;
                            GameData.weaponhpcount[2] = 0;
                            GameData.weaponneedStamina[2] = 10;
                            GameData.weaponStaminacount[2] = 0;
                            GameData.weaponneedAttack[2] = 1;
                            GameData.weaponAttackcount[2] = 0;
                            GameData.weaponneedGuard[2] = 1;
                            GameData.weaponGuardcount[2] = 0;
                            GameData.weaponneedLuck[2] = 1;
                            GameData.weaponLuckcount[2] = 0;
                            Destroy(rare.star3);
                        }
                        else if (moto == dw.pos4)
                        {
                            GameData.weaponneedHp[3] = 10;
                            GameData.weaponhpcount[3] = 0;
                            GameData.weaponneedStamina[3] = 10;
                            GameData.weaponStaminacount[3] = 0;
                            GameData.weaponneedAttack[3] = 1;
                            GameData.weaponAttackcount[3] = 0;
                            GameData.weaponneedGuard[3] = 1;
                            GameData.weaponGuardcount[3] = 0;
                            GameData.weaponneedLuck[3] = 1;
                            GameData.weaponLuckcount[3] = 0;
                            Destroy(rare.star4);
                        }
                        else if (moto == dw.pos5)
                        {
                            GameData.weaponneedHp[4] = 10;
                            GameData.weaponhpcount[4] = 0;
                            GameData.weaponneedStamina[4] = 10;
                            GameData.weaponStaminacount[4] = 0;
                            GameData.weaponneedAttack[4] = 1;
                            GameData.weaponAttackcount[4] = 0;
                            GameData.weaponneedGuard[4] = 1;
                            GameData.weaponGuardcount[4] = 0;
                            GameData.weaponneedLuck[4] = 1;
                            GameData.weaponLuckcount[4] = 0;
                            Destroy(rare.star5);
                        }
                        else if (moto == dw.pos6)
                        {
                            GameData.weaponneedHp[5] = 10;
                            GameData.weaponhpcount[5] = 0;
                            GameData.weaponneedStamina[5] = 10;
                            GameData.weaponStaminacount[5] = 0;
                            GameData.weaponneedAttack[5] = 1;
                            GameData.weaponAttackcount[5] = 0;
                            GameData.weaponneedGuard[5] = 1;
                            GameData.weaponGuardcount[5] = 0;
                            GameData.weaponneedLuck[5] = 1;
                            GameData.weaponLuckcount[5] = 0;
                            Destroy(rare.star6);
                        }
                        else if (moto == dw.pos7)
                        {
                            GameData.weaponneedHp[6] = 10;
                            GameData.weaponhpcount[6] = 0;
                            GameData.weaponneedStamina[6] = 10;
                            GameData.weaponStaminacount[6] = 0;
                            GameData.weaponneedAttack[6] = 1;
                            GameData.weaponAttackcount[6] = 0;
                            GameData.weaponneedGuard[6] = 1;
                            GameData.weaponGuardcount[6] = 0;
                            GameData.weaponneedLuck[6] = 1;
                            GameData.weaponLuckcount[6] = 0;
                            Destroy(rare.star7);
                        }
                        else if (moto == dw.pos8)
                        {
                            GameData.weaponneedHp[7] = 10;
                            GameData.weaponhpcount[7] = 0;
                            GameData.weaponneedStamina[7] = 10;
                            GameData.weaponStaminacount[7] = 0;
                            GameData.weaponneedAttack[7] = 1;
                            GameData.weaponAttackcount[7] = 0;
                            GameData.weaponneedGuard[7] = 1;
                            GameData.weaponGuardcount[7] = 0;
                            GameData.weaponneedLuck[7] = 1;
                            GameData.weaponLuckcount[7] = 0;
                            Destroy(rare.star8);
                        }
                        else if (moto == dw.pos9)
                        {
                            GameData.weaponneedHp[8] = 10;
                            GameData.weaponhpcount[8] = 0;
                            GameData.weaponneedStamina[8] = 10;
                            GameData.weaponStaminacount[8] = 0;
                            GameData.weaponneedAttack[8] = 1;
                            GameData.weaponAttackcount[8] = 0;
                            GameData.weaponneedGuard[8] = 1;
                            GameData.weaponGuardcount[8] = 0;
                            GameData.weaponneedLuck[8] = 1;
                            GameData.weaponLuckcount[8] = 0;
                            Destroy(rare.star9);
                        }
                        else if (moto == dw.pos10)
                        {
                            GameData.weaponneedHp[9] = 10;
                            GameData.weaponhpcount[9] = 0;
                            GameData.weaponneedStamina[9] = 10;
                            GameData.weaponStaminacount[9] = 0;
                            GameData.weaponneedAttack[9] = 1;
                            GameData.weaponAttackcount[9] = 0;
                            GameData.weaponneedGuard[9] = 1;
                            GameData.weaponGuardcount[9] = 0;
                            GameData.weaponneedLuck[9] = 1;
                            GameData.weaponLuckcount[9] = 0;
                            Destroy(rare.star10);
                        }
                        sannsyou.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                        fusionscripts.GetComponent<FusionSetting>().fusion();

                    }
                }
            }
            else if (moto.tag == "weapon2")
            {
                if (sozai.tag == moto.tag)
                {
                    if (sozai.layer == moto.layer)
                    {
                        if (sozai == dw.pos1)
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
                            Destroy(dw.pos1);
                            dw.pos1 = null;
                            GameData.inventoryWeapon[0] = 999;
                            Destroy(rare.star1);
                        }
                        else if (sozai == dw.pos2)
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
                            Destroy(dw.pos2);
                            dw.pos2 = null;
                            GameData.inventoryWeapon[1] = 999;
                            Destroy(rare.star2);
                        }
                        else if (sozai == dw.pos3)
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
                            Destroy(dw.pos3);
                            dw.pos3 = null;
                            GameData.inventoryWeapon[2] = 999;
                            Destroy(rare.star3);
                        }
                        else if (sozai == dw.pos4)
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
                            Destroy(dw.pos4);
                            dw.pos4 = null;
                            GameData.inventoryWeapon[3] = 999;
                            Destroy(rare.star4);
                        }
                        else if (sozai == dw.pos5)
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
                            Destroy(dw.pos5);
                            dw.pos5 = null;
                            GameData.inventoryWeapon[4] = 999;
                            Destroy(rare.star5);
                        }
                        else if (sozai == dw.pos6)
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
                            Destroy(dw.pos6);
                            dw.pos6 = null;
                            GameData.inventoryWeapon[5] = 999;
                            Destroy(rare.star6);
                        }
                        else if (sozai == dw.pos7)
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
                            Destroy(dw.pos7);
                            dw.pos7 = null;
                            GameData.inventoryWeapon[6] = 999;
                            Destroy(rare.star7);
                        }
                        else if (sozai == dw.pos8)
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
                            Destroy(dw.pos8);
                            dw.pos8 = null;
                            GameData.inventoryWeapon[7] = 999;
                            Destroy(rare.star8);
                        }
                        else if (sozai == dw.pos9)
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
                            Destroy(dw.pos9);
                            dw.pos9 = null;
                            GameData.inventoryWeapon[8] = 999;
                            Destroy(rare.star9);
                        }
                        else if (sozai == dw.pos10)
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
                            Destroy(dw.pos10);
                            dw.pos10 = null;
                            GameData.inventoryWeapon[9] = 999;
                            Destroy(rare.star10);
                        }

                        if (moto == dw.pos1)
                        {
                            GameData.weaponneedHp[0] = 10;
                            GameData.weaponhpcount[0] = 0;
                            GameData.weaponneedStamina[0] = 10;
                            GameData.weaponStaminacount[0] = 0;
                            GameData.weaponneedAttack[0] = 1;
                            GameData.weaponAttackcount[0] = 0;
                            GameData.weaponneedGuard[0] = 1;
                            GameData.weaponGuardcount[0] = 0;
                            GameData.weaponneedLuck[0] = 1;
                            GameData.weaponLuckcount[0] = 0;
                            Destroy(rare.star1);
                        }
                        else if (moto == dw.pos2)
                        {
                            GameData.weaponneedHp[1] = 10;
                            GameData.weaponhpcount[1] = 0;
                            GameData.weaponneedStamina[1] = 10;
                            GameData.weaponStaminacount[1] = 0;
                            GameData.weaponneedAttack[1] = 1;
                            GameData.weaponAttackcount[1] = 0;
                            GameData.weaponneedGuard[1] = 1;
                            GameData.weaponGuardcount[1] = 0;
                            GameData.weaponneedLuck[1] = 1;
                            GameData.weaponLuckcount[1] = 0;
                            Destroy(rare.star2);
                        }
                        else if (moto == dw.pos3)
                        {
                            GameData.weaponneedHp[2] = 10;
                            GameData.weaponhpcount[2] = 0;
                            GameData.weaponneedStamina[2] = 10;
                            GameData.weaponStaminacount[2] = 0;
                            GameData.weaponneedAttack[2] = 1;
                            GameData.weaponAttackcount[2] = 0;
                            GameData.weaponneedGuard[2] = 1;
                            GameData.weaponGuardcount[2] = 0;
                            GameData.weaponneedLuck[2] = 1;
                            GameData.weaponLuckcount[2] = 0;
                            Destroy(rare.star3);
                        }
                        else if (moto == dw.pos4)
                        {
                            GameData.weaponneedHp[3] = 10;
                            GameData.weaponhpcount[3] = 0;
                            GameData.weaponneedStamina[3] = 10;
                            GameData.weaponStaminacount[3] = 0;
                            GameData.weaponneedAttack[3] = 1;
                            GameData.weaponAttackcount[3] = 0;
                            GameData.weaponneedGuard[3] = 1;
                            GameData.weaponGuardcount[3] = 0;
                            GameData.weaponneedLuck[3] = 1;
                            GameData.weaponLuckcount[3] = 0;
                            Destroy(rare.star4);
                        }
                        else if (moto == dw.pos5)
                        {
                            GameData.weaponneedHp[4] = 10;
                            GameData.weaponhpcount[4] = 0;
                            GameData.weaponneedStamina[4] = 10;
                            GameData.weaponStaminacount[4] = 0;
                            GameData.weaponneedAttack[4] = 1;
                            GameData.weaponAttackcount[4] = 0;
                            GameData.weaponneedGuard[4] = 1;
                            GameData.weaponGuardcount[4] = 0;
                            GameData.weaponneedLuck[4] = 1;
                            GameData.weaponLuckcount[4] = 0;
                            Destroy(rare.star5);
                        }
                        else if (moto == dw.pos6)
                        {
                            GameData.weaponneedHp[5] = 10;
                            GameData.weaponhpcount[5] = 0;
                            GameData.weaponneedStamina[5] = 10;
                            GameData.weaponStaminacount[5] = 0;
                            GameData.weaponneedAttack[5] = 1;
                            GameData.weaponAttackcount[5] = 0;
                            GameData.weaponneedGuard[5] = 1;
                            GameData.weaponGuardcount[5] = 0;
                            GameData.weaponneedLuck[5] = 1;
                            GameData.weaponLuckcount[5] = 0;
                            Destroy(rare.star6);
                        }
                        else if (moto == dw.pos7)
                        {
                            GameData.weaponneedHp[6] = 10;
                            GameData.weaponhpcount[6] = 0;
                            GameData.weaponneedStamina[6] = 10;
                            GameData.weaponStaminacount[6] = 0;
                            GameData.weaponneedAttack[6] = 1;
                            GameData.weaponAttackcount[6] = 0;
                            GameData.weaponneedGuard[6] = 1;
                            GameData.weaponGuardcount[6] = 0;
                            GameData.weaponneedLuck[6] = 1;
                            GameData.weaponLuckcount[6] = 0;
                            Destroy(rare.star7);
                        }
                        else if (moto == dw.pos8)
                        {
                            GameData.weaponneedHp[7] = 10;
                            GameData.weaponhpcount[7] = 0;
                            GameData.weaponneedStamina[7] = 10;
                            GameData.weaponStaminacount[7] = 0;
                            GameData.weaponneedAttack[7] = 1;
                            GameData.weaponAttackcount[7] = 0;
                            GameData.weaponneedGuard[7] = 1;
                            GameData.weaponGuardcount[7] = 0;
                            GameData.weaponneedLuck[7] = 1;
                            GameData.weaponLuckcount[7] = 0;
                            Destroy(rare.star8);
                        }
                        else if (moto == dw.pos9)
                        {
                            GameData.weaponneedHp[8] = 10;
                            GameData.weaponhpcount[8] = 0;
                            GameData.weaponneedStamina[8] = 10;
                            GameData.weaponStaminacount[8] = 0;
                            GameData.weaponneedAttack[8] = 1;
                            GameData.weaponAttackcount[8] = 0;
                            GameData.weaponneedGuard[8] = 1;
                            GameData.weaponGuardcount[8] = 0;
                            GameData.weaponneedLuck[8] = 1;
                            GameData.weaponLuckcount[8] = 0;
                            Destroy(rare.star9);
                        }
                        else if (moto == dw.pos10)
                        {
                            GameData.weaponneedHp[9] = 10;
                            GameData.weaponhpcount[9] = 0;
                            GameData.weaponneedStamina[9] = 10;
                            GameData.weaponStaminacount[9] = 0;
                            GameData.weaponneedAttack[9] = 1;
                            GameData.weaponAttackcount[9] = 0;
                            GameData.weaponneedGuard[9] = 1;
                            GameData.weaponGuardcount[9] = 0;
                            GameData.weaponneedLuck[9] = 1;
                            GameData.weaponLuckcount[9] = 0;
                            Destroy(rare.star10);
                        }
                        sannsyou.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                        fusionscripts.GetComponent<FusionSetting>().fusion();
                    }
                }
            }
            else if (moto.tag == "weapon3")
            {
                if (sozai.tag == moto.tag)
                {
                    if (sozai.layer == moto.layer)
                    {
                        if (sozai == dw.pos1)
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
                            Destroy(dw.pos1);
                            dw.pos1 = null;
                            GameData.inventoryWeapon[0] = 999;
                            Destroy(rare.star1);
                        }
                        else if (sozai == dw.pos2)
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
                            Destroy(dw.pos2);
                            dw.pos2 = null;
                            GameData.inventoryWeapon[1] = 999;
                            Destroy(rare.star2);
                        }
                        else if (sozai == dw.pos3)
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
                            Destroy(dw.pos3);
                            dw.pos3 = null;
                            GameData.inventoryWeapon[2] = 999;
                            Destroy(rare.star3);
                        }
                        else if (sozai == dw.pos4)
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
                            Destroy(dw.pos4);
                            dw.pos4 = null;
                            GameData.inventoryWeapon[3] = 999;
                            Destroy(rare.star4);
                        }
                        else if (sozai == dw.pos5)
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
                            Destroy(dw.pos5);
                            dw.pos5 = null;
                            GameData.inventoryWeapon[4] = 999;
                            Destroy(rare.star5);
                        }
                        else if (sozai == dw.pos6)
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
                            Destroy(dw.pos6);
                            dw.pos6 = null;
                            GameData.inventoryWeapon[5] = 999;
                            Destroy(rare.star6);
                        }
                        else if (sozai == dw.pos7)
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
                            Destroy(dw.pos7);
                            dw.pos7 = null;
                            GameData.inventoryWeapon[6] = 999;
                            Destroy(rare.star7);
                        }
                        else if (sozai == dw.pos8)
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
                            Destroy(dw.pos8);
                            dw.pos8 = null;
                            GameData.inventoryWeapon[7] = 999;
                            Destroy(rare.star8);
                        }
                        else if (sozai == dw.pos9)
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
                            Destroy(dw.pos9);
                            dw.pos9 = null;
                            GameData.inventoryWeapon[8] = 999;
                            Destroy(rare.star9);
                        }
                        else if (sozai == dw.pos10)
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
                            Destroy(dw.pos10);
                            dw.pos10 = null;
                            GameData.inventoryWeapon[9] = 999;
                            Destroy(rare.star10);
                        }

                        if (moto == dw.pos1)
                        {
                            GameData.weaponneedHp[0] = 10;
                            GameData.weaponhpcount[0] = 0;
                            GameData.weaponneedStamina[0] = 10;
                            GameData.weaponStaminacount[0] = 0;
                            GameData.weaponneedAttack[0] = 1;
                            GameData.weaponAttackcount[0] = 0;
                            GameData.weaponneedGuard[0] = 1;
                            GameData.weaponGuardcount[0] = 0;
                            GameData.weaponneedLuck[0] = 1;
                            GameData.weaponLuckcount[0] = 0;
                            Destroy(rare.star1);
                        }
                        else if (moto == dw.pos2)
                        {
                            GameData.weaponneedHp[1] = 10;
                            GameData.weaponhpcount[1] = 0;
                            GameData.weaponneedStamina[1] = 10;
                            GameData.weaponStaminacount[1] = 0;
                            GameData.weaponneedAttack[1] = 1;
                            GameData.weaponAttackcount[1] = 0;
                            GameData.weaponneedGuard[1] = 1;
                            GameData.weaponGuardcount[1] = 0;
                            GameData.weaponneedLuck[1] = 1;
                            GameData.weaponLuckcount[1] = 0;
                            Destroy(rare.star2);
                        }
                        else if (moto == dw.pos3)
                        {
                            GameData.weaponneedHp[2] = 10;
                            GameData.weaponhpcount[2] = 0;
                            GameData.weaponneedStamina[2] = 10;
                            GameData.weaponStaminacount[2] = 0;
                            GameData.weaponneedAttack[2] = 1;
                            GameData.weaponAttackcount[2] = 0;
                            GameData.weaponneedGuard[2] = 1;
                            GameData.weaponGuardcount[2] = 0;
                            GameData.weaponneedLuck[2] = 1;
                            GameData.weaponLuckcount[2] = 0;
                            Destroy(rare.star3);
                        }
                        else if (moto == dw.pos4)
                        {
                            GameData.weaponneedHp[3] = 10;
                            GameData.weaponhpcount[3] = 0;
                            GameData.weaponneedStamina[3] = 10;
                            GameData.weaponStaminacount[3] = 0;
                            GameData.weaponneedAttack[3] = 1;
                            GameData.weaponAttackcount[3] = 0;
                            GameData.weaponneedGuard[3] = 1;
                            GameData.weaponGuardcount[3] = 0;
                            GameData.weaponneedLuck[3] = 1;
                            GameData.weaponLuckcount[3] = 0;
                            Destroy(rare.star4);
                        }
                        else if (moto == dw.pos5)
                        {
                            GameData.weaponneedHp[4] = 10;
                            GameData.weaponhpcount[4] = 0;
                            GameData.weaponneedStamina[4] = 10;
                            GameData.weaponStaminacount[4] = 0;
                            GameData.weaponneedAttack[4] = 1;
                            GameData.weaponAttackcount[4] = 0;
                            GameData.weaponneedGuard[4] = 1;
                            GameData.weaponGuardcount[4] = 0;
                            GameData.weaponneedLuck[4] = 1;
                            GameData.weaponLuckcount[4] = 0;
                            Destroy(rare.star5);
                        }
                        else if (moto == dw.pos6)
                        {
                            GameData.weaponneedHp[5] = 10;
                            GameData.weaponhpcount[5] = 0;
                            GameData.weaponneedStamina[5] = 10;
                            GameData.weaponStaminacount[5] = 0;
                            GameData.weaponneedAttack[5] = 1;
                            GameData.weaponAttackcount[5] = 0;
                            GameData.weaponneedGuard[5] = 1;
                            GameData.weaponGuardcount[5] = 0;
                            GameData.weaponneedLuck[5] = 1;
                            GameData.weaponLuckcount[5] = 0;
                            Destroy(rare.star6);
                        }
                        else if (moto == dw.pos7)
                        {
                            GameData.weaponneedHp[6] = 10;
                            GameData.weaponhpcount[6] = 0;
                            GameData.weaponneedStamina[6] = 10;
                            GameData.weaponStaminacount[6] = 0;
                            GameData.weaponneedAttack[6] = 1;
                            GameData.weaponAttackcount[6] = 0;
                            GameData.weaponneedGuard[6] = 1;
                            GameData.weaponGuardcount[6] = 0;
                            GameData.weaponneedLuck[6] = 1;
                            GameData.weaponLuckcount[6] = 0;
                            Destroy(rare.star7);
                        }
                        else if (moto == dw.pos8)
                        {
                            GameData.weaponneedHp[7] = 10;
                            GameData.weaponhpcount[7] = 0;
                            GameData.weaponneedStamina[7] = 10;
                            GameData.weaponStaminacount[7] = 0;
                            GameData.weaponneedAttack[7] = 1;
                            GameData.weaponAttackcount[7] = 0;
                            GameData.weaponneedGuard[7] = 1;
                            GameData.weaponGuardcount[7] = 0;
                            GameData.weaponneedLuck[7] = 1;
                            GameData.weaponLuckcount[7] = 0;
                            Destroy(rare.star8);
                        }
                        else if (moto == dw.pos9)
                        {
                            GameData.weaponneedHp[8] = 10;
                            GameData.weaponhpcount[8] = 0;
                            GameData.weaponneedStamina[8] = 10;
                            GameData.weaponStaminacount[8] = 0;
                            GameData.weaponneedAttack[8] = 1;
                            GameData.weaponAttackcount[8] = 0;
                            GameData.weaponneedGuard[8] = 1;
                            GameData.weaponGuardcount[8] = 0;
                            GameData.weaponneedLuck[8] = 1;
                            GameData.weaponLuckcount[8] = 0;
                            Destroy(rare.star9);
                        }
                        else if (moto == dw.pos10)
                        {
                            GameData.weaponneedHp[9] = 10;
                            GameData.weaponhpcount[9] = 0;
                            GameData.weaponneedStamina[9] = 10;
                            GameData.weaponStaminacount[9] = 0;
                            GameData.weaponneedAttack[9] = 1;
                            GameData.weaponAttackcount[9] = 0;
                            GameData.weaponneedGuard[9] = 1;
                            GameData.weaponGuardcount[9] = 0;
                            GameData.weaponneedLuck[9] = 1;
                            GameData.weaponLuckcount[9] = 0;
                            Destroy(rare.star10);
                        }
                        sannsyou.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                        fusionscripts.GetComponent<FusionSetting>().fusion();
                    }
                }
            }
            else if (moto.tag == "weapon4")
            {
                if (sozai.tag == moto.tag)
                {
                    if (sozai.layer == moto.layer)
                    {
                        if (sozai == dw.pos1)
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
                            Destroy(dw.pos1);
                            dw.pos1 = null;
                            GameData.inventoryWeapon[0] = 999;
                            Destroy(rare.star1);
                        }
                        else if (sozai == dw.pos2)
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
                            Destroy(dw.pos2);
                            dw.pos2 = null;
                            GameData.inventoryWeapon[1] = 999;
                            Destroy(rare.star2);
                        }
                        else if (sozai == dw.pos3)
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
                            Destroy(dw.pos3);
                            dw.pos3 = null;
                            GameData.inventoryWeapon[2] = 999;
                            Destroy(rare.star3);
                        }
                        else if (sozai == dw.pos4)
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
                            Destroy(dw.pos4);
                            dw.pos4 = null;
                            GameData.inventoryWeapon[3] = 999;
                            Destroy(rare.star4);
                        }
                        else if (sozai == dw.pos5)
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
                            Destroy(dw.pos5);
                            dw.pos5 = null;
                            GameData.inventoryWeapon[4] = 999;
                            Destroy(rare.star5);
                        }
                        else if (sozai == dw.pos6)
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
                            Destroy(dw.pos6);
                            dw.pos6 = null;
                            GameData.inventoryWeapon[5] = 999;
                            Destroy(rare.star6);
                        }
                        else if (sozai == dw.pos7)
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
                            Destroy(dw.pos7);
                            dw.pos7 = null;
                            GameData.inventoryWeapon[6] = 999;
                            Destroy(rare.star7);
                        }
                        else if (sozai == dw.pos8)
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
                            Destroy(dw.pos8);
                            dw.pos8 = null;
                            GameData.inventoryWeapon[7] = 999;
                            Destroy(rare.star8);
                        }
                        else if (sozai == dw.pos9)
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
                            Destroy(dw.pos9);
                            dw.pos9 = null;
                            GameData.inventoryWeapon[8] = 999;
                            Destroy(rare.star9);
                        }
                        else if (sozai == dw.pos10)
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
                            Destroy(dw.pos10);
                            dw.pos10 = null;
                            GameData.inventoryWeapon[9] = 999;
                            Destroy(rare.star10);
                        }

                        if (moto == dw.pos1)
                        {
                            GameData.weaponneedHp[0] = 10;
                            GameData.weaponhpcount[0] = 0;
                            GameData.weaponneedStamina[0] = 10;
                            GameData.weaponStaminacount[0] = 0;
                            GameData.weaponneedAttack[0] = 1;
                            GameData.weaponAttackcount[0] = 0;
                            GameData.weaponneedGuard[0] = 1;
                            GameData.weaponGuardcount[0] = 0;
                            GameData.weaponneedLuck[0] = 1;
                            GameData.weaponLuckcount[0] = 0;
                            Destroy(rare.star1);
                        }
                        else if (moto == dw.pos2)
                        {
                            GameData.weaponneedHp[1] = 10;
                            GameData.weaponhpcount[1] = 0;
                            GameData.weaponneedStamina[1] = 10;
                            GameData.weaponStaminacount[1] = 0;
                            GameData.weaponneedAttack[1] = 1;
                            GameData.weaponAttackcount[1] = 0;
                            GameData.weaponneedGuard[1] = 1;
                            GameData.weaponGuardcount[1] = 0;
                            GameData.weaponneedLuck[1] = 1;
                            GameData.weaponLuckcount[1] = 0;
                            Destroy(rare.star2);
                        }
                        else if (moto == dw.pos3)
                        {
                            GameData.weaponneedHp[2] = 10;
                            GameData.weaponhpcount[2] = 0;
                            GameData.weaponneedStamina[2] = 10;
                            GameData.weaponStaminacount[2] = 0;
                            GameData.weaponneedAttack[2] = 1;
                            GameData.weaponAttackcount[2] = 0;
                            GameData.weaponneedGuard[2] = 1;
                            GameData.weaponGuardcount[2] = 0;
                            GameData.weaponneedLuck[2] = 1;
                            GameData.weaponLuckcount[2] = 0;
                            Destroy(rare.star3);
                        }
                        else if (moto == dw.pos4)
                        {
                            GameData.weaponneedHp[3] = 10;
                            GameData.weaponhpcount[3] = 0;
                            GameData.weaponneedStamina[3] = 10;
                            GameData.weaponStaminacount[3] = 0;
                            GameData.weaponneedAttack[3] = 1;
                            GameData.weaponAttackcount[3] = 0;
                            GameData.weaponneedGuard[3] = 1;
                            GameData.weaponGuardcount[3] = 0;
                            GameData.weaponneedLuck[3] = 1;
                            GameData.weaponLuckcount[3] = 0;
                            Destroy(rare.star4);
                        }
                        else if (moto == dw.pos5)
                        {
                            GameData.weaponneedHp[4] = 10;
                            GameData.weaponhpcount[4] = 0;
                            GameData.weaponneedStamina[4] = 10;
                            GameData.weaponStaminacount[4] = 0;
                            GameData.weaponneedAttack[4] = 1;
                            GameData.weaponAttackcount[4] = 0;
                            GameData.weaponneedGuard[4] = 1;
                            GameData.weaponGuardcount[4] = 0;
                            GameData.weaponneedLuck[4] = 1;
                            GameData.weaponLuckcount[4] = 0;
                            Destroy(rare.star5);
                        }
                        else if (moto == dw.pos6)
                        {
                            GameData.weaponneedHp[5] = 10;
                            GameData.weaponhpcount[5] = 0;
                            GameData.weaponneedStamina[5] = 10;
                            GameData.weaponStaminacount[5] = 0;
                            GameData.weaponneedAttack[5] = 1;
                            GameData.weaponAttackcount[5] = 0;
                            GameData.weaponneedGuard[5] = 1;
                            GameData.weaponGuardcount[5] = 0;
                            GameData.weaponneedLuck[5] = 1;
                            GameData.weaponLuckcount[5] = 0;
                            Destroy(rare.star6);
                        }
                        else if (moto == dw.pos7)
                        {
                            GameData.weaponneedHp[6] = 10;
                            GameData.weaponhpcount[6] = 0;
                            GameData.weaponneedStamina[6] = 10;
                            GameData.weaponStaminacount[6] = 0;
                            GameData.weaponneedAttack[6] = 1;
                            GameData.weaponAttackcount[6] = 0;
                            GameData.weaponneedGuard[6] = 1;
                            GameData.weaponGuardcount[6] = 0;
                            GameData.weaponneedLuck[6] = 1;
                            GameData.weaponLuckcount[6] = 0;
                            Destroy(rare.star7);
                        }
                        else if (moto == dw.pos8)
                        {
                            GameData.weaponneedHp[7] = 10;
                            GameData.weaponhpcount[7] = 0;
                            GameData.weaponneedStamina[7] = 10;
                            GameData.weaponStaminacount[7] = 0;
                            GameData.weaponneedAttack[7] = 1;
                            GameData.weaponAttackcount[7] = 0;
                            GameData.weaponneedGuard[7] = 1;
                            GameData.weaponGuardcount[7] = 0;
                            GameData.weaponneedLuck[7] = 1;
                            GameData.weaponLuckcount[7] = 0;
                            Destroy(rare.star8);
                        }
                        else if (moto == dw.pos9)
                        {
                            GameData.weaponneedHp[8] = 10;
                            GameData.weaponhpcount[8] = 0;
                            GameData.weaponneedStamina[8] = 10;
                            GameData.weaponStaminacount[8] = 0;
                            GameData.weaponneedAttack[8] = 1;
                            GameData.weaponAttackcount[8] = 0;
                            GameData.weaponneedGuard[8] = 1;
                            GameData.weaponGuardcount[8] = 0;
                            GameData.weaponneedLuck[8] = 1;
                            GameData.weaponLuckcount[8] = 0;
                            Destroy(rare.star9);
                        }
                        else if (moto == dw.pos10)
                        {
                            GameData.weaponneedHp[9] = 10;
                            GameData.weaponhpcount[9] = 0;
                            GameData.weaponneedStamina[9] = 10;
                            GameData.weaponStaminacount[9] = 0;
                            GameData.weaponneedAttack[9] = 1;
                            GameData.weaponAttackcount[9] = 0;
                            GameData.weaponneedGuard[9] = 1;
                            GameData.weaponGuardcount[9] = 0;
                            GameData.weaponneedLuck[9] = 1;
                            GameData.weaponLuckcount[9] = 0;
                            Destroy(rare.star10);
                        }
                        sannsyou.GetComponent<weaponsannsyoufusion>().firstnotsannsyou = false;
                        fusionscripts.GetComponent<FusionSetting>().fusion();
                    }
                }
            }
            else
            {
                Debug.Log("合成できません");
            }
        }
        else
        {
            Debug.Log("合成した武器を元の位置に戻してください");
        }
    }
}
