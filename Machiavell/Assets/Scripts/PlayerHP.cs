using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    //�v���C���[�_���[�W
    public void PlayerDamage(int damage)
    {
        Debug.Log("�v���C���[��" + damage + "�_���[�W���󂯂܂���");
        PlayerS.hp -= damage;
    }

    //�v���C���[�q�[��
    public void PlayerHeal(int heal)
    {
        if (PlayerS.maxhp - PlayerS.hp >= heal)
        Debug.Log("�v���C���[��" + heal + "�񕜂��܂���");
        PlayerS.hp += heal;
    }
}
