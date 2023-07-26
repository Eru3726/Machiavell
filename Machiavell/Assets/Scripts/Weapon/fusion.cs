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
                            Destroy(dw.pos1);
                            dw.pos1 = null;
                            GameData.inventoryWeapon1 = 999;
                            Destroy(rare.star1);
                        }
                        else if (sozai == dw.pos2)
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
                            Destroy(dw.pos2);
                            dw.pos2 = null;
                            GameData.inventoryWeapon2 = 999;
                            Destroy(rare.star2);
                        }
                        else if (sozai == dw.pos3)
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
                            Destroy(dw.pos3);
                            dw.pos3 = null;
                            GameData.inventoryWeapon3 = 999;
                            Destroy(rare.star3);
                        }
                        else if (sozai == dw.pos4)
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
                            Destroy(dw.pos4);
                            dw.pos4 = null;
                            GameData.inventoryWeapon4 = 999;
                            Destroy(rare.star4);
                        }
                        else if (sozai == dw.pos5)
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
                            Destroy(dw.pos5);
                            dw.pos5 = null;
                            GameData.inventoryWeapon5 = 999;
                            Destroy(rare.star5);
                        }
                        else if (sozai == dw.pos6)
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
                            Destroy(dw.pos6);
                            dw.pos6 = null;
                            GameData.inventoryWeapon6 = 999;
                            Destroy(rare.star6);
                        }
                        else if (sozai == dw.pos7)
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
                            Destroy(dw.pos7);
                            dw.pos7 = null;
                            GameData.inventoryWeapon7 = 999;
                            Destroy(rare.star7);
                        }
                        else if (sozai == dw.pos8)
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
                            Destroy(dw.pos8);
                            dw.pos8 = null;
                            GameData.inventoryWeapon8 = 999;
                            Destroy(rare.star8);
                        }
                        else if (sozai == dw.pos9)
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
                            Destroy(dw.pos9);
                            dw.pos9 = null;
                            GameData.inventoryWeapon9 = 999;
                            Destroy(rare.star9);
                        }
                        else if (sozai == dw.pos10)
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
                            Destroy(dw.pos10);
                            dw.pos10 = null;
                            GameData.inventoryWeapon10 = 999;
                            Destroy(rare.star10);
                        }

                        if (moto == dw.pos1)
                        {
                            GameData.weaponneedHp1 = 10;
                            GameData.weaponhpcount1 = 0;
                            GameData.weaponneedStamina1 = 10;
                            GameData.weaponStaminacount1 = 0;
                            GameData.weaponneedAttack1 = 1;
                            GameData.weaponAttackcount1 = 0;
                            GameData.weaponneedGuard1 = 1;
                            GameData.weaponGuardcount1 = 0;
                            GameData.weaponneedLuck1 = 1;
                            GameData.weaponLuckcount1 = 0;
                            Destroy(rare.star1);
                        }
                        else if (moto == dw.pos2)
                        {
                            GameData.weaponneedHp2 = 10;
                            GameData.weaponhpcount2 = 0;
                            GameData.weaponneedStamina2 = 10;
                            GameData.weaponStaminacount2 = 0;
                            GameData.weaponneedAttack2 = 1;
                            GameData.weaponAttackcount2 = 0;
                            GameData.weaponneedGuard2 = 1;
                            GameData.weaponGuardcount2 = 0;
                            GameData.weaponneedLuck2 = 1;
                            GameData.weaponLuckcount2 = 0;
                            Destroy(rare.star2);
                        }
                        else if (moto == dw.pos3)
                        {
                            GameData.weaponneedHp3 = 10;
                            GameData.weaponhpcount3 = 0;
                            GameData.weaponneedStamina3 = 10;
                            GameData.weaponStaminacount3 = 0;
                            GameData.weaponneedAttack3 = 1;
                            GameData.weaponAttackcount3 = 0;
                            GameData.weaponneedGuard3 = 1;
                            GameData.weaponGuardcount3 = 0;
                            GameData.weaponneedLuck3 = 1;
                            GameData.weaponLuckcount3 = 0;
                            Destroy(rare.star3);
                        }
                        else if (moto == dw.pos4)
                        {
                            GameData.weaponneedHp4 = 10;
                            GameData.weaponhpcount4 = 0;
                            GameData.weaponneedStamina4 = 10;
                            GameData.weaponStaminacount4 = 0;
                            GameData.weaponneedAttack4 = 1;
                            GameData.weaponAttackcount4 = 0;
                            GameData.weaponneedGuard4 = 1;
                            GameData.weaponGuardcount4 = 0;
                            GameData.weaponneedLuck4 = 1;
                            GameData.weaponLuckcount4 = 0;
                            Destroy(rare.star4);
                        }
                        else if (moto == dw.pos5)
                        {
                            GameData.weaponneedHp5 = 10;
                            GameData.weaponhpcount5 = 0;
                            GameData.weaponneedStamina5 = 10;
                            GameData.weaponStaminacount5 = 0;
                            GameData.weaponneedAttack5 = 1;
                            GameData.weaponAttackcount5 = 0;
                            GameData.weaponneedGuard5 = 1;
                            GameData.weaponGuardcount5 = 0;
                            GameData.weaponneedLuck5 = 1;
                            GameData.weaponLuckcount5 = 0;
                            Destroy(rare.star5);
                        }
                        else if (moto == dw.pos6)
                        {
                            GameData.weaponneedHp6 = 10;
                            GameData.weaponhpcount6 = 0;
                            GameData.weaponneedStamina6 = 10;
                            GameData.weaponStaminacount6 = 0;
                            GameData.weaponneedAttack6 = 1;
                            GameData.weaponAttackcount6 = 0;
                            GameData.weaponneedGuard6 = 1;
                            GameData.weaponGuardcount6 = 0;
                            GameData.weaponneedLuck6 = 1;
                            GameData.weaponLuckcount6 = 0;
                            Destroy(rare.star6);
                        }
                        else if (moto == dw.pos7)
                        {
                            GameData.weaponneedHp7 = 10;
                            GameData.weaponhpcount7 = 0;
                            GameData.weaponneedStamina7 = 10;
                            GameData.weaponStaminacount7 = 0;
                            GameData.weaponneedAttack7 = 1;
                            GameData.weaponAttackcount7 = 0;
                            GameData.weaponneedGuard7 = 1;
                            GameData.weaponGuardcount7 = 0;
                            GameData.weaponneedLuck7 = 1;
                            GameData.weaponLuckcount7 = 0;
                            Destroy(rare.star7);
                        }
                        else if (moto == dw.pos8)
                        {
                            GameData.weaponneedHp8 = 10;
                            GameData.weaponhpcount8 = 0;
                            GameData.weaponneedStamina8 = 10;
                            GameData.weaponStaminacount8 = 0;
                            GameData.weaponneedAttack8 = 1;
                            GameData.weaponAttackcount8 = 0;
                            GameData.weaponneedGuard8 = 1;
                            GameData.weaponGuardcount8 = 0;
                            GameData.weaponneedLuck8 = 1;
                            GameData.weaponLuckcount8 = 0;
                            Destroy(rare.star8);
                        }
                        else if (moto == dw.pos9)
                        {
                            GameData.weaponneedHp9 = 10;
                            GameData.weaponhpcount9 = 0;
                            GameData.weaponneedStamina9 = 10;
                            GameData.weaponStaminacount9 = 0;
                            GameData.weaponneedAttack9 = 1;
                            GameData.weaponAttackcount9 = 0;
                            GameData.weaponneedGuard9 = 1;
                            GameData.weaponGuardcount9 = 0;
                            GameData.weaponneedLuck9 = 1;
                            GameData.weaponLuckcount9 = 0;
                            Destroy(rare.star9);
                        }
                        else if (moto == dw.pos10)
                        {
                            GameData.weaponneedHp10 = 10;
                            GameData.weaponhpcount10 = 0;
                            GameData.weaponneedStamina10 = 10;
                            GameData.weaponStaminacount10 = 0;
                            GameData.weaponneedAttack10 = 1;
                            GameData.weaponAttackcount10 = 0;
                            GameData.weaponneedGuard10 = 1;
                            GameData.weaponGuardcount10 = 0;
                            GameData.weaponneedLuck10 = 1;
                            GameData.weaponLuckcount10 = 0;
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
                            Destroy(dw.pos1);
                            dw.pos1 = null;
                            GameData.inventoryWeapon1 = 999;
                            Destroy(rare.star1);
                        }
                        else if (sozai == dw.pos2)
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
                            Destroy(dw.pos2);
                            dw.pos2 = null;
                            GameData.inventoryWeapon2 = 999;
                            Destroy(rare.star2);
                        }
                        else if (sozai == dw.pos3)
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
                            Destroy(dw.pos3);
                            dw.pos3 = null;
                            GameData.inventoryWeapon3 = 999;
                            Destroy(rare.star3);
                        }
                        else if (sozai == dw.pos4)
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
                            Destroy(dw.pos4);
                            dw.pos4 = null;
                            GameData.inventoryWeapon4 = 999;
                            Destroy(rare.star4);
                        }
                        else if (sozai == dw.pos5)
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
                            Destroy(dw.pos5);
                            dw.pos5 = null;
                            GameData.inventoryWeapon5 = 999;
                            Destroy(rare.star5);
                        }
                        else if (sozai == dw.pos6)
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
                            Destroy(dw.pos6);
                            dw.pos6 = null;
                            GameData.inventoryWeapon6 = 999;
                            Destroy(rare.star6);
                        }
                        else if (sozai == dw.pos7)
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
                            Destroy(dw.pos7);
                            dw.pos7 = null;
                            GameData.inventoryWeapon7 = 999;
                            Destroy(rare.star7);
                        }
                        else if (sozai == dw.pos8)
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
                            Destroy(dw.pos8);
                            dw.pos8 = null;
                            GameData.inventoryWeapon8 = 999;
                            Destroy(rare.star8);
                        }
                        else if (sozai == dw.pos9)
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
                            Destroy(dw.pos9);
                            dw.pos9 = null;
                            GameData.inventoryWeapon9 = 999;
                            Destroy(rare.star9);
                        }
                        else if (sozai == dw.pos10)
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
                            Destroy(dw.pos10);
                            dw.pos10 = null;
                            GameData.inventoryWeapon10 = 999;
                            Destroy(rare.star10);
                        }

                        if (moto == dw.pos1)
                        {
                            GameData.weaponneedHp1 = 10;
                            GameData.weaponhpcount1 = 0;
                            GameData.weaponneedStamina1 = 10;
                            GameData.weaponStaminacount1 = 0;
                            GameData.weaponneedAttack1 = 1;
                            GameData.weaponAttackcount1 = 0;
                            GameData.weaponneedGuard1 = 1;
                            GameData.weaponGuardcount1 = 0;
                            GameData.weaponneedLuck1 = 1;
                            GameData.weaponLuckcount1 = 0;
                            Destroy(rare.star1);
                        }
                        else if (moto == dw.pos2)
                        {
                            GameData.weaponneedHp2 = 10;
                            GameData.weaponhpcount2 = 0;
                            GameData.weaponneedStamina2 = 10;
                            GameData.weaponStaminacount2 = 0;
                            GameData.weaponneedAttack2 = 1;
                            GameData.weaponAttackcount2 = 0;
                            GameData.weaponneedGuard2 = 1;
                            GameData.weaponGuardcount2 = 0;
                            GameData.weaponneedLuck2 = 1;
                            GameData.weaponLuckcount2 = 0;
                            Destroy(rare.star2);
                        }
                        else if (moto == dw.pos3)
                        {
                            GameData.weaponneedHp3 = 10;
                            GameData.weaponhpcount3 = 0;
                            GameData.weaponneedStamina3 = 10;
                            GameData.weaponStaminacount3 = 0;
                            GameData.weaponneedAttack3 = 1;
                            GameData.weaponAttackcount3 = 0;
                            GameData.weaponneedGuard3 = 1;
                            GameData.weaponGuardcount3 = 0;
                            GameData.weaponneedLuck3 = 1;
                            GameData.weaponLuckcount3 = 0;
                            Destroy(rare.star3);
                        }
                        else if (moto == dw.pos4)
                        {
                            GameData.weaponneedHp4 = 10;
                            GameData.weaponhpcount4 = 0;
                            GameData.weaponneedStamina4 = 10;
                            GameData.weaponStaminacount4 = 0;
                            GameData.weaponneedAttack4 = 1;
                            GameData.weaponAttackcount4 = 0;
                            GameData.weaponneedGuard4 = 1;
                            GameData.weaponGuardcount4 = 0;
                            GameData.weaponneedLuck4 = 1;
                            GameData.weaponLuckcount4 = 0;
                            Destroy(rare.star4);
                        }
                        else if (moto == dw.pos5)
                        {
                            GameData.weaponneedHp5 = 10;
                            GameData.weaponhpcount5 = 0;
                            GameData.weaponneedStamina5 = 10;
                            GameData.weaponStaminacount5 = 0;
                            GameData.weaponneedAttack5 = 1;
                            GameData.weaponAttackcount5 = 0;
                            GameData.weaponneedGuard5 = 1;
                            GameData.weaponGuardcount5 = 0;
                            GameData.weaponneedLuck5 = 1;
                            GameData.weaponLuckcount5 = 0;
                            Destroy(rare.star5);
                        }
                        else if (moto == dw.pos6)
                        {
                            GameData.weaponneedHp6 = 10;
                            GameData.weaponhpcount6 = 0;
                            GameData.weaponneedStamina6 = 10;
                            GameData.weaponStaminacount6 = 0;
                            GameData.weaponneedAttack6 = 1;
                            GameData.weaponAttackcount6 = 0;
                            GameData.weaponneedGuard6 = 1;
                            GameData.weaponGuardcount6 = 0;
                            GameData.weaponneedLuck6 = 1;
                            GameData.weaponLuckcount6 = 0;
                            Destroy(rare.star6);
                        }
                        else if (moto == dw.pos7)
                        {
                            GameData.weaponneedHp7 = 10;
                            GameData.weaponhpcount7 = 0;
                            GameData.weaponneedStamina7 = 10;
                            GameData.weaponStaminacount7 = 0;
                            GameData.weaponneedAttack7 = 1;
                            GameData.weaponAttackcount7 = 0;
                            GameData.weaponneedGuard7 = 1;
                            GameData.weaponGuardcount7 = 0;
                            GameData.weaponneedLuck7 = 1;
                            GameData.weaponLuckcount7 = 0;
                            Destroy(rare.star7);
                        }
                        else if (moto == dw.pos8)
                        {
                            GameData.weaponneedHp8 = 10;
                            GameData.weaponhpcount8 = 0;
                            GameData.weaponneedStamina8 = 10;
                            GameData.weaponStaminacount8 = 0;
                            GameData.weaponneedAttack8 = 1;
                            GameData.weaponAttackcount8 = 0;
                            GameData.weaponneedGuard8 = 1;
                            GameData.weaponGuardcount8 = 0;
                            GameData.weaponneedLuck8 = 1;
                            GameData.weaponLuckcount8 = 0;
                            Destroy(rare.star8);
                        }
                        else if (moto == dw.pos9)
                        {
                            GameData.weaponneedHp9 = 10;
                            GameData.weaponhpcount9 = 0;
                            GameData.weaponneedStamina9 = 10;
                            GameData.weaponStaminacount9 = 0;
                            GameData.weaponneedAttack9 = 1;
                            GameData.weaponAttackcount9 = 0;
                            GameData.weaponneedGuard9 = 1;
                            GameData.weaponGuardcount9 = 0;
                            GameData.weaponneedLuck9 = 1;
                            GameData.weaponLuckcount9 = 0;
                            Destroy(rare.star9);
                        }
                        else if (moto == dw.pos10)
                        {
                            GameData.weaponneedHp10 = 10;
                            GameData.weaponhpcount10 = 0;
                            GameData.weaponneedStamina10 = 10;
                            GameData.weaponStaminacount10 = 0;
                            GameData.weaponneedAttack10 = 1;
                            GameData.weaponAttackcount10 = 0;
                            GameData.weaponneedGuard10 = 1;
                            GameData.weaponGuardcount10 = 0;
                            GameData.weaponneedLuck10 = 1;
                            GameData.weaponLuckcount10 = 0;
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
                            Destroy(dw.pos1);
                            dw.pos1 = null;
                            GameData.inventoryWeapon1 = 999;
                            Destroy(rare.star1);
                        }
                        else if (sozai == dw.pos2)
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
                            Destroy(dw.pos2);
                            dw.pos2 = null;
                            GameData.inventoryWeapon2 = 999;
                            Destroy(rare.star2);
                        }
                        else if (sozai == dw.pos3)
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
                            Destroy(dw.pos3);
                            dw.pos3 = null;
                            GameData.inventoryWeapon3 = 999;
                            Destroy(rare.star3);
                        }
                        else if (sozai == dw.pos4)
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
                            Destroy(dw.pos4);
                            dw.pos4 = null;
                            GameData.inventoryWeapon4 = 999;
                            Destroy(rare.star4);
                        }
                        else if (sozai == dw.pos5)
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
                            Destroy(dw.pos5);
                            dw.pos5 = null;
                            GameData.inventoryWeapon5 = 999;
                            Destroy(rare.star5);
                        }
                        else if (sozai == dw.pos6)
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
                            Destroy(dw.pos6);
                            dw.pos6 = null;
                            GameData.inventoryWeapon6 = 999;
                            Destroy(rare.star6);
                        }
                        else if (sozai == dw.pos7)
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
                            Destroy(dw.pos7);
                            dw.pos7 = null;
                            GameData.inventoryWeapon7 = 999;
                            Destroy(rare.star7);
                        }
                        else if (sozai == dw.pos8)
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
                            Destroy(dw.pos8);
                            dw.pos8 = null;
                            GameData.inventoryWeapon8 = 999;
                            Destroy(rare.star8);
                        }
                        else if (sozai == dw.pos9)
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
                            Destroy(dw.pos9);
                            dw.pos9 = null;
                            GameData.inventoryWeapon9 = 999;
                            Destroy(rare.star9);
                        }
                        else if (sozai == dw.pos10)
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
                            Destroy(dw.pos10);
                            dw.pos10 = null;
                            GameData.inventoryWeapon10 = 999;
                            Destroy(rare.star10);
                        }

                        if (moto == dw.pos1)
                        {
                            GameData.weaponneedHp1 = 10;
                            GameData.weaponhpcount1 = 0;
                            GameData.weaponneedStamina1 = 10;
                            GameData.weaponStaminacount1 = 0;
                            GameData.weaponneedAttack1 = 1;
                            GameData.weaponAttackcount1 = 0;
                            GameData.weaponneedGuard1 = 1;
                            GameData.weaponGuardcount1 = 0;
                            GameData.weaponneedLuck1 = 1;
                            GameData.weaponLuckcount1 = 0;
                            Destroy(rare.star1);
                        }
                        else if (moto == dw.pos2)
                        {
                            GameData.weaponneedHp2 = 10;
                            GameData.weaponhpcount2 = 0;
                            GameData.weaponneedStamina2 = 10;
                            GameData.weaponStaminacount2 = 0;
                            GameData.weaponneedAttack2 = 1;
                            GameData.weaponAttackcount2 = 0;
                            GameData.weaponneedGuard2 = 1;
                            GameData.weaponGuardcount2 = 0;
                            GameData.weaponneedLuck2 = 1;
                            GameData.weaponLuckcount2 = 0;
                            Destroy(rare.star2);
                        }
                        else if (moto == dw.pos3)
                        {
                            GameData.weaponneedHp3 = 10;
                            GameData.weaponhpcount3 = 0;
                            GameData.weaponneedStamina3 = 10;
                            GameData.weaponStaminacount3 = 0;
                            GameData.weaponneedAttack3 = 1;
                            GameData.weaponAttackcount3 = 0;
                            GameData.weaponneedGuard3 = 1;
                            GameData.weaponGuardcount3 = 0;
                            GameData.weaponneedLuck3 = 1;
                            GameData.weaponLuckcount3 = 0;
                            Destroy(rare.star3);
                        }
                        else if (moto == dw.pos4)
                        {
                            GameData.weaponneedHp4 = 10;
                            GameData.weaponhpcount4 = 0;
                            GameData.weaponneedStamina4 = 10;
                            GameData.weaponStaminacount4 = 0;
                            GameData.weaponneedAttack4 = 1;
                            GameData.weaponAttackcount4 = 0;
                            GameData.weaponneedGuard4 = 1;
                            GameData.weaponGuardcount4 = 0;
                            GameData.weaponneedLuck4 = 1;
                            GameData.weaponLuckcount4 = 0;
                            Destroy(rare.star4);
                        }
                        else if (moto == dw.pos5)
                        {
                            GameData.weaponneedHp5 = 10;
                            GameData.weaponhpcount5 = 0;
                            GameData.weaponneedStamina5 = 10;
                            GameData.weaponStaminacount5 = 0;
                            GameData.weaponneedAttack5 = 1;
                            GameData.weaponAttackcount5 = 0;
                            GameData.weaponneedGuard5 = 1;
                            GameData.weaponGuardcount5 = 0;
                            GameData.weaponneedLuck5 = 1;
                            GameData.weaponLuckcount5 = 0;
                            Destroy(rare.star5);
                        }
                        else if (moto == dw.pos6)
                        {
                            GameData.weaponneedHp6 = 10;
                            GameData.weaponhpcount6 = 0;
                            GameData.weaponneedStamina6 = 10;
                            GameData.weaponStaminacount6 = 0;
                            GameData.weaponneedAttack6 = 1;
                            GameData.weaponAttackcount6 = 0;
                            GameData.weaponneedGuard6 = 1;
                            GameData.weaponGuardcount6 = 0;
                            GameData.weaponneedLuck6 = 1;
                            GameData.weaponLuckcount6 = 0;
                            Destroy(rare.star6);
                        }
                        else if (moto == dw.pos7)
                        {
                            GameData.weaponneedHp7 = 10;
                            GameData.weaponhpcount7 = 0;
                            GameData.weaponneedStamina7 = 10;
                            GameData.weaponStaminacount7 = 0;
                            GameData.weaponneedAttack7 = 1;
                            GameData.weaponAttackcount7 = 0;
                            GameData.weaponneedGuard7 = 1;
                            GameData.weaponGuardcount7 = 0;
                            GameData.weaponneedLuck7 = 1;
                            GameData.weaponLuckcount7 = 0;
                            Destroy(rare.star7);
                        }
                        else if (moto == dw.pos8)
                        {
                            GameData.weaponneedHp8 = 10;
                            GameData.weaponhpcount8 = 0;
                            GameData.weaponneedStamina8 = 10;
                            GameData.weaponStaminacount8 = 0;
                            GameData.weaponneedAttack8 = 1;
                            GameData.weaponAttackcount8 = 0;
                            GameData.weaponneedGuard8 = 1;
                            GameData.weaponGuardcount8 = 0;
                            GameData.weaponneedLuck8 = 1;
                            GameData.weaponLuckcount8 = 0;
                            Destroy(rare.star8);
                        }
                        else if (moto == dw.pos9)
                        {
                            GameData.weaponneedHp9 = 10;
                            GameData.weaponhpcount9 = 0;
                            GameData.weaponneedStamina9 = 10;
                            GameData.weaponStaminacount9 = 0;
                            GameData.weaponneedAttack9 = 1;
                            GameData.weaponAttackcount9 = 0;
                            GameData.weaponneedGuard9 = 1;
                            GameData.weaponGuardcount9 = 0;
                            GameData.weaponneedLuck9 = 1;
                            GameData.weaponLuckcount9 = 0;
                            Destroy(rare.star9);
                        }
                        else if (moto == dw.pos10)
                        {
                            GameData.weaponneedHp10 = 10;
                            GameData.weaponhpcount10 = 0;
                            GameData.weaponneedStamina10 = 10;
                            GameData.weaponStaminacount10 = 0;
                            GameData.weaponneedAttack10 = 1;
                            GameData.weaponAttackcount10 = 0;
                            GameData.weaponneedGuard10 = 1;
                            GameData.weaponGuardcount10 = 0;
                            GameData.weaponneedLuck10 = 1;
                            GameData.weaponLuckcount10 = 0;
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
                            Destroy(dw.pos1);
                            dw.pos1 = null;
                            GameData.inventoryWeapon1 = 999;
                            Destroy(rare.star1);
                        }
                        else if (sozai == dw.pos2)
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
                            Destroy(dw.pos2);
                            dw.pos2 = null;
                            GameData.inventoryWeapon2 = 999;
                            Destroy(rare.star2);
                        }
                        else if (sozai == dw.pos3)
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
                            Destroy(dw.pos3);
                            dw.pos3 = null;
                            GameData.inventoryWeapon3 = 999;
                            Destroy(rare.star3);
                        }
                        else if (sozai == dw.pos4)
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
                            Destroy(dw.pos4);
                            dw.pos4 = null;
                            GameData.inventoryWeapon4 = 999;
                            Destroy(rare.star4);
                        }
                        else if (sozai == dw.pos5)
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
                            Destroy(dw.pos5);
                            dw.pos5 = null;
                            GameData.inventoryWeapon5 = 999;
                            Destroy(rare.star5);
                        }
                        else if (sozai == dw.pos6)
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
                            Destroy(dw.pos6);
                            dw.pos6 = null;
                            GameData.inventoryWeapon6 = 999;
                            Destroy(rare.star6);
                        }
                        else if (sozai == dw.pos7)
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
                            Destroy(dw.pos7);
                            dw.pos7 = null;
                            GameData.inventoryWeapon7 = 999;
                            Destroy(rare.star7);
                        }
                        else if (sozai == dw.pos8)
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
                            Destroy(dw.pos8);
                            dw.pos8 = null;
                            GameData.inventoryWeapon8 = 999;
                            Destroy(rare.star8);
                        }
                        else if (sozai == dw.pos9)
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
                            Destroy(dw.pos9);
                            dw.pos9 = null;
                            GameData.inventoryWeapon9 = 999;
                            Destroy(rare.star9);
                        }
                        else if (sozai == dw.pos10)
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
                            Destroy(dw.pos10);
                            dw.pos10 = null;
                            GameData.inventoryWeapon10 = 999;
                            Destroy(rare.star10);
                        }

                        if (moto == dw.pos1)
                        {
                            GameData.weaponneedHp1 = 10;
                            GameData.weaponhpcount1 = 0;
                            GameData.weaponneedStamina1 = 10;
                            GameData.weaponStaminacount1 = 0;
                            GameData.weaponneedAttack1 = 1;
                            GameData.weaponAttackcount1 = 0;
                            GameData.weaponneedGuard1 = 1;
                            GameData.weaponGuardcount1 = 0;
                            GameData.weaponneedLuck1 = 1;
                            GameData.weaponLuckcount1 = 0;
                            Destroy(rare.star1);
                        }
                        else if (moto == dw.pos2)
                        {
                            GameData.weaponneedHp2 = 10;
                            GameData.weaponhpcount2 = 0;
                            GameData.weaponneedStamina2 = 10;
                            GameData.weaponStaminacount2 = 0;
                            GameData.weaponneedAttack2 = 1;
                            GameData.weaponAttackcount2 = 0;
                            GameData.weaponneedGuard2 = 1;
                            GameData.weaponGuardcount2 = 0;
                            GameData.weaponneedLuck2 = 1;
                            GameData.weaponLuckcount2 = 0;
                            Destroy(rare.star2);
                        }
                        else if (moto == dw.pos3)
                        {
                            GameData.weaponneedHp3 = 10;
                            GameData.weaponhpcount3 = 0;
                            GameData.weaponneedStamina3 = 10;
                            GameData.weaponStaminacount3 = 0;
                            GameData.weaponneedAttack3 = 1;
                            GameData.weaponAttackcount3 = 0;
                            GameData.weaponneedGuard3 = 1;
                            GameData.weaponGuardcount3 = 0;
                            GameData.weaponneedLuck3 = 1;
                            GameData.weaponLuckcount3 = 0;
                            Destroy(rare.star3);
                        }
                        else if (moto == dw.pos4)
                        {
                            GameData.weaponneedHp4 = 10;
                            GameData.weaponhpcount4 = 0;
                            GameData.weaponneedStamina4 = 10;
                            GameData.weaponStaminacount4 = 0;
                            GameData.weaponneedAttack4 = 1;
                            GameData.weaponAttackcount4 = 0;
                            GameData.weaponneedGuard4 = 1;
                            GameData.weaponGuardcount4 = 0;
                            GameData.weaponneedLuck4 = 1;
                            GameData.weaponLuckcount4 = 0;
                            Destroy(rare.star4);
                        }
                        else if (moto == dw.pos5)
                        {
                            GameData.weaponneedHp5 = 10;
                            GameData.weaponhpcount5 = 0;
                            GameData.weaponneedStamina5 = 10;
                            GameData.weaponStaminacount5 = 0;
                            GameData.weaponneedAttack5 = 1;
                            GameData.weaponAttackcount5 = 0;
                            GameData.weaponneedGuard5 = 1;
                            GameData.weaponGuardcount5 = 0;
                            GameData.weaponneedLuck5 = 1;
                            GameData.weaponLuckcount5 = 0;
                            Destroy(rare.star5);
                        }
                        else if (moto == dw.pos6)
                        {
                            GameData.weaponneedHp6 = 10;
                            GameData.weaponhpcount6 = 0;
                            GameData.weaponneedStamina6 = 10;
                            GameData.weaponStaminacount6 = 0;
                            GameData.weaponneedAttack6 = 1;
                            GameData.weaponAttackcount6 = 0;
                            GameData.weaponneedGuard6 = 1;
                            GameData.weaponGuardcount6 = 0;
                            GameData.weaponneedLuck6 = 1;
                            GameData.weaponLuckcount6 = 0;
                            Destroy(rare.star6);
                        }
                        else if (moto == dw.pos7)
                        {
                            GameData.weaponneedHp7 = 10;
                            GameData.weaponhpcount7 = 0;
                            GameData.weaponneedStamina7 = 10;
                            GameData.weaponStaminacount7 = 0;
                            GameData.weaponneedAttack7 = 1;
                            GameData.weaponAttackcount7 = 0;
                            GameData.weaponneedGuard7 = 1;
                            GameData.weaponGuardcount7 = 0;
                            GameData.weaponneedLuck7 = 1;
                            GameData.weaponLuckcount7 = 0;
                            Destroy(rare.star7);
                        }
                        else if (moto == dw.pos8)
                        {
                            GameData.weaponneedHp8 = 10;
                            GameData.weaponhpcount8 = 0;
                            GameData.weaponneedStamina8 = 10;
                            GameData.weaponStaminacount8 = 0;
                            GameData.weaponneedAttack8 = 1;
                            GameData.weaponAttackcount8 = 0;
                            GameData.weaponneedGuard8 = 1;
                            GameData.weaponGuardcount8 = 0;
                            GameData.weaponneedLuck8 = 1;
                            GameData.weaponLuckcount8 = 0;
                            Destroy(rare.star8);
                        }
                        else if (moto == dw.pos9)
                        {
                            GameData.weaponneedHp9 = 10;
                            GameData.weaponhpcount9 = 0;
                            GameData.weaponneedStamina9 = 10;
                            GameData.weaponStaminacount9 = 0;
                            GameData.weaponneedAttack9 = 1;
                            GameData.weaponAttackcount9 = 0;
                            GameData.weaponneedGuard9 = 1;
                            GameData.weaponGuardcount9 = 0;
                            GameData.weaponneedLuck9 = 1;
                            GameData.weaponLuckcount9 = 0;
                            Destroy(rare.star9);
                        }
                        else if (moto == dw.pos10)
                        {
                            GameData.weaponneedHp10 = 10;
                            GameData.weaponhpcount10 = 0;
                            GameData.weaponneedStamina10 = 10;
                            GameData.weaponStaminacount10 = 0;
                            GameData.weaponneedAttack10 = 1;
                            GameData.weaponAttackcount10 = 0;
                            GameData.weaponneedGuard10 = 1;
                            GameData.weaponGuardcount10 = 0;
                            GameData.weaponneedLuck10 = 1;
                            GameData.weaponLuckcount10 = 0;
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
