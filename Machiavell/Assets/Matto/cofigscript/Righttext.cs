using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Righttext : MonoBehaviour
{
    public Text text;
    public Keyconfig keycon;

    void Update()
    {
        text.text = GameData.righttx;
        if (keycon.right == true)
        {
            text.color = Color.clear;
        }
        else
        {
            text.color = Color.black;
        }
    }
    public void righttextchange()
    {
        GameData.righttx = keycon.keyStr;
    }

}
