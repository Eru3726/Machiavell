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

        GameData.weaponRarity[0] = dataPlus[0, 0];
        GameData.weaponRarity[1] = dataPlus[0, 1];
        GameData.weaponRarity[2] = dataPlus[0, 2];
        GameData.weaponRarity[3] = dataPlus[0, 3];
        GameData.weaponRarity[4] = dataPlus[0, 4];
        GameData.weaponRarity[5] = dataPlus[0, 5];
        GameData.weaponRarity[6] = dataPlus[0, 6];
        GameData.weaponRarity[7] = dataPlus[0, 7];
        GameData.weaponRarity[8] = dataPlus[0, 8];
        GameData.weaponRarity[9] = dataPlus[0, 9];

        GameData.weaponHp[0] = dataPlus[1, 0];
        GameData.weaponHp[1] = dataPlus[1, 1];
        GameData.weaponHp[2] = dataPlus[1, 2];
        GameData.weaponHp[3] = dataPlus[1, 3];
        GameData.weaponHp[4] = dataPlus[1, 4];
        GameData.weaponHp[5] = dataPlus[1, 5];
        GameData.weaponHp[6] = dataPlus[1, 6];
        GameData.weaponHp[7] = dataPlus[1, 7];
        GameData.weaponHp[8] = dataPlus[1, 8];
        GameData.weaponHp[9] = dataPlus[1, 9];

        GameData.weaponStamina[0] = dataPlus[2, 0];
        GameData.weaponStamina[1] = dataPlus[2, 1];
        GameData.weaponStamina[2] = dataPlus[2, 2];
        GameData.weaponStamina[3] = dataPlus[2, 3];
        GameData.weaponStamina[4] = dataPlus[2, 4];
        GameData.weaponStamina[5] = dataPlus[2, 5];
        GameData.weaponStamina[6] = dataPlus[2, 6];
        GameData.weaponStamina[7] = dataPlus[2, 7];
        GameData.weaponStamina[8] = dataPlus[2, 8];
        GameData.weaponStamina[9] = dataPlus[2, 9];

        GameData.weaponAttack[0] = dataPlus[3, 0];
        GameData.weaponAttack[1] = dataPlus[3, 1];
        GameData.weaponAttack[2] = dataPlus[3, 2];
        GameData.weaponAttack[3] = dataPlus[3, 3];
        GameData.weaponAttack[4] = dataPlus[3, 4];
        GameData.weaponAttack[5] = dataPlus[3, 5];
        GameData.weaponAttack[6] = dataPlus[3, 6];
        GameData.weaponAttack[7] = dataPlus[3, 7];
        GameData.weaponAttack[8] = dataPlus[3, 8];
        GameData.weaponAttack[9] = dataPlus[3, 9];

        GameData.weaponGuard[0] = dataPlus[4, 0];
        GameData.weaponGuard[1] = dataPlus[4, 1];
        GameData.weaponGuard[2] = dataPlus[4, 2];
        GameData.weaponGuard[3] = dataPlus[4, 3];
        GameData.weaponGuard[4] = dataPlus[4, 4];
        GameData.weaponGuard[5] = dataPlus[4, 5];
        GameData.weaponGuard[6] = dataPlus[4, 6];
        GameData.weaponGuard[7] = dataPlus[4, 7];
        GameData.weaponGuard[8] = dataPlus[4, 8];
        GameData.weaponGuard[9] = dataPlus[4, 9];

        GameData.weaponLuck[0] = dataPlus[5, 0];
        GameData.weaponLuck[1] = dataPlus[5, 1];
        GameData.weaponLuck[2] = dataPlus[5, 2];
        GameData.weaponLuck[3] = dataPlus[5, 3];
        GameData.weaponLuck[4] = dataPlus[5, 4];
        GameData.weaponLuck[5] = dataPlus[5, 5];
        GameData.weaponLuck[6] = dataPlus[5, 6];
        GameData.weaponLuck[7] = dataPlus[5, 7];
        GameData.weaponLuck[8] = dataPlus[5, 8];
        GameData.weaponLuck[9] = dataPlus[5, 9];

        GameData.weaponLevel[0] = dataPlus[6, 0];
        GameData.weaponLevel[1] = dataPlus[6, 1];
        GameData.weaponLevel[2] = dataPlus[6, 2];
        GameData.weaponLevel[3] = dataPlus[6, 3];
        GameData.weaponLevel[4] = dataPlus[6, 4];
        GameData.weaponLevel[5] = dataPlus[6, 5];
        GameData.weaponLevel[6] = dataPlus[6, 6];
        GameData.weaponLevel[7] = dataPlus[6, 7];
        GameData.weaponLevel[8] = dataPlus[6, 8];
        GameData.weaponLevel[9] = dataPlus[6, 9];
    }
}
