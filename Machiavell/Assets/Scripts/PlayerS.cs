using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerS : MonoBehaviour
{
    
    public GameObject sannsyoumoto;
    GameObject sannsyou;
    //プレイヤーステータス
    public static int hp = 100;            //HP
    public static int offensePower = 1;    //攻撃力
    public static int defensePower = 1;    //守備力
    public static int stamina = 100;         //スタミナ
    public static int lucky = 1;           //運
    public static int maxhp = 100;           //HPの最大値
    public static int maxstamina = 100;      //スタミナの最大値
    float needsp;
    public static bool sannsyousp;
    void Start()
    {
        sannsyousp = false;
        sannsyou = sannsyoumoto.GetComponent<WeaponStatus>().sannsyou;
    }
    void Update()
    {
        //レベルアップごとに必要になるステータスに値を増やす
        if (sannsyousp == true)
        {
            needsp = sannsyou.GetComponent<WeaponStatus>().need();
        }
        //ステータスが0にならないようにする
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (maxhp >= 10+needsp * 10)
            {
                sannsyou.GetComponent<WeaponStatus>().whpup();
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (maxstamina >= 10+needsp * 10)
            {
                GetComponent<WeaponStatus>().wstaminaup();
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (offensePower >= 1+needsp)
            {
                GetComponent<WeaponStatus>().wattackup();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (defensePower >= 1+needsp)
            {
                GetComponent<WeaponStatus>().wguardup();
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (lucky >= 1+needsp)
            {
                GetComponent<WeaponStatus>().wluckup();
            }
        }
    }

    public void debug()
    {
        Debug.Log("プレイヤー体力" + maxhp);
        Debug.Log("プレイヤースタミナ" + maxstamina);
        Debug.Log("プレイヤー攻撃力" + offensePower);
        Debug.Log("プレイヤー防御力" + defensePower);
        Debug.Log("プレイヤー幸運" + lucky);
        Debug.Log("プレイヤーレベル" + PlayerLevel.playerLevel);
    }
}
