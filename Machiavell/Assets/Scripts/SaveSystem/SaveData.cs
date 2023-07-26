using UnityEngine;
//セーブするための項目

[System.Serializable]
public class SaveData
{
    public KeyCode rightkey;
    public string righttx;
    public KeyCode leftkey;
    public string lefttx;
    public KeyCode jumpkey;
    public string jumptx;
    public KeyCode attackkey;
    public string attacktx;
    public KeyCode dashkey;
    public string dashtx;
    public KeyCode healkey;
    public string healtx;
    public KeyCode menukey;
    public string menutx;
    public KeyCode downkey;
    public string downtx;
    public KeyCode interactkey;
    public string interacttx;
    public int inventoryWeapon1;
    public int inventoryWeapon2;
    public int inventoryWeapon3;
    public int inventoryWeapon4;
    public int inventoryWeapon5;
    public int inventoryWeapon6;
    public int inventoryWeapon7;
    public int inventoryWeapon8;
    public int inventoryWeapon9;
    public int inventoryWeapon10;
    public int weaponRarity1;
    public int weaponRarity2;
    public int weaponRarity3;
    public int weaponRarity4;
    public int weaponRarity5;
    public int weaponRarity6;
    public int weaponRarity7;
    public int weaponRarity8;
    public int weaponRarity9;
    public int weaponRarity10;
    public int weaponHp1 = 10;
    public int weaponneedHp1 = 10;
    public int weaponhpcount1 = 0;
    public int weaponHp2 = 10;
    public int weaponneedHp2 = 10;
    public int weaponhpcount2 = 0;
    public int weaponHp3 = 10;
    public int weaponneedHp3 = 10;
    public int weaponhpcount3 = 0;
    public int weaponHp4 = 10;
    public int weaponneedHp4 = 10;
    public int weaponhpcount4 = 0;
    public int weaponHp5 = 10;
    public int weaponneedHp5 = 10;
    public int weaponhpcount5 = 0;
    public int weaponHp6 = 10;
    public int weaponneedHp6 = 10;
    public int weaponhpcount6 = 0;
    public int weaponHp7 = 10;
    public int weaponneedHp7 = 10;
    public int weaponhpcount7 = 0;
    public int weaponHp8 = 10;
    public int weaponneedHp8 = 10;
    public int weaponhpcount8 = 0;
    public int weaponHp9 = 10;
    public int weaponneedHp9 = 10;
    public int weaponhpcount9 = 0;
    public int weaponHp10 = 10;
    public int weaponneedHp10 = 10;
    public int weaponhpcount10 = 0;

    public int weaponStamina1 = 10;
    public int weaponneedStamina1 = 10;
    public int weaponStaminacount1 = 0;
    public int weaponStamina2 = 10;
    public int weaponneedStamina2 = 10;
    public int weaponStaminacount2 = 0;
    public int weaponStamina3 = 10;
    public int weaponneedStamina3 = 10;
    public int weaponStaminacount3 = 0;
    public int weaponStamina4 = 10;
    public int weaponneedStamina4 = 10;
    public int weaponStaminacount4 = 0;
    public int weaponStamina5 = 10;
    public int weaponneedStamina5 = 10;
    public int weaponStaminacount5 = 0;
    public int weaponStamina6 = 10;
    public int weaponneedStamina6 = 10;
    public int weaponStaminacount6 = 0;
    public int weaponStamina7 = 10;
    public int weaponneedStamina7 = 10;
    public int weaponStaminacount7 = 0;
    public int weaponStamina8 = 10;
    public int weaponneedStamina8 = 10;
    public int weaponStaminacount8 = 0;
    public int weaponStamina9 = 10;
    public int weaponneedStamina9 = 10;
    public int weaponStaminacount9 = 0;
    public int weaponStamina10 = 10;
    public int weaponneedStamina10 = 10;
    public int weaponStaminacount10 = 0;

    public int weaponAttack1 = 1;
    public int weaponneedAttack1 = 1;
    public int weaponAttackcount1 = 0;
    public int weaponAttack2 = 1;
    public int weaponneedAttack2 = 1;
    public int weaponAttackcount2 = 0;
    public int weaponAttack3 = 1;
    public int weaponneedAttack3 = 1;
    public int weaponAttackcount3 = 0;
    public int weaponAttack4 = 1;
    public int weaponneedAttack4 = 1;
    public int weaponAttackcount4 = 0;
    public int weaponAttack5 = 1;
    public int weaponneedAttack5 = 1;
    public int weaponAttackcount5 = 0;
    public int weaponAttack6 = 1;
    public int weaponneedAttack6 = 1;
    public int weaponAttackcount6 = 0;
    public int weaponAttack7 = 1;
    public int weaponneedAttack7 = 1;
    public int weaponAttackcount7 = 0;
    public int weaponAttack8 = 1;
    public int weaponneedAttack8 = 1;
    public int weaponAttackcount8 = 0;
    public int weaponAttack9 = 1;
    public int weaponneedAttack9 = 1;
    public int weaponAttackcount9 = 0;
    public int weaponAttack10 = 1;
    public int weaponneedAttack10 = 1;
    public int weaponAttackcount10 = 0;

