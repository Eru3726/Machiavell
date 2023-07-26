using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Jumptext : MonoBehaviour
{
    public Keyconfig keycon;
    public Text text;


    void Update()
    {
        text.text = GameData.jumptx;
        if (keycon.jump == true)
        {
            text.color = Color.clear;
        }
        else
        {
            text.color = Color.black;
        }
    }
    public void jumptextchange()
    {
        GameData.jumptx = keycon.keyStr;
    }
}
