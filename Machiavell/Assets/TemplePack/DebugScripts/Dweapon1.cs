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
        Debug.Log("����̃��x��" + dwlevel);
        Debug.Log("����̗̑�" + dwhp);
        Debug.Log("����̃X�^�~�i" + dwstamina);
        Debug.Log("����̍U����" + dwattack);
        Debug.Log("����̖h���" + dwguard);
        Debug.Log("����̍K�^" + dwluck);
        Debug.Log("�����ɕK�v�ȃX�e" + dneedsp);
    }
}
