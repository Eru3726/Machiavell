using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstatus : MonoBehaviour
{
    //public float EXP;
    //public float LEVEL;
    //public float needEXP = 1;�@�@�@�@�@�@�@//���x���������邽�߂ɕK�v�Ȍo���l
    //public float PH = 1;�@�@�@�@�@�@�@�@�@�@//�v���C���[�̗̑�
    //public float PS = 1;�@�@�@�@�@�@�@�@�@ //�v���C���[�̃X�^�~�i
    //public float PO = 1;                   //�v���C���[�̍U��
    //public float PD = 1;                   //�v���C���[�̖h��
    //public float PL = 1;                   //�v���C���[�̉^
    //public float SP = 0;                   //�v���C���[�̃X�e�[�^�X�|�C���g
    //public float needsp = 1;               //�X�e�[�^�X�����ɕK�v�ȃX�e�[�^�X�|�C���g
    //public float count = 0;                //���񂩂ɂ����needsp���₷���߂̂��
    void Start()
    {

    }

    void Update()
    {
        //if (GameData.needspcount >= 5)�@�@�@�@�@�@//needsp�㏸
        //{
        //    GameData.playerneedsp += 2;
        //    GameData.needspcount = 0;
        //}
        if (GameData.playerexp >= GameData.needEXP)�@�@�@�@//���x���A�b�v
        {
            GameData.playerlevel += 1;
            GameData.playerstatuspoint += 1;
            GameData.playerexp = 0;
        }
        if (GameData.needEXPcount >= 5)
        {
            GameData.needEXP += 2;
            GameData.needEXPcount = 0;
        }
    }
    public void PHup()
    {
        if (GameData.playerstatuspoint >= GameData.playerneedsp)
        {
            GameData.playerhp += 10;
            GameData.playerstatuspoint -= GameData.playerneedsp;
            GameData.needspcount += 1;
        }
    }
    public void PSup()
    {
        if (GameData.playerstatuspoint >= GameData.playerneedsp)
        {
            GameData.playerstamina += 10;
            GameData.playerstatuspoint -= GameData.playerneedsp;
            GameData.needspcount += 1;
        }
    }
    public void POup()
    {
        if (GameData.playerstatuspoint >= GameData.playerneedsp)
        {
            GameData.playeroffence += 1;
            GameData.playerstatuspoint -= GameData.playerneedsp;
            GameData.needspcount += 1;
        }
    }
    public void PDup()
    {
        if (GameData.playerstatuspoint >= GameData.playerneedsp)
        {
            GameData.playerdeffence += 1;
            GameData.playerstatuspoint -= GameData.playerneedsp;
            GameData.needspcount += 1;
        }
    }
    public void PLup()
    {
        if (GameData.playerstatuspoint >= GameData.playerneedsp)
        {
            GameData.playerluck += 1;
            GameData.playerstatuspoint -= GameData.playerneedsp;
            GameData.needspcount += 1;
        }
    }
    public void SPup()
    {
        GameData.playerexp += 1;
        GameData.needEXPcount += 1;
    }
    public void debug()
    {
        Debug.Log("LEVEL " + GameData.playerlevel);
        Debug.Log("EXP" + GameData.playerexp);
        Debug.Log("needEXP " + GameData.needEXP);
        Debug.Log("needEXPcount" + GameData.needEXPcount);
        Debug.Log("HP " + GameData.playerhp);
        Debug.Log("Stamina " + GameData.playerstamina);
        Debug.Log("Offence " + GameData.playeroffence);
        Debug.Log("Dffence " + GameData.playerdeffence);
        Debug.Log("Luck " + GameData.playerluck);
        Debug.Log("SP " + GameData.playerstatuspoint);
        Debug.Log("needsp " + GameData.playerneedsp);
        Debug.Log("needspcount" + GameData.needspcount);
    }
    public void statusclear()
    {
        GameData.playerlevel = 1;
        GameData.playerexp = 0;
        GameData.needEXP = 1;
        GameData.playerhp = 100;
        GameData.playerstamina = 100;
        GameData.playeroffence = 1;
        GameData.playerdeffence = 1;
        GameData.playerluck = 1;
        GameData.playerstatuspoint = 0;
        GameData.playerneedsp = 1;
        GameData.needspcount = 0;
    }
}
