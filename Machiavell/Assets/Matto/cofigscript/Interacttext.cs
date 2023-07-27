using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interacttext : MonoBehaviour
{
    public Keyconfig keycon;
    public Text text;
    void Start()
    {
        
    }

    void Update()
    {
        text.text = GameData.interacttx;
        if (keycon.interact == true)
        {
            text.color = Color.clear;
        }
        else
        {
            text.color = Color.black;
        }
    }
    public void interacttextchange()
    {
        GameData.interacttx = keycon.keyStr;
    }
}
