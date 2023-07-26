using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : MonoBehaviour
{

    public int[] weaponDataID = new int[10];
    public int[] weaponRarity = new int[10];
    public int[] weaponHp = new int[10];
    public int[] weaponStamina = new int[10];
    public int[] weaponAttack = new int[10];
    public int[] weaponGuard = new int[10];
    public int[] weaponLuck = new int[10];
    public int[] weaponLevel = new int[10];

    public int[,] dataPlus = new int[7, 10];

    public DataBase db;


    public void InventoryWeaponData()
    {
        for (int i = 0; i < 10; i++)
        {
            if (weaponDataID[i] != 999)
            {
                dataPlus[0, i] = db.weapons[weaponDataID[i]].weaponRarity;
                dataPlus[1, i] = db.weapons[weaponDataID[i]].weaponHp;
                dataPlus[2, i] = db.weapons[weaponDataID[i]].weaponStamina;
                dataPlus[3, i] = db.weapons[weaponDataID[i]].weaponAttack;
                dataPlus[4, i] = db.weapons[weaponDataID[i]].weaponGuard;
                dataPlus[5, i] = db.weapons[weaponDataID[i]].weaponLuck;
                dataPlus[6, i] = db.weapons[weaponDataID[i]].weaponLevel;
            }
        }

        GameData.weaponRarity1 = dataPlus[0, 0];
        GameData.weaponRarity2 = dataPlus[0, 1];
        GameData.weaponRarity3 = dataPlus[0, 2];
        GameData.weaponRarity4 = dataPlus[0, 3];
        GameData.weaponRarity5 = dataPlus[0, 4];
        GameData.weaponRarity6 = dataPlus[0, 5];
        GameData.weaponRarity7 = dataPlus[0, 6];
        GameData.weaponRarity8 = dataPlus[0, 7];
        GameData.weaponRarity9 = dataPlus[0, 8];
        GameData.weaponRarity10 = dataPlus[0, 9];

        GameData.weaponHp1 = dataPlus[1, 0];
        GameData.weaponHp2 = dataPlus[1, 1];
        GameData.weaponHp3 = dataPlus[1, 2];
        GameData.weaponHp4 = dataPlus[1, 3];
        GameData.weaponHp5 = dataPlus[1, 4];
        GameData.weaponHp6 = dataPlus[1, 5];
        GameData.weaponHp7 = dataPlus[1, 6];
        GameData.weaponHp8 = dataPlus[1, 7];
        GameData.weaponHp9 = dataPlus[1, 8];
        GameData.weaponHp10 = dataPlus[1, 9];

        GameData.weaponStamina1 = dataPlus[2, 0];
        GameData.weaponStamina2 = dataPlus[2, 1];
        GameData.weaponStamina3 = dataPlus[2, 2];
        GameData.weaponStamina4 = dataPlus[2, 3];
        GameData.weaponStamina5 = dataPlus[2, 4];
        GameData.weaponStamina6 = dataPlus[2, 5];
        GameData.weaponStamina7 = dataPlus[2, 6];
        GameData.weaponStamina8 = dataPlus[2, 7];
        GameData.weaponStamina9 = dataPlus[2, 8];
        GameData.weaponStamina10 = dataPlus[2, 9];

        GameData.weaponAttack1 = dataPlus[3, 0];
        GameData.weaponAttack2 = dataPlus[3, 1];
        GameData.weaponAttack3 = dataPlus[3, 2];
        GameData.weaponAttack4 = dataPlus[3, 3];
        GameData.weaponAttack5 = dataPlus[3, 4];
        GameData.weaponAttack6 = dataPlus[3, 5];
        GameData.weaponAttack7 = dataPlus[3, 6];
        GameData.weaponAttack8 = dataPlus[3, 7];
        GameData.weaponAttack9 = dataPlus[3, 8];
        GameData.weaponAttack10 = dataPlus[3, 9];

        GameData.weaponGuard1 = dataPlus[4, 0];
        GameData.weaponGuard2 = dataPlus[4, 1];
        GameData.weaponGuard3 = dataPlus[4, 2];
        GameData.weaponGuard4 = dataPlus[4, 3];
        GameData.weaponGuard5 = dataPlus[4, 4];
        GameData.weaponGuard6 = dataPlus[4, 5];
        GameData.weaponGuard7 = dataPlus[4, 6];
        GameData.weaponGuard8 = dataPlus[4, 7];
        GameData.weaponGuard9 = dataPlus[4, 8];
        GameData.weaponGuard10 = dataPlus[4, 9];

        GameData.weaponLuck1 = dataPlus[5, 0];
        GameData.weaponLuck2 = dataPlus[5, 1];
        GameData.weaponLuck3 = dataPlus[5, 2];
        GameData.weaponLuck4 = dataPlus[5, 3];
        GameData.weaponLuck5 = dataPlus[5, 4];
        GameData.weaponLuck6 = dataPlus[5, 5];
        GameData.weaponLuck7 = dataPlus[5, 6];
        GameData.weaponLuck8 = dataPlus[5, 7];
        GameData.weaponLuck9 = dataPlus[5, 8];
        GameData.weaponLuck10 = dataPlus[5, 9];

        GameData.weaponLevel1 = dataPlus[6, 0];
        GameData.weaponLevel2 = dataPlus[6, 1];
        GameData.weaponLevel3 = dataPlus[6, 2];
        GameData.weaponLevel4 = dataPlus[6, 3];
        GameData.weaponLevel5 = dataPlus[6, 4];
        GameData.weaponLevel6 = dataPlus[6, 5];
        GameData.weaponLevel7 = dataPlus[6, 6];
        GameData.weaponLevel8 = dataPlus[6, 7];
        GameData.weaponLevel9 = dataPlus[6, 8];
        GameData.weaponLevel10 = dataPlus[6, 9];
    }
}
