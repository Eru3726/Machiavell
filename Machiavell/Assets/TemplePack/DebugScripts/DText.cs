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
        hierarchy.text = "��" + DHierarchy.hierarchy + "�w".ToString();

        if (dwd.type == 1)
        {
            type.text = "�匕".ToString();
        }
        if (dwd.type == 2)
        {
            type.text = "�啀".ToString();
        }
        if (dwd.type == 3)
        {
            type.text = "�n���}�[".ToString();
        }
        if (dwd.type == 4)
        {
            type.text = "��".ToString();
        }
        if (dwd.type == 5)
        {
            type.text = "�蕀".ToString();
        }
        if (dwd.type == 6)
        {
            type.text = "��".ToString();
        }
        if (dwd.type == 7)
        {
            type.text = "���C�s�A".ToString();
        }
        if (dwd.type == 8)
        {
            type.text = "�|".ToString();
        }
        if (dwd.type == 9)
        {
            type.text = "�N���X�{�E".ToString();
        }
    }
}
