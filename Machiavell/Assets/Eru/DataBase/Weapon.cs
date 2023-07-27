using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Weapon", menuName = "DataBase/CreateWeapon")]
public class Weapon : ScriptableObject
{
    public Type weaponType;             //���
    public int weaponRarity;            //���A�x
    public String weaponName;           //���O
    public Sprite weaponSprite;         //�摜
    public int weaponHp;                //�̗�
    public int weaponStamina;           //�X�^�~�i
    public int weaponAttack;            //�U����
    public int weaponGuard;             //�h���
    public int weaponLuck;              //�^
    public int weaponLevel;             //���x��

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