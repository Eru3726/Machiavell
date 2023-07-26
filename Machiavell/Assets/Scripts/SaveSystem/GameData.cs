using UnityEngine;
//ゲーム中で保持しておきたい項目（初期の値は任意）

public class GameData
{
    public static KeyCode rightkey = KeyCode.D;
    public static string righttx = "D";
    public static KeyCode leftkey = KeyCode.A;
    public static string lefttx = "A";
    public static KeyCode jumpkey = KeyCode.Space;
    public static string jumptx = "Space";
    public static KeyCode attackkey = KeyCode.Mouse0;
    public static string attacktx = "Mouse0";
    public static KeyCode dashkey = KeyCode.LeftShift;
    public static string dashtx = "LeftShift";
    public static KeyCode healkey = KeyCode.H;
    public static string healtx = "H";
    public static KeyCode menukey = KeyCode.Escape;
    public static string menutx = "Escape";
    public static KeyCode downkey = KeyCode.S;
    public static string downtx = "S";
    public static KeyCode interactkey = KeyCode.E;
    public static string interacttx = "E";

    public static int inventoryWeapon1 = 999;
    public static int inventoryWeapon2 = 999;
    public static int inventoryWeapon3 = 999;
    public static int inventoryWeapon4 = 999;
    public static int inventoryWeapon5 = 999;
    public static int inventoryWeapon6 = 999;
    public static int inventoryWeapon7 = 999;
    public static int inventoryWeapon8 = 999;
    public static int inventoryWeapon9 = 999;
    public static int inventoryWeapon10 = 999;

    public static int weaponRarity1;
    public static int weaponRarity2;
    public static int weaponRarity3;
    public static int weaponRarity4;
    public static int weaponRarity5;
    public static int weaponRarity6;
    public static int weaponRarity7;
    public static int weaponRarity8;
    public static int weaponRarity9;
    public static int weaponRarity10;

    public static int weaponHp1 = 10;
    public static int weaponneedHp1 = 10;
    public static int weaponhpcount1 = 0;
    public static int weaponHp2 = 10;
    public static int weaponneedHp2 = 10;
    public static int weaponhpcount2 = 0;
    public static int weaponHp3 = 10;
    public static int weaponneedHp3 = 10;
    public static int weaponhpcount3 = 0;
    public static int weaponHp4 = 10;
    public static int weaponneedHp4 = 10;
    public static int weaponhpcount4 = 0;
    public static int weaponHp5 = 10;
    public static int weaponneedHp5 = 10;
    public static int weaponhpcount5 = 0;
    public static int weaponHp6 = 10;
    public static int weaponneedHp6 = 10;
    public static int weaponhpcount6 = 0;
    public static int weaponHp7 = 10;
    public static int weaponneedHp7 = 10;
    public static int weaponhpcount7 = 0;
    public static int weaponHp8 = 10;
    public static int weaponneedHp8 = 10;
    public static int weaponhpcount8 = 0;
    public static int weaponHp9 = 10;
    public static int weaponneedHp9 = 10;
    public static int weaponhpcount9 = 0;
    public static int weaponHp10 = 10;
    public static int weaponneedHp10 = 10;
    public static int weaponhpcount10 = 0;

    public static int weaponStamina1 = 10;
    public static int weaponneedStamina1 = 10;
    public static int weaponStaminacount1 = 0;
    public static int weaponStamina2 = 10;
    public static int weaponneedStamina2 = 10;
    public static int weaponStaminacount2 = 0;
    public static int weaponStamina3 = 10;
    public static int weaponneedStamina3 = 10;
    public static int weaponStaminacount3 = 0;
    public static int weaponStamina4 = 10;
    public static int weaponneedStamina4 = 10;
    public static int weaponStaminacount4 = 0;
    public static int weaponStamina5 = 10;
    public static int weaponneedStamina5 = 10;
    public static int weaponStaminacount5 = 0;
    public static int weaponStamina6 = 10;
    public static int weaponneedStamina6 = 10;
    public static int weaponStaminacount6 = 0;
    public static int weaponStamina7 = 10;
    public static int weaponneedStamina7 = 10;
    public static int weaponStaminacount7 = 0;
    public static int weaponStamina8 = 10;
    public static int weaponneedStamina8 = 10;
    public static int weaponStaminacount8 = 0;
    public static int weaponStamina9 = 10;
    public static int weaponneedStamina9 = 10;
    public static int weaponStaminacount9 = 0;
    public static int weaponStamina10 = 10;
    public static int weaponneedStamina10 = 10;
    public static int weaponStaminacount10 = 0;

