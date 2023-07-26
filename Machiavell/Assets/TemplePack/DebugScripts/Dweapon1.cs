using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dweapon1 : MonoBehaviour
{
    GameObject sansyou;
    public static bool sannsyousuru;
    float dwhp;
    float dwstamina;
    float dwattack;
    float dwguard;
    float dwluck;
    float dwlevel;
    float dneedsp;
    void Start()
    {
        sannsyousuru = false;
    }
    void Update()
    {
        if (sannsyousuru == true)
        {
            //sansyou = WeaponStatus.sannsyou;
            dwhp = sansyou.GetComponent<WeaponStatus>().dwhp();
            dwstamina = sansyou.GetComponent<WeaponStatus>().dwstamina();
            dwattack = sansyou.GetComponent<WeaponStatus>().dwattack();
            dwguard = sansyou.GetComponent<WeaponStatus>().dwguard();
            dwluck = sansyou.GetComponent<WeaponStatus>().dwluck();
            dwlevel = sansyou.GetComponent<WeaponStatus>().dwlevel();
            dneedsp = sansyou.GetComponent<WeaponStatus>().need();
        }
    }
    public void debug()
    {
        Debug.Log("武器のレベル" + dwlevel);
        Debug.Log("武器の体力" + dwhp);
        Debug.Log("武器のスタミナ" + dwstamina);
        Debug.Log("武器の攻撃力" + dwattack);
        Debug.Log("武器の防御力" + dwguard);
        Debug.Log("武器の幸運" + dwluck);
        Debug.Log("強化に必要なステ" + dneedsp);
    }
}
