using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Enemy", menuName = "DataBase/CreateEnemy")]
public class Enemy : ScriptableObject
{
    public Type enemyType;              //種類
    public String enemyName;            //名前
    public Sprite enemySprite;          //画像
    public int enemyMaxHp;              //体力
    public int enemyOffensivePower;     //攻撃力
    public int enemyDefensePower;       //防御力
    public float enemyMoveSpeed;        //速度
    public float enemyWaitTime;         //待ち時間
    public float enemyWalkTime;         //動く時間
    public float enemyChaseSpeed;       //追いかける速度
    public float enemyRangeToChase;     //気づく範囲
    public float enemyWaitAfterHitting; //攻撃間隔
    public float enemyKnockBackPower;   //ノックバック
    public float enemyAria;             //移動可能距離
    public int enemyExp;                //経験値
    public int enemyBeamAtk;                 //ビームの攻撃力
    public int enemyGodLodAtk;               //神の杖の攻撃力
    public int enemyWaveAtk;               //神の杖の攻撃力

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