    public static int weaponAttack1 = 1;
    public static int weaponneedAttack1 = 1;
    public static int weaponAttackcount1 = 0;
    public static int weaponAttack2 = 1;
    public static int weaponneedAttack2 = 1;
    public static int weaponAttackcount2 = 0;
    public static int weaponAttack3 = 1;
    public static int weaponneedAttack3 = 1;
    public static int weaponAttackcount3 = 0;
    public static int weaponAttack4 = 1;
    public static int weaponneedAttack4 = 1;
    public static int weaponAttackcount4 = 0;
    public static int weaponAttack5 = 1;
    public static int weaponneedAttack5 = 1;
    public static int weaponAttackcount5 = 0;
    public static int weaponAttack6 = 1;
    public static int weaponneedAttack6 = 1;
    public static int weaponAttackcount6 = 0;
    public static int weaponAttack7 = 1;
    public static int weaponneedAttack7 = 1;
    public static int weaponAttackcount7 = 0;
    public static int weaponAttack8 = 1;
    public static int weaponneedAttack8 = 1;
    public static int weaponAttackcount8 = 0;
    public static int weaponAttack9 = 1;
    public static int weaponneedAttack9 = 1;
    public static int weaponAttackcount9 = 0;
    public static int weaponAttack10 = 1;
    public static int weaponneedAttack10 = 1;
    public static int weaponAttackcount10 = 0;

    public static int weaponGuard1 = 1;
    public static int weaponneedGuard1 = 1;
    public static int weaponGuardcount1 = 0;
    public static int weaponGuard2 = 1;
    public static int weaponneedGuard2 = 1;
    public static int weaponGuardcount2 = 0;
    public static int weaponGuard3 = 1;
    public static int weaponneedGuard3 = 1;
    public static int weaponGuardcount3 = 0;
    public static int weaponGuard4 = 1;
    public static int weaponneedGuard4 = 1;
    public static int weaponGuardcount4 = 0;
    public static int weaponGuard5 = 1;
    public static int weaponneedGuard5 = 1;
    public static int weaponGuardcount5 = 0;
    public static int weaponGuard6 = 1;
    public static int weaponneedGuard6 = 1;
    public static int weaponGuardcount6 = 0;
    public static int weaponGuard7 = 1;
    public static int weaponneedGuard7 = 1;
    public static int weaponGuardcount7 = 0;
    public static int weaponGuard8 = 1;
    public static int weaponneedGuard8 = 1;
    public static int weaponGuardcount8 = 0;
    public static int weaponGuard9 = 1;
    public static int weaponneedGuard9 = 1;
    public static int weaponGuardcount9 = 0;
    public static int weaponGuard10 = 1;
    public static int weaponneedGuard10 = 1;
    public static int weaponGuardcount10 = 0;

    public static int weaponLuck1 = 1;
    public static int weaponneedLuck1 = 1;
    public static int weaponLuckcount1 = 0;
    public static int weaponLuck2 = 1;
    public static int weaponneedLuck2 = 1;
    public static int weaponLuckcount2 = 0;
    public static int weaponLuck3 = 1;
    public static int weaponneedLuck3 = 1;
    public static int weaponLuckcount3 = 0;
    public static int weaponLuck4 = 1;
    public static int weaponneedLuck4 = 1;
    public static int weaponLuckcount4 = 0;
    public static int weaponLuck5 = 1;
    public static int weaponneedLuck5 = 1;
    public static int weaponLuckcount5 = 0;
    public static int weaponLuck6 = 1;
    public static int weaponneedLuck6 = 1;
    public static int weaponLuckcount6 = 0;
    public static int weaponLuck7 = 1;
    public static int weaponneedLuck7 = 1;
    public static int weaponLuckcount7 = 0;
    public static int weaponLuck8 = 1;
    public static int weaponneedLuck8 = 1;
    public static int weaponLuckcount8 = 0;
    public static int weaponLuck9 = 1;
    public static int weaponneedLuck9 = 1;
    public static int weaponLuckcount9 = 0;
    public static int weaponLuck10 = 1;
    public static int weaponneedLuck10 = 1;
    public static int weaponLuckcount10 = 0;

    public static int weaponLevel1 = 1;
    public static int weaponLevel2 = 1;
    public static int weaponLevel3 = 1;
    public static int weaponLevel4 = 1;
    public static int weaponLevel5 = 1;
    public static int weaponLevel6 = 1;
    public static int weaponLevel7 = 1;
    public static int weaponLevel8 = 1;
    public static int weaponLevel9 = 1;
    public static int weaponLevel10 = 1;

    public static int playerexp = 0;       //経験値
    public static int playerlevel = 1;            //プレイヤーのレベル
    public static int needEXP = 1;　　　　　　　//レベルアップに必要な経験値
    public static int needEXPcount = 0;            //何回かに一回レベルをあげるために必要な経験値を増やす
    public static int playerhp = 100;　　　　　　　　　　//プレイヤーの体力
    public static int playerhpnow = 110;                //プレイヤーの現在の体力
    public static int playerstamina = 100;　　　　　　　　　 //プレイヤーのスタミナ
    public static int playeroffence = 1;                   //プレイヤーの攻撃
    public static int playerdeffence = 1;                   //プレイヤーの防御
    public static int playerluck = 1;                   //プレイヤーの運
    public static int playerstatuspoint = 0;                   //プレイヤーのステータスポイント
    public static int playerneedsp = 1;               //ステータス強化に必要なステータスポイント
    public static int needspcount = 0;                //何回かにつき一回needsp増やすためのやつ
    public static int soubi = 1;                   //装備してる武器１から10で
    public static bool first = true;                   //一番最初に武器とか色々するためのやつ

    public static bool sky = true;                    //天空神殿にいること
    public static bool save = false;                  //セーブポイントにいること
    public static float sound = 50;          //音量
    public static float healpotion = 0;        //ヒールポーション
}
