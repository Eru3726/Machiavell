using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float floor;
    public Enemy slime;
    public Enemy zombie;
    public Enemy bad;
    void Start()
    {
        floor = 1;
    }

    void Update() 
    {
        
    }
    public void OnClick()
    {
        if (floor <= 3)
        {
            floor += 1;
        }
        else
        {
            floor = 1;
        }
        Debug.Log(floor);
    }
}