    public int weaponGuard1 = 1;
    public int weaponneedGuard1 = 1;
    public int weaponGuardcount1 = 0;
    public int weaponGuard2 = 1;
    public int weaponneedGuard2 = 1;
    public int weaponGuardcount2 = 0;
    public int weaponGuard3 = 1;
    public int weaponneedGuard3 = 1;
    public int weaponGuardcount3 = 0;
    public int weaponGuard4 = 1;
    public int weaponneedGuard4 = 1;
    public int weaponGuardcount4 = 0;
    public int weaponGuard5 = 1;
    public int weaponneedGuard5 = 1;
    public int weaponGuardcount5 = 0;
    public int weaponGuard6 = 1;
    public int weaponneedGuard6 = 1;
    public int weaponGuardcount6 = 0;
    public int weaponGuard7 = 1;
    public int weaponneedGuard7 = 1;
    public int weaponGuardcount7 = 0;
    public int weaponGuard8 = 1;
    public int weaponneedGuard8 = 1;
    public int weaponGuardcount8 = 0;
    public int weaponGuard9 = 1;
    public int weaponneedGuard9 = 1;
    public int weaponGuardcount9 = 0;
    public int weaponGuard10 = 1;
    public int weaponneedGuard10 = 1;
    public int weaponGuardcount10 = 0;

    public int weaponLuck1 = 1;
    public int weaponneedLuck1 = 1;
    public int weaponLuckcount1 = 0;
    public int weaponLuck2 = 1;
    public int weaponneedLuck2 = 1;
    public int weaponLuckcount2 = 0;
    public int weaponLuck3 = 1;
    public int weaponneedLuck3 = 1;
    public int weaponLuckcount3 = 0;
    public int weaponLuck4 = 1;
    public int weaponneedLuck4 = 1;
    public int weaponLuckcount4 = 0;
    public int weaponLuck5 = 1;
    public int weaponneedLuck5 = 1;
    public int weaponLuckcount5 = 0;
    public int weaponLuck6 = 1;
    public int weaponneedLuck6 = 1;
    public int weaponLuckcount6 = 0;
    public int weaponLuck7 = 1;
    public int weaponneedLuck7 = 1;
    public int weaponLuckcount7 = 0;
    public int weaponLuck8 = 1;
    public int weaponneedLuck8 = 1;
    public int weaponLuckcount8 = 0;
    public int weaponLuck9 = 1;
    public int weaponneedLuck9 = 1;
    public int weaponLuckcount9 = 0;
    public int weaponLuck10 = 1;
    public int weaponneedLuck10 = 1;
    public int weaponLuckcount10 = 0;

    public int weaponLevel1 = 1;
    public int weaponLevel2 = 1;
    public int weaponLevel3 = 1;
    public int weaponLevel4 = 1;
    public int weaponLevel5 = 1;
    public int weaponLevel6 = 1;
    public int weaponLevel7 = 1;
    public int weaponLevel8 = 1;
    public int weaponLevel9 = 1;
    public int weaponLevel10 = 1;
    public int playerexp = 0;       //経験値
    public int playerlevel = 1;            //プレイヤーのレベル
    public int needEXP = 1;　　　　　　　//レベルをあげるために必要な経験値
    public int needEXPcount = 0;　　　　　　　//何回かに一回レベルをあげるために必要な経験値を増やす
    public int playerhp = 100;　　　　　　　　　　//プレイヤーの体力
    public int playerhpnow = 100;                //プレイヤーの現在の体力
    public int playerstamina = 100;　　　　　　　　　 //プレイヤーのスタミナ
    public int playeroffence = 1;                   //プレイヤーの攻撃
    public int playerdeffence = 1;                   //プレイヤーの防御
    public int playerluck = 1;                   //プレイヤーの運
    public int playerstatuspoint = 0;                   //プレイヤーのステータスポイント
    public int playerneedsp = 1;               //ステータス強化に必要なステータスポイント
    public int needspcount = 0;                //何回かにつき一回needsp増やすためのやつ
    public int soubi = 1;
    public bool first = true;

    public bool sky = true;　　　　　　　　　 //天空神殿にいること
    public bool save = false;                 //セーブポイントにいること
    public float healpotion = 0;        //ヒールポーション
}