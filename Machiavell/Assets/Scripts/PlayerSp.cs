using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSp : MonoBehaviour
{
    //�X�e�[�^�X�|�C���g
    public static int sp = 0;

    //�X�L���|�C���g�ǉ�
    public void AddSp(int add)
    {
        sp += add;
        Debug.Log("Sp���F" + add + "���肵�܂���");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.maxhp += 10;
                Debug.Log("hp�㏸" + PlayerS.maxhp);
                Debug.Log("�c��SP" + sp);
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.maxstamina += 10;
                Debug.Log("�X�^�~�i�㏸" + PlayerS.maxstamina);
                Debug.Log("�c��SP" + sp);
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.offensePower += 1;
                Debug.Log("�U���͏㏸" + PlayerS.offensePower);
                Debug.Log("�c��SP" + sp);
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.defensePower += 1;
                Debug.Log("�h��͏㏸" + PlayerS.defensePower);
                Debug.Log("�c��SP" + sp);
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.lucky += 1;
                Debug.Log("�K�^�㏸" + PlayerS.lucky);
                Debug.Log("�c��SP" + sp);
            }
        }

    }

    public void debug()
    {
        Debug.Log("�c��sp" + sp);
    }
}
