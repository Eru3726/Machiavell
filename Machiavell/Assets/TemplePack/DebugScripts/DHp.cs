using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHp : MonoBehaviour
{
    public PlayerHP hp;

    public void heal()
    {
        hp.PlayerHeal(10);
    }

    public void damage()
    {
        hp.PlayerDamage(10);
    }
}
