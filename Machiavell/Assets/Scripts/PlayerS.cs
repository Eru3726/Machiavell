using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerS : MonoBehaviour
{
    
    public GameObject sannsyoumoto;
    GameObject sannsyou;
    //�v���C���[�X�e�[�^�X
    public static int hp = 100;            //HP
    public static int offensePower = 1;    //�U����
    public static int defensePower = 1;    //�����
    public static int stamina = 100;         //�X�^�~�i
    public static int lucky = 1;           //�^
    public static int maxhp = 100;           //HP�̍ő�l
    public static int maxstamina = 100;      //�X�^�~�i�̍ő�l
    float needsp;
    public static bool sannsyousp;
    void Start()
    {
        sannsyousp = false;
        sannsyou = sannsyoumoto.GetComponent<WeaponStatus>().sannsyou;
    }
    void Update()
    {
        //���x���A�b�v���ƂɕK�v�ɂȂ�X�e�[�^�X�ɒl�𑝂₷
        if (sannsyousp == true)
        {
            needsp = sannsyou.GetComponent<WeaponStatus>().need();
        }
        //�X�e�[�^�X��0�ɂȂ�Ȃ��悤�ɂ���
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
        Debug.Log("�v���C���[�̗�" + maxhp);
        Debug.Log("�v���C���[�X�^�~�i" + maxstamina);
        Debug.Log("�v���C���[�U����" + offensePower);
        Debug.Log("�v���C���[�h���" + defensePower);
        Debug.Log("�v���C���[�K�^" + lucky);
        Debug.Log("�v���C���[���x��" + PlayerLevel.playerLevel);
    }
}
