using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "exp", menuName = "DataBase/Createexp")]
public class Exp : ScriptableObject
{
    public Type expType;               //���
    public String expName;             //���O
    public Sprite expSprite;           //�摜
    public int getexp;          //�o���l

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