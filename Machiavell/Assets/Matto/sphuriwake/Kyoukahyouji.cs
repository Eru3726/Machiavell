using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kyoukahyouji : MonoBehaviour
{
    public GameObject sannsyoustar;
    public GameObject sannsyoustar1;
    public GameObject sannsyoustar2;
    public GameObject sannsyoustar3;
    public GameObject sannsyoustar4;
    public GameObject sannsyoustar5;
    public GameObject sannsyouscripts;
    private GameObject sannsyou;
    private GameObject hyoujibuki;
    void Start()
    {
        
    }

    // Update is called once per frame
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
        sannsyou = sannsyouscripts.GetComponent<Kyoukasannsyou>().sannsyou;
        if (sannsyou.tag == "weapon1")
        {
            sannsyoustar = Instantiate(sannsyoustar1);
        }
        else if (sannsyou.tag == "weapon2")
        {
            sannsyoustar = Instantiate(sannsyoustar2);
        }
        else if (sannsyou.tag == "weapon3")
        {
            sannsyoustar = Instantiate(sannsyoustar3);
        }
        else if (sannsyou.tag == "weapon4")
        {
            sannsyoustar = Instantiate(sannsyoustar4);
        }
        else if (sannsyou.tag == "weapon5")
        {
            sannsyoustar = Instantiate(sannsyoustar5);
        }
        hyoujibuki = Instantiate(sannsyou, new Vector3(-6.4f, -2.55f, 0), Quaternion.identity);
        hyoujibuki.transform.localScale += new Vector3(1.5f, 1.5f, 0);
    }
}
