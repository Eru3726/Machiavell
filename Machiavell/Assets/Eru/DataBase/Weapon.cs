using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Weapon", menuName = "DataBase/CreateWeapon")]
public class Weapon : ScriptableObject
{
    public Type weaponType;             //種類
    public int weaponRarity;            //レア度
    public String weaponName;           //名前
    public Sprite weaponSprite;         //画像
    public int weaponHp;                //体力
    public int weaponStamina;           //スタミナ
    public int weaponAttack;            //攻撃力
    public int weaponGuard;             //防御力
    public int weaponLuck;              //運
    public int weaponLevel;             //レベル

    public enum Type
    {
        LargeSword,
        LargeAxe,
        Hammer,
        Sword,
        Axe,
        Spear,
        Rapier,
        Bow,
        CrossBow,
    }

    public Weapon(Weapon weapon)
    {
        this.weaponType = weapon.weaponType;
        this.weaponRarity = weapon.weaponRarity;
        this.weaponName = weapon.weaponName;
        this.weaponSprite = weapon.weaponSprite;
        this.weaponHp = weapon.weaponHp;
        this.weaponStamina = weapon.weaponStamina;
        this.weaponAttack = weapon.weaponAttack;
        this.weaponGuard = weapon.weaponGuard;
        this.weaponLuck = weapon.weaponLuck;
        this.weaponLevel = weapon.weaponLevel;
    }
}