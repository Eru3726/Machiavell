using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "exp", menuName = "DataBase/Createexp")]
public class Exp : ScriptableObject
{
    public Type expType;               //種類
    public String expName;             //名前
    public Sprite expSprite;           //画像
    public int getexp;          //経験値

    public enum Type
    {
        floor1exp,
        floor2exp,
        floor3exp,
        floor4exp,
    }

    public Exp(Exp exp)
    {
        this.expType = exp.expType;
        this.expName = exp.expName;
        this.expSprite = exp.expSprite;
        this.getexp = exp.getexp;
    }
}