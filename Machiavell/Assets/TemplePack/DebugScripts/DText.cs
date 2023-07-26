using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DText : MonoBehaviour
{
    public Text hierarchy;
    public Text type;

    public WeaponDrop wd;

    public DWeapon dwd;

    void Update()
    {
        hierarchy.text = "第" + DHierarchy.hierarchy + "層".ToString();

        if (dwd.type == 1)
        {
            type.text = "大剣".ToString();
        }
        if (dwd.type == 2)
        {
            type.text = "大斧".ToString();
        }
        if (dwd.type == 3)
        {
            type.text = "ハンマー".ToString();
        }
        if (dwd.type == 4)
        {
            type.text = "剣".ToString();
        }
        if (dwd.type == 5)
        {
            type.text = "手斧".ToString();
        }
        if (dwd.type == 6)
        {
            type.text = "槍".ToString();
        }
        if (dwd.type == 7)
        {
            type.text = "レイピア".ToString();
        }
        if (dwd.type == 8)
        {
            type.text = "弓".ToString();
        }
        if (dwd.type == 9)
        {
            type.text = "クロスボウ".ToString();
        }
    }
}
