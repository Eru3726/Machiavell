using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slothyouji : MonoBehaviour
{
    public GameObject sannsyoustar;
    public GameObject sannsyoustar1;
    public GameObject sannsyoustar2;
    public GameObject sannsyoustar3;
    public GameObject sannsyoustar4;
    public GameObject sannsyoustar5;
    public GameObject sannsyouscripts;
    private GameObject sannsyou;
    public GameObject hyoujibuki;
    public GameObject parent;
    void Start()
    {

    }

    void Update()
    {

    }
    public void hyouji()
    {
        if (hyoujibuki)
        {
            Destroy(hyoujibuki);
            Destroy(sannsyoustar);
        }
        sannsyou = sannsyouscripts.GetComponent<Slotsannsyou>().sannsyou;
        if (sannsyou != null)
        {
            if (sannsyou.tag == "weapon1")
            {
                sannsyoustar = Instantiate(sannsyoustar1);
                sannsyoustar.transform.parent = parent.transform;
                sannsyoustar.transform.localPosition = new Vector3(-14f, 6.65f, 10);
            }
            else if (sannsyou.tag == "weapon2")
            {
                sannsyoustar = Instantiate(sannsyoustar2);
                sannsyoustar.transform.parent = parent.transform;
                sannsyoustar.transform.localPosition = new Vector3(-13.3f, 6.65f, 10);
            }
            else if (sannsyou.tag == "weapon3")
            {
                sannsyoustar = Instantiate(sannsyoustar3);
                sannsyoustar.transform.parent = parent.transform;
                sannsyoustar.transform.localPosition = new Vector3(-12.6f, 6.65f, 10);
            }
            else if (sannsyou.tag == "weapon4")
            {
                sannsyoustar = Instantiate(sannsyoustar4);
                sannsyoustar.transform.parent = parent.transform;
                sannsyoustar.transform.localPosition = new Vector3(-11.9f, 6.65f, 10);
            }
            else if (sannsyou.tag == "weapon5")
            {
                sannsyoustar = Instantiate(sannsyoustar5);
                sannsyoustar.transform.parent = parent.transform;
                sannsyoustar.transform.localPosition = new Vector3(-11.2f, 6.65f, 10);
            }

            hyoujibuki = Instantiate(sannsyou);
            hyoujibuki.transform.parent = parent.transform;
            hyoujibuki.transform.localPosition = new Vector3(-8f, 1f, 10f);
            hyoujibuki.transform.localScale = new Vector3(10f, 10f, 0);
        }
    }
}
