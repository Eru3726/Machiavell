using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kyoukasannsyou : MonoBehaviour
{
    public DropWeapon wd;
    public GameObject UI;
    public GameObject sannsyouUI;
    public GameObject hyouji;
    public GameObject sannsyou;
    public bool firstnotsannsyou = false;
    private Vector3 pos1 = new Vector3(-7.4f, 3.5f, 0);
    private Vector3 pos2;
    private Vector3 pos3;
    private Vector3 pos4;
    private Vector3 pos5;
    private Vector3 pos6;
    private Vector3 pos7;
    private Vector3 pos8;
    private Vector3 pos9;
    private Vector3 pos10;
    void Start()
    {
        pos2 = pos1 + new Vector3(2.4f, 0, 0);
        pos3 = pos2 + new Vector3(2.4f, 0, 0);
        pos4 = pos3 + new Vector3(2.4f, 0, 0);
        pos5 = pos4 + new Vector3(2.4f, 0, 0);
        pos6 = pos5 + new Vector3(-9.6f, -2.4f, 0);
        pos7 = pos6 + new Vector3(2.4f, 0, 0);
        pos8 = pos7 + new Vector3(2.4f, 0, 0);
        pos9 = pos8 + new Vector3(2.4f, 0, 0);
        pos10 = pos9 + new Vector3(2.4f, 0, 0);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);　　　　　　　　　//マウスのポジションにあるやつを検索
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);　　　//hit2dに検索であたったやつをぶちこむ
            if (hit2d)
            {
                if (firstnotsannsyou == true)   //わかりやすいように色変える
                {
                    Debug.Log("?");
                }
                if (hit2d.transform.position != new Vector3(-6.4f, -2.55f, 0))
                {
                    sannsyou = hit2d.transform.gameObject;    //クリックしたオブジェクトをぶちこむこれいろんなとこで使う
                    if (wd.pos1 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos1, Quaternion.identity);
                    }
                    else if (wd.pos2 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos2, Quaternion.identity);
                    }
                    else if (wd.pos3 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos3, Quaternion.identity);
                    }
                    else if (wd.pos4 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos4, Quaternion.identity);
                    }
                    else if (wd.pos5 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos5, Quaternion.identity);
                    }
                    else if (wd.pos6 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos6, Quaternion.identity);
                    }
                    else if (wd.pos7 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos7, Quaternion.identity);
                    }
                    else if (wd.pos8 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos8, Quaternion.identity);
                    }
                    else if (wd.pos9 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos9, Quaternion.identity);
                    }
                    else if (wd.pos10 == sannsyou)
                    {
                        Destroy(UI);
                        UI = Instantiate(sannsyouUI, pos10, Quaternion.identity);
                    }
                    hyouji.GetComponent<Kyoukahyouji>().hyouji();
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
