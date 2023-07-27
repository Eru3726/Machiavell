using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public static int playerLevel = 1;     //�v���C���[���x��
    public static int nextLevel = 3;       //���̃��x���ɏオ�邽�߂ɕK�v�Ȍo���l
    public static int getXp = 0;           //���肵�Ă���o���l

    public PlayerSp pp;

    private void Update()
    {
        //���x���A�b�v
        if (getXp >= nextLevel)
        {
            playerLevel++;
            Debug.Log("�v���C���[�̃��x����" + playerLevel + "�ɂȂ�܂���");
            getXp -= nextLevel;
            nextLevel = playerLevel * playerLevel + playerLevel;                        // Y = X^2 + X
            Debug.Log("���̃��x���A�b�v�܂ł���" + (nextLevel - getXp) + "Xp�ł�");
            GetSp();
        }
    }

    //Xp�̒ǉ�
    public void Xp(int xp)
    {
        getXp += xp;
        Debug.Log(xp + "Xp���肵�܂���");
    }

    //Sp���蔻��
    public void GetSp()
    {
        if(playerLevel % 5 == 0)
        {
            pp.AddSp(5 * (playerLevel / 5));
        }
    }
}
