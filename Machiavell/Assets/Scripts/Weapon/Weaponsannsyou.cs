using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponsannsyou : MonoBehaviour
{
    public bool hyouji = false;
    public GameObject sannsyou;
    public bool firstnotsannsyou = false;
    public GameObject fusionset;
    private Vector3 hyoujiposi;
    void Start()
    {
        hyoujiposi = new Vector3(6.18f, 2.3f, 0);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);�@�@�@�@�@�@�@�@�@//�}�E�X�̃|�W�V�����ɂ���������
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);�@�@�@//hit2d�Ɍ����ł�����������Ԃ�����
            if (hit2d)
            {
                if (firstnotsannsyou == true)   //�킩��₷���悤�ɐF�ς���
                {
                    sannsyou.GetComponent<Renderer>().material.color = Color.white;
                }
                if (!(hit2d.transform.position == hyoujiposi))
                {
                    sannsyou = hit2d.transform.gameObject;    //�N���b�N�����I�u�W�F�N�g���Ԃ����ނ��ꂢ���ȂƂ��Ŏg��
                    sannsyou.GetComponent<Renderer>().material.color = Color.red;    //�Q�Ƃ����I�u�W�F�N�g�̐F�ς���
                    hyouji = true;
                }
                if (firstnotsannsyou == false)
                {
                    firstnotsannsyou = true;
                }
                Debug.Log(sannsyou);
            }
        }
    }
}
