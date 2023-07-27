using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusionsozai : MonoBehaviour
{
    public GameObject sozai;
    public GameObject sannsyou;        //クリックで参照してるオブジェクト
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
        deth = Instantiate(sozai, new Vector3(5, 0, 0), Quaternion.identity);      //合成したときに素材を消すためのやつ
    }
    public void Dethobj()
    {
        Destroy(deth);
    }
}
