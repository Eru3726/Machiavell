using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugenem : MonoBehaviour
{
    public GameObject spawn;
    void Start()
    {
    }

    void Update()
    {
        
    }
    public void Onclick()
    {
        if (spawn.GetComponent<Spawnbutton>().slime)
        {
            spawn.GetComponent<Spawnbutton>().slime.GetComponent<Slimes>().slimedebug();
        }
        if (spawn.GetComponent<Spawnbutton>().zombie)
        {
            Debug.Log("zombie");
            spawn.GetComponent<Spawnbutton>().zombie.GetComponent<Zombies>().zombiedebug();
        }
        if (spawn.GetComponent<Spawnbutton>().bad)
        {
            Debug.Log("bad");
            spawn.GetComponent<Spawnbutton>().bad.GetComponent<Bads>().baddebug();
        }
    }
}
