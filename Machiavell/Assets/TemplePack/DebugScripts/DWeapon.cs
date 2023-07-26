using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DWeapon : MonoBehaviour
{
    public WeaponDrop wd;

    public int type = 1;

    public void Type1()
    {
        type = 1;
    }
    public void Type2()
    {
        type = 2;
    }
    public void Type3()
    {
        type = 3;
    }
    public void Type4()
    {
        type = 4;
    }
    public void Type5()
    {
        type = 5;
    }
    public void Type6()
    {
        type = 6;
    }
    public void Type7()
    {
        type = 7;
    }
    public void Type8()
    {
        type = 8;
    }
    public void Type9()
    {
        type = 9;
    }
    public void WDStart()
    {
        wd.ProbabilityCalculation(type);
    }

    public void WeaponType()
    {
        if(type == 9)
        {
            type = 1;
        }
        else
        {
            type++;
        }
    }
}
