using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotstar : MonoBehaviour
{
    public GameObject parent;
    public Slotcontroll sc;
    private float deth = 0;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star5;
    public GameObject star6;
    public GameObject star7;
    public GameObject star8;
    public GameObject star9;
    public GameObject star10;
    public GameObject rare1;
    public GameObject rare2;
    public GameObject rare3;
    public GameObject rare4;
    public GameObject rare5;
    public Slotdrop sd;
    private Vector3 pos;
    private Vector3 pos1 = new Vector3(-11.8f, -6.9f, 10);
    private Vector3 pos2;
    private Vector3 pos3;
    private Vector3 pos4;
    private Vector3 pos5;
    private Vector3 pos6;
    private Vector3 pos7;
    private Vector3 pos8;
    private Vector3 pos9;
    private Vector3 pos10;
    public bool hyouji1 = true;
    public bool hyouji2 = true;
    public bool hyouji3 = true;
    public bool hyouji4 = true;
    public bool hyouji5 = true;
    public bool hyouji6 = true;
    public bool hyouji7 = true;
    public bool hyouji8 = true;
    public bool hyouji9 = true;
    public bool hyouji10 = true;
    void Start()
    {
        pos2 = pos1 + new Vector3(2.88f, 0, 0);
        pos3 = pos2 + new Vector3(2.88f, 0, 0);
        pos4 = pos3 + new Vector3(2.88f, 0, 0);
        pos5 = pos4 + new Vector3(2.88f, 0, 0);
        pos6 = pos5 + new Vector3(2.88f, 0, 0);
        pos7 = pos6 + new Vector3(2.88f, 0, 0);
        pos8 = pos7 + new Vector3(2.88f, 0, 0);
        pos9 = pos8 + new Vector3(2.88f, 0, 0);
        pos10 = pos9 + new Vector3(2.88f, 0, 0);
    }
    void Update()
    {
        if (hyouji1 == true)
        {
            if (sd.pos1&&!star1)
            {
                deth = 1;
                pos = pos1;
                if (sd.pos1.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos1.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos1.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos1.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos1.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji1 = false;
            }
        }
        else if (!sd.pos1)
        {
            hyouji1 = true;
        }
        if (hyouji2 == true)
        {
            if (sd.pos2&&!star2)
            {
                deth = 2;
                pos = pos2;
                if (sd.pos2.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos2.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos2.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos2.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos2.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji2 = false;
            }
        }
        else if (!sd.pos2)
        {
            hyouji2 = true;
        }
        if (hyouji3 == true)
        {
            if (sd.pos3 && !star3)
            {
                deth = 3;
                pos = pos3;
                if (sd.pos3.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos3.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos3.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos3.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos3.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji3 = false;
            }
        }
        else if (!sd.pos3)
        {
            hyouji3 = true;
        }
        if (hyouji4 == true)
        {
            deth = 4;
            if (sd.pos4 && !star4)
            {
                pos = pos4;
                if (sd.pos4.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos4.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos4.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos4.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos4.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji4 = false;
            }
        }
        else if (!sd.pos4)
        {
            hyouji4 = true;
        }
        if (hyouji5 == true)
        {
            if (sd.pos5 && !star5)
            {
                deth = 5;
                pos = pos5;
                if (sd.pos5.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos5.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos5.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos5.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos5.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji5 = false;
            }
        }
        else if (!sd.pos5)
        {
            hyouji5 = true;
        }
        if (hyouji6 == true)
        {
            if (sd.pos6 && !star6)
            {
                deth = 6;
                pos = pos6;
                if (sd.pos6.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos6.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos6.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos6.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos6.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji6 = false;
            }
        }
        else if (!sd.pos6)
        {
            hyouji6 = true;
        }
        if (hyouji7 == true)
        {
            if (sd.pos7 && !star7)
            {
                deth = 7;
                pos = pos7;
                if (sd.pos7.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos7.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos7.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos7.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos7.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji7 = false;
            }
        }
        else if (!sd.pos7)
        {
            hyouji7 = true;
        }
        if (hyouji8 == true)
        {
            if (sd.pos8 && !star8)
            {
                deth = 8;
                pos = pos8;
                if (sd.pos8.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos8.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos8.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos8.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos8.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji8 = false;
            }
        }
        else if (!sd.pos8)
        {
            hyouji8 = true;
        }
        if (hyouji9 == true)
        {
            if (sd.pos9 && !star9)
            {
                deth = 9;
                pos = pos9;
                if (sd.pos9.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos9.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos9.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos9.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos9.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji9 = false;
            }
        }
        else if (!sd.pos9)
        {
            hyouji9 = true;
        }
        if (hyouji10 == true)
        {
            if (sd.pos10 && !star10)
            {
                deth = 10;
                pos = pos10;
                if (sd.pos10.tag == "weapon1")
                {
                    hosi1();
                }
                else if (sd.pos10.tag == "weapon2")
                {
                    hosi2();
                }
                else if (sd.pos10.tag == "weapon3")
                {
                    hosi3();
                }
                else if (sd.pos10.tag == "weapon4")
                {
                    hosi4();
                }
                else if (sd.pos10.tag == "weapon5")
                {
                    hosi5();
                }
                hyouji10 = false;
            }
        }
        else if (!sd.pos10)
        {
            hyouji10 = true;
        }
    }
    private void hosi1()
    {
        if (deth == 1)
        {
            star1 = Instantiate(rare1, pos, Quaternion.identity);
            star1.transform.parent = parent.transform;
            star1.transform.localPosition = pos;
            sc.hosi1 = star1;
        }
        else if (deth == 2)
        {
            star2 = Instantiate(rare1, pos, Quaternion.identity);
            star2.transform.parent = parent.transform;
            star2.transform.localPosition = pos;
            sc.hosi2 = star2;
        }
        else if (deth == 3)
        {
            star3 = Instantiate(rare1, pos, Quaternion.identity);

            star3.transform.parent = parent.transform;
            star3.transform.localPosition = pos;
            sc.hosi3 = star3;
        }
        else if (deth == 4)
        {
            star4 = Instantiate(rare1, pos, Quaternion.identity);

            star4.transform.parent = parent.transform;
            star4.transform.localPosition = pos;
            sc.hosi4 = star4;
        }
        else if (deth == 5)
        {
            star5 = Instantiate(rare1, pos, Quaternion.identity);

            star5.transform.parent = parent.transform;
            star5.transform.localPosition = pos;
            sc.hosi5 = star5;
        }
        else if (deth == 6)
        {
            star6 = Instantiate(rare1, pos, Quaternion.identity);
            star6.transform.parent = parent.transform;
            star6.transform.localPosition = pos;
            sc.hosi6 = star6;
        }
        else if (deth == 7)
        {
            star7 = Instantiate(rare1, pos, Quaternion.identity);
            star7.transform.parent = parent.transform;
            star7.transform.localPosition = pos;
            sc.hosi7 = star7;
        }
        else if (deth == 8)
        {
            star8 = Instantiate(rare1, pos, Quaternion.identity);
            star8.transform.parent = parent.transform;
            star8.transform.localPosition = pos;
            sc.hosi8 = star8;
        }
        else if (deth == 9)
        {
            star9 = Instantiate(rare1, pos, Quaternion.identity);
            star9.transform.parent = parent.transform;
            star9.transform.localPosition = pos;
            sc.hosi9 = star9;
        }
        else if (deth == 10)
        {
            star10 = Instantiate(rare1, pos, Quaternion.identity);
            star10.transform.parent = parent.transform;
            star10.transform.localPosition = pos;
            sc.hosi10 = star10;
        }
    }
    private void hosi2()
    {
        pos += new Vector3(0.15f, 0, 0);
        if (deth == 1)
        {
            star1 = Instantiate(rare2, pos, Quaternion.identity);
            star1.transform.parent = parent.transform;
            star1.transform.localPosition = pos;
            sc.hosi1 = star1;
        }
        else if (deth == 2)
        {
            star2 = Instantiate(rare2, pos, Quaternion.identity);

            star2.transform.parent = parent.transform;
            star2.transform.localPosition = pos;
            sc.hosi2 = star2;
        }
        else if (deth == 3)
        {
            star3 = Instantiate(rare2, pos, Quaternion.identity);

            star3.transform.parent = parent.transform;
            star3.transform.localPosition = pos;
            sc.hosi3 = star3;
        }
        else if (deth == 4)
        {
            star4 = Instantiate(rare2, pos, Quaternion.identity);

            star4.transform.parent = parent.transform;
            star4.transform.localPosition = pos;
            sc.hosi4 = star4;
        }
        else if (deth == 5)
        {
            star5 = Instantiate(rare2, pos, Quaternion.identity);

            star5.transform.parent = parent.transform;
            star5.transform.localPosition = pos;
            sc.hosi5 = star5;
        }
        else if (deth == 6)
        {
            star6 = Instantiate(rare2, pos, Quaternion.identity);
            star6.transform.parent = parent.transform;
            star6.transform.localPosition = pos;
            sc.hosi6 = star6;
        }
        else if (deth == 7)
        {
            star7 = Instantiate(rare2, pos, Quaternion.identity);
            star7.transform.parent = parent.transform;
            star7.transform.localPosition = pos;
            sc.hosi7 = star7;
        }
        else if (deth == 8)
        {
            star8 = Instantiate(rare2, pos, Quaternion.identity);
            star8.transform.parent = parent.transform;
            star8.transform.localPosition = pos;
            sc.hosi8 = star8;
        }
        else if (deth == 9)
        {
            star9 = Instantiate(rare2, pos, Quaternion.identity);
            star9.transform.parent = parent.transform;
            star9.transform.localPosition = pos;
            sc.hosi9 = star9;
        }
        else if (deth == 10)
        {
            star10 = Instantiate(rare2, pos, Quaternion.identity);
            star10.transform.parent = parent.transform;
            star10.transform.localPosition = pos;
            sc.hosi10 = star10;
        }
    }
    private void hosi3()
    {
        pos += new Vector3(0.3f, 0, 0);
        if (deth == 1)
        {
            star1 = Instantiate(rare3, pos, Quaternion.identity);
            star1.transform.parent = parent.transform;
            star1.transform.localPosition = pos;
            sc.hosi1 = star1;
        }
        else if (deth == 2)
        {
            star2 = Instantiate(rare3, pos, Quaternion.identity);

            star2.transform.parent = parent.transform;
            star2.transform.localPosition = pos;
            sc.hosi2 = star2;
        }
        else if (deth == 3)
        {
            star3 = Instantiate(rare3, pos, Quaternion.identity);

            star3.transform.parent = parent.transform;
            star3.transform.localPosition = pos;
            sc.hosi3 = star3;
        }
        else if (deth == 4)
        {
            star4 = Instantiate(rare3, pos, Quaternion.identity);

            star4.transform.parent = parent.transform;
            star4.transform.localPosition = pos;
            sc.hosi4 = star4;
        }
        else if (deth == 5)
        {
            star5 = Instantiate(rare3, pos, Quaternion.identity);

            star5.transform.parent = parent.transform;
            star5.transform.localPosition = pos;
            sc.hosi5 = star5;
        }
        else if (deth == 6)
        {
            star6 = Instantiate(rare3, pos, Quaternion.identity);
            star6.transform.parent = parent.transform;
            star6.transform.localPosition = pos;
            sc.hosi6 = star6;
        }
        else if (deth == 7)
        {
            star7 = Instantiate(rare3, pos, Quaternion.identity);
            star7.transform.parent = parent.transform;
            star7.transform.localPosition = pos;
            sc.hosi7 = star7;
        }
        else if (deth == 8)
        {
            star8 = Instantiate(rare3, pos, Quaternion.identity);
            star8.transform.parent = parent.transform;
            star8.transform.localPosition = pos;
            sc.hosi8 = star8;
        }
        else if (deth == 9)
        {
            star9 = Instantiate(rare3, pos, Quaternion.identity);
            star9.transform.parent = parent.transform;
            star9.transform.localPosition = pos;
            sc.hosi9 = star9;
        }
        else if (deth == 10)
        {
            star10 = Instantiate(rare3, pos, Quaternion.identity);
            star10.transform.parent = parent.transform;
            star10.transform.localPosition = pos;
            sc.hosi10 = star10;
        }
    }
    private void hosi4()
    {
        pos += new Vector3(0.45f, 0, 0);
        if (deth == 1)
        {
            star1 = Instantiate(rare4, pos, Quaternion.identity);
            star1.transform.parent = parent.transform;
            star1.transform.localPosition = pos;
            sc.hosi1 = star1;
        }
        else if (deth == 2)
        {
            star2 = Instantiate(rare4, pos, Quaternion.identity);

            star2.transform.parent = parent.transform;
            star2.transform.localPosition = pos;
            sc.hosi2 = star2;
        }
        else if (deth == 3)
        {
            star3 = Instantiate(rare4, pos, Quaternion.identity);

            star3.transform.parent = parent.transform;
            star3.transform.localPosition = pos;
            sc.hosi3 = star3;
        }
        else if (deth == 4)
        {
            star4 = Instantiate(rare4, pos, Quaternion.identity);

            star4.transform.parent = parent.transform;
            star4.transform.localPosition = pos;
            sc.hosi4 = star4;
        }
        else if (deth == 5)
        {
            star5 = Instantiate(rare4, pos, Quaternion.identity);

            star5.transform.parent = parent.transform;
            star5.transform.localPosition = pos;
            sc.hosi5 = star5;
        }
        else if (deth == 6)
        {
            star6 = Instantiate(rare4, pos, Quaternion.identity);
            star6.transform.parent = parent.transform;
            star6.transform.localPosition = pos;
            sc.hosi6 = star6;
        }
        else if (deth == 7)
        {
            star7 = Instantiate(rare4, pos, Quaternion.identity);
            star7.transform.parent = parent.transform;
            star7.transform.localPosition = pos;
            sc.hosi7 = star7;
        }
        else if (deth == 8)
        {
            star8 = Instantiate(rare4, pos, Quaternion.identity);
            star8.transform.parent = parent.transform;
            star8.transform.localPosition = pos;
            sc.hosi8 = star8;
        }
        else if (deth == 9)
        {
            star9 = Instantiate(rare4, pos, Quaternion.identity);
            star9.transform.parent = parent.transform;
            star9.transform.localPosition = pos;
            sc.hosi9 = star9;
        }
        else if (deth == 10)
        {
            star10 = Instantiate(rare4, pos, Quaternion.identity);
            star10.transform.parent = parent.transform;
            star10.transform.localPosition = pos;
            sc.hosi10 = star10;
        }
    }
    private void hosi5()
    {
        pos += new Vector3(0.6f, 0, 0);
        if (deth == 1)
        {
            star1 = Instantiate(rare5, pos, Quaternion.identity);
            star1.transform.parent = parent.transform;
            star1.transform.localPosition = pos;
            sc.hosi1 = star1;
        }
        else if (deth == 2)
        {
            star2 = Instantiate(rare5, pos, Quaternion.identity);

            star2.transform.parent = parent.transform;
            star2.transform.localPosition = pos;
            sc.hosi2 = star2;
        }
        else if (deth == 3)
        {
            star3 = Instantiate(rare5, pos, Quaternion.identity);

            star3.transform.parent = parent.transform;
            star3.transform.localPosition = pos;
            sc.hosi3 = star3;
        }
        else if (deth == 4)
        {
            star4 = Instantiate(rare5, pos, Quaternion.identity);

            star4.transform.parent = parent.transform;
            star4.transform.localPosition = pos;
            sc.hosi4 = star4;
        }
        else if (deth == 5)
        {
            star5 = Instantiate(rare5, pos, Quaternion.identity);

            star5.transform.parent = parent.transform;
            star5.transform.localPosition = pos;
            sc.hosi5 = star5;
        }
        else if (deth == 6)
        {
            star6 = Instantiate(rare5, pos, Quaternion.identity);
            star6.transform.parent = parent.transform;
            star6.transform.localPosition = pos;
            sc.hosi6 = star6;
        }
        else if (deth == 7)
        {
            star7 = Instantiate(rare5, pos, Quaternion.identity);
            star7.transform.parent = parent.transform;
            star7.transform.localPosition = pos;
            sc.hosi7 = star7;
        }
        else if (deth == 8)
        {
            star8 = Instantiate(rare5, pos, Quaternion.identity);
            star8.transform.parent = parent.transform;
            star8.transform.localPosition = pos;
            sc.hosi8 = star8;
        }
        else if (deth == 9)
        {
            star9 = Instantiate(rare5, pos, Quaternion.identity);
            star9.transform.parent = parent.transform;
            star9.transform.localPosition = pos;
            sc.hosi9 = star9;
        }
        else if (deth == 10)
        {
            star10 = Instantiate(rare5, pos, Quaternion.identity);
            star10.transform.parent = parent.transform;
            star10.transform.localPosition = pos;
            sc.hosi10 = star10;
        }
    }
}
