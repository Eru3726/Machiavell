using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerspawn : MonoBehaviour
{
    public Save saveClass;
    public Read readClass;
    public Slotread sr;
    public Slotdrop sd;
    public GameObject player;
    private Vector3 skymapfirstpos = new Vector3(-20f,-4.3f,0);
    private Vector3 skymapsavepos = new Vector3(220f, 21.7f, 0);
    void Start()
    {
        readClass.enabled = true;
        //if (sr)
        //    sr.SlotDelete();
        Debug.Log("ì«Ç›çûÇ›Ç™Ç®ÇÌÇËÇ‹ÇµÇΩ");
        if (GameData.sky == true && GameData.save == false)
        {
            player.transform.position = skymapfirstpos;
        }
        else if (GameData.sky == true && GameData.save == true)
        {
            player.transform.position = skymapsavepos;
        }
        if (GameData.first == true)
        {
            sd.First();
        }
    }

    void Update()
    {

    }
}
