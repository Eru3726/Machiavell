using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusionmoto : MonoBehaviour
{
    public GameObject moto;
    public GameObject sannsyou;     //クリックで参照したオブジェクト
    GameObject deth;

    void Start()
    {
        
    }

    void Update()
    {
    }

    public void OnClick()
    {
        moto = sannsyou.GetComponent<Weaponsannsyou>().sannsyou;　　　　　　　//クリックで参照したオブジェクトぶちこむ
        deth = Instantiate(moto, new Vector3(-5, 0, 0), Quaternion.identity);　　　//生成して消せるようにぶち込んどく
    }

    public void Dethobj()
    {
        Destroy(deth);
    }
}
