using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slotdethstar : MonoBehaviour
{
    public Slotsannsyou ss;
    public Slotdrop sd;
    public slotstar sr;
    public Slotstatusdeth ssd;
    void Start()
    {

    }
    void Update()
    {

    }
    public void dethstar()
    {
        if (ssd.notdeth == false)
        {
            if (ss)
            {
                if (ss.sannsyou == sd.pos1)
                {
                    Destroy(sr.star1);
                }
                else if (ss.sannsyou == sd.pos2)
                {
                    Destroy(sr.star2);
                    Debug.Log("dethstarrrrrrrrrr");
                }
                else if (ss.sannsyou == sd.pos3)
                {
                    Destroy(sr.star3);
                }
                else if (ss.sannsyou == sd.pos4)
                {
                    Destroy(sr.star4);
                }
                else if (ss.sannsyou == sd.pos5)
                {
                    Destroy(sr.star5);
                }
                else if (ss.sannsyou == sd.pos6)
                {
                    Destroy(sr.star6);
                }
                else if (ss.sannsyou == sd.pos7)
                {
                    Destroy(sr.star7);
                }
                else if (ss.sannsyou == sd.pos8)
                {
                    Destroy(sr.star8);
                }
                else if (ss.sannsyou == sd.pos9)
                {
                    Destroy(sr.star9);
                }
                else if (ss.sannsyou == sd.pos10)
                {
                    Destroy(sr.star10);
                }
            }
        }
        else
        {
            Debug.Log("notdethtrue");
        }
    }
}
