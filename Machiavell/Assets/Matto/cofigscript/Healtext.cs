using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healtext : MonoBehaviour
{
    public Text text;
    public Keyconfig keycon;
    void Update()
    {
        text.text = GameData.healtx;
        if (keycon.heal == true)
        {
            text.color = Color.clear;
        }
        else
        {
            text.color = Color.black;
        }
    }
    public void menutextchange()
    {
        GameData.healtx = keycon.keyStr;
    }
}
