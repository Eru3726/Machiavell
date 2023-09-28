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

    public int[] inventoryWeapon = new int[10];

    public int[] weaponRarity = new int[10];

    public int[] weaponHp = new int[10];
    public int[] weaponneedHp = new int[10];
    public int[] weaponhpcount = new int[10];

    public int[] weaponStamina = new int[10];
    public int[] weaponneedStamina = new int[10];
    public int[] weaponStaminacount = new int[10];

    public int[] weaponAttack = new int[10];
    public int[] weaponneedAttack = new int[10];
    public int[] weaponAttackcount = new int[10];

    public int[] weaponGuard = new int[10];
    public int[] weaponneedGuard = new int[10];
    public int[] weaponGuardcount = new int[10];

    public int[] weaponLuck = new int[10];
    public int[] weaponneedLuck = new int[10];
    public int[] weaponLuckcount = new int[10];

    public int[] weaponLevel = new int[10];

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