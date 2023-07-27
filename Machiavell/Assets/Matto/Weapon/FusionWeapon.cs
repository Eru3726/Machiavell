using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusionWeapon : MonoBehaviour
{
    /*
    public GameObject sannsyou;
    public GameObject fusionmoto;
    public GameObject sozai;
    private bool motosentaku;
    // Start is called before the first frame update
    void Start()
    {
        motosentaku = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClick()
    {
        
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
    