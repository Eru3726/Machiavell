using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DXp : MonoBehaviour
{
    public PlayerLevel pl;

    public void xp5()
    {
        pl.Xp(5);
    }
    public void xp50()
    {
        pl.Xp(50);
    }
    public void xp500()
    {
        pl.Xp(500);
    }
}
