using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponfusion : MonoBehaviour
{/*
    public static GameObject fusionmoto;     //������
    public static GameObject sozai;          //�f��
    public static bool fusion = false;       //�������ɓ������
    public static bool fusionsannsyou = false;         //�N���b�N�Q�Ƃ����Ԃ�Ȃ��悤�ɂ��邽�߂̂��
    void Start()
    {

    }

    void Update()
    {
        //�������Q��
        if (fusion == true)
        {
            fusionmoto = WeaponStatus.sannsyou;
        }
    }
    public void fusionsannsyousuru()
    {
        //�{�^���N���b�N�őf�ގQ�Ɨp��
        fusionsannsyou = true;
    }
    public void Click()
    {
        //�N���b�N�őf�ގQ��
        if (fusionsannsyou == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                sozai = hit2d.transform.gameObject;
                Debug.Log("�������̕���" + fusionmoto);
                Debug.Log("�������镐��" + sozai);
            }
            fusionsannsyou = false;
        }
    }
    public void fusionclick()
    {
        //�������Ƒf�ނ̎�ނ������Ȃ獇�����ĕ���̃��x���Ȃǂ̃��Z�b�g�ƃ��A�x�A�b�v
        if (fusionmoto.tag == "weapon1")
        {
            if (sozai.tag == fusionmoto.tag)
            {
                if (sozai.layer == fusionmoto.layer)
                {
                    Destroy(sozai);
                    fusionmoto.tag = "weapon2";
                    fusionmoto.GetComponent<WeaponStatus>().wstatusreset();
                    WeaponStatus.sannsyou = fusionmoto;
                }
            }
        }
        else if (fusionmoto.tag == "weapon2")
        {
            if (sozai.tag == fusionmoto.tag)
            {
                if (sozai.layer == fusionmoto.layer)
                {
                    Destroy(sozai);
                    fusionmoto.tag = "weapon3";
                    fusionmoto.GetComponent<WeaponStatus>().wstatusreset();
                    WeaponStatus.sannsyou = fusionmoto;
                }
            }
        }
        else if (fusionmoto.tag == "weapon3")
        {
            if (sozai.tag == fusionmoto.tag)
            {
                if (sozai.layer == fusionmoto.layer)
                {
                    Destroy(sozai);
                    fusionmoto.tag = "weapon4";
                    fusionmoto.GetComponent<WeaponStatus>().wstatusreset();
                    WeaponStatus.sannsyou = fusionmoto;
                }
            }
        }
        else if (fusionmoto.tag == "weapon4")
        {
            if (sozai.tag == fusionmoto.tag)
            {
                if (sozai.layer == fusionmoto.layer)
                {
                    Destroy(sozai);
                    fusionmoto.tag = "weapon5";
                    fusionmoto.GetComponent<WeaponStatus>().wstatusreset();
                    WeaponStatus.sannsyou = fusionmoto;
                }
            }
        }
        else
        {
            Debug.Log("�����ł��܂���");
        }
    }*/
}
