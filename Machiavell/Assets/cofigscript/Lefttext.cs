using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lefttext : MonoBehaviour
{
    public Text text;
    public Keyconfig keycon;

    void Update()
    {
        text.text = GameData.lefttx;
        if (keycon.left == true)
        {
            text.color = Color.clear;
        }
        else
        {
            text.color = Color.black;
        }
    }
    public void lefttextchange()
    {
        GameData.lefttx = keycon.keyStr;
    }
}
