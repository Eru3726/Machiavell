using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Enemy", menuName = "DataBase/CreateEnemy")]
public class Enemy : ScriptableObject
{
    public Type enemyType;              //���
    public String enemyName;            //���O
    public Sprite enemySprite;          //�摜
    public int enemyMaxHp;              //�̗�
    public int enemyOffensivePower;     //�U����
    public int enemyDefensePower;       //�h���
    public float enemyMoveSpeed;        //���x
    public float enemyWaitTime;         //�҂�����
    public float enemyWalkTime;         //��������
    public float enemyChaseSpeed;       //�ǂ������鑬�x
    public float enemyRangeToChase;     //�C�Â��͈�
    public float enemyWaitAfterHitting; //�U���Ԋu
    public float enemyKnockBackPower;   //�m�b�N�o�b�N
    public float enemyAria;             //�ړ��\����
    public int enemyExp;                //�o���l
    public int enemyBeamAtk;                 //�r�[���̍U����
    public int enemyGodLodAtk;               //�_�̏�̍U����
    public int enemyWaveAtk;               //�_�̏�̍U����

    public enum Type
    {
        Angelus,
        BlueCrystal,
        RedCrystal,
        Talis,
        WeekSummon,
    }

    public Enemy(Enemy enemy)
    {
        this.enemyType = enemy.enemyType;
        this.enemyName = enemy.enemyName;
        this.enemySprite = enemy.enemySprite;
        this.enemyMaxHp = enemy.enemyMaxHp;
        this.enemyOffensivePower = enemy.enemyOffensivePower;
        this.enemyDefensePower = enemy.enemyDefensePower;
        this.enemyMoveSpeed = enemy.enemyMoveSpeed;
        this.enemyWaitTime = enemy.enemyWaitTime;
        this.enemyWalkTime = enemy.enemyWalkTime;
        this.enemyChaseSpeed = enemy.enemyChaseSpeed;
        this.enemyRangeToChase = enemy.enemyRangeToChase;
        this.enemyWaitAfterHitting = enemy.enemyWaitAfterHitting;
        this.enemyKnockBackPower = enemy.enemyKnockBackPower;
        this.enemyExp = enemy.enemyExp;
        this.enemyBeamAtk = enemy.enemyBeamAtk;
        this.enemyGodLodAtk = enemy.enemyGodLodAtk;
        this.enemyWaveAtk = enemy.enemyWaveAtk;
    }
}