using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusionmoto : MonoBehaviour
{
    public GameObject moto;
    public GameObject sannsyou;     //�N���b�N�ŎQ�Ƃ����I�u�W�F�N�g
    GameObject deth;

    void Start()
    {
        
    }

    void Update()
    {
    }

    public void OnClick()
    {
        moto = sannsyou.GetComponent<Weaponsannsyou>().sannsyou;�@�@�@�@�@�@�@//�N���b�N�ŎQ�Ƃ����I�u�W�F�N�g�Ԃ�����
        deth = Instantiate(moto, new Vector3(-5, 0, 0), Quaternion.identity);�@�@�@//�������ď�����悤�ɂԂ�����ǂ�
    }

    public void Dethobj()
    {
        Destroy(deth);
    }
}
