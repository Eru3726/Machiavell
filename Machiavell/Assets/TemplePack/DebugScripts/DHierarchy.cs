using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHierarchy : MonoBehaviour
{
    public static int hierarchy = 1;

    public void Hierarchy()
    {
        if(hierarchy == 4)
        {
            hierarchy = 1;
        }
        else
        {
            hierarchy++;
        }
    }
}
