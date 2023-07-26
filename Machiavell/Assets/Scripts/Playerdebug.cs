using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdebug : MonoBehaviour
{
    public PlayerLevel pl;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            pl.Xp(5);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            pl.Xp(50);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pl.Xp(500);
        }
    }
}
