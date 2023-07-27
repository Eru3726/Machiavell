using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healpotionset : MonoBehaviour
{
    private Vector3 healpotionpos = new Vector3(-5.7f,-2.2f,0);
    public GameObject healpotion;
    // Start is called before the first frame update
    void Start()
    {
        if (GameData.healpotion == 1)
        {
            Instantiate(healpotion, healpotionpos, Quaternion.identity);
        }
        else if (GameData.healpotion == 2)
        {
            Instantiate(healpotion, healpotionpos, Quaternion.identity);
            Instantiate(healpotion, healpotionpos + new Vector3(6.1f, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
