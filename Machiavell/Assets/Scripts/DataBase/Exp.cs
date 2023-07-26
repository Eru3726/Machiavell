using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "exp", menuName = "DataBase/Createexp")]
public class Exp : ScriptableObject
{
    public Type expType;               //Ží—Þ
    public String expName;             //–¼‘O
    public Sprite expSprite;           //‰æ‘œ
    public int getexp;          //ŒoŒ±’l

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