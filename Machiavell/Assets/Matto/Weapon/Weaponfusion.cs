using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponfusion : MonoBehaviour
{/*
    public static GameObject fusionmoto;     //合成元
    public static GameObject sozai;          //素材
    public static bool fusion = false;       //合成元に入れるやつ
    public static bool fusionsannsyou = false;         //クリック参照がかぶらないようにするためのやつ
    void Start()
    {

    }

    void Update()
    {
        //合成元参照
        if (fusion == true)
        {
            fusionmoto = WeaponStatus.sannsyou;
        }
    }
    public void fusionsannsyousuru()
    {
        //ボタンクリックで素材参照用意
        fusionsannsyou = true;
    }
    public void Click()
    {
        //クリックで素材参照
        if (fusionsannsyou == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                sozai = hit2d.transform.gameObject;
                Debug.Log("合成元の武器" + fusionmoto);
                Debug.Log("合成する武器" + sozai);
            }
            fusionsannsyou = false;
        }
    }
    public void fusionclick()
    {
        //合成元と素材の種類が同じなら合成して武器のレベルなどのリセットとレア度アップ
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
            Debug.Log("合成できません");
        }
    }*/
}
