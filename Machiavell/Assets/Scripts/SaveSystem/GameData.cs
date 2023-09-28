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

    public static int[] inventoryWeapon = new int[10];

    public static int[] weaponRarity = new int[10];

    public static int[] weaponHp = new int[10];
    public static int[] weaponneedHp = new int[10];
    public static int[] weaponhpcount = new int[10];

    public static int[] weaponStamina = new int[10];
    public static int[] weaponneedStamina = new int[10];
    public static int[] weaponStaminacount = new int[10];

    public static int[] weaponAttack = new int[10];
    public static int[] weaponneedAttack = new int[10];
    public static int[] weaponAttackcount = new int[10];

    public static int[] weaponGuard = new int[10];
    public static int[] weaponneedGuard = new int[10];
    public static int[] weaponGuardcount = new int[10];

    public static int[] weaponLuck = new int[10];
    public static int[] weaponneedLuck = new int[10];
    public static int[] weaponLuckcount = new int[10];

    public static int[] weaponLevel = new int[10];

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
