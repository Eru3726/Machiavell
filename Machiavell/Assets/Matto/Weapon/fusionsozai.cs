using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusionsozai : MonoBehaviour
{
    public GameObject sozai;
    public GameObject sannsyou;        //�N���b�N�ŎQ�Ƃ��Ă�I�u�W�F�N�g
    GameObject deth;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClick()
    {
        sozai = sannsyou.GetComponent<Weaponsannsyou>().sannsyou;
        deth = Instantiate(sozai, new Vector3(5, 0, 0), Quaternion.identity);      //���������Ƃ��ɑf�ނ��������߂̂��
    }
    public void Dethobj()
    {
        Destroy(deth);
    }
}
