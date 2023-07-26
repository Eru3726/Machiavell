using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public GameObject spawn,floor;
    public Exp floor1, floor2, floor3, floor4;
    private float Floor;
    private float rnd;
    private int pexp;
    private GameObject slime,zombie, bad;
    // Start is called before the first frame update
    void Start()
    {
        rnd = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Floor = floor.GetComponent<Floor>().floor;
        slime = spawn.GetComponent<Spawnbutton>().slime;
        zombie = spawn.GetComponent<Spawnbutton>().zombie;
        bad = spawn.GetComponent<Spawnbutton>().bad;
    }

    public void OnClick()
    {
        if (rnd == 1)
        {
            Destroy(slime);
            if (slime.tag == "floor1")
            {
                Debug.Log(floor1.getexp + "expŠl“¾");
                pexp += floor1.getexp;
            }
            else if (slime.tag == "floor2")
            {
                Debug.Log(floor2.getexp + "expŠl“¾");
                pexp += floor2.getexp;
            }
            else if (slime.tag == "floor3")
            {
                Debug.Log(floor3.getexp + "expŠl“¾");
                pexp += floor3.getexp;
            }
            else if (slime.tag == "floor4")
            {
                Debug.Log(floor4.getexp + "expŠl“¾");
                pexp += floor4.getexp;
            }
        }

        else if (rnd == 2)
        {
            Destroy(spawn.GetComponent<Spawnbutton>().zombie);
            if (zombie.tag == "floor1")
            {
                Debug.Log(floor1.getexp + "expŠl“¾");
                pexp += floor1.getexp;
            }
            else if (zombie.tag == "floor2")
            {
                Debug.Log(floor2.getexp + "expŠl“¾");
                pexp += floor2.getexp;
            }
            else if (zombie.tag == "floor3")
            {
                Debug.Log(floor3.getexp + "expŠl“¾");
                pexp += floor3.getexp;
            }
            else if (zombie.tag == "floor4")
            {
                Debug.Log(floor4.getexp + "expŠl“¾");
                pexp += floor4.getexp;
            }
        }

        else if (rnd == 3)
        {
            Destroy(spawn.GetComponent<Spawnbutton>().bad);
            if (bad.tag == "floor1")
            {
                Debug.Log(floor1.getexp + "expŠl“¾");
                pexp += floor1.getexp;
            }
            else if (bad.tag == "floor2")
            {
                Debug.Log(floor2.getexp + "expŠl“¾");
                pexp += floor2.getexp;
            }
            else if (bad.tag == "floor3")
            {
                Debug.Log(floor3.getexp + "expŠl“¾");
                pexp += floor3.getexp;
            }
            else if (bad.tag == "floor4")
            {
                Debug.Log(floor4.getexp + "expŠl“¾");
                pexp += floor4.getexp;
            }
        }
        if (rnd <= 2)
        {
            rnd += 1;
        }
        else
        {
            rnd = 1;
        }
        Debug.Log("ƒvƒŒƒCƒ„[‚ÌŽ‚Á‚Ä‚¢‚éŒoŒ±’l" + pexp + "exp");
    }
}
