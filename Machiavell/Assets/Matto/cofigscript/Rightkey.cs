using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightkey : MonoBehaviour
{
    public Keyconfig keycon;
    void Start()
    {
    }

    void Update()
    {

    }

    public void Onclick()
    {
        keycon.right = true;
    }
    public void rightkeychange()
    {
        GameData.rightkey = keycon.codechange;
    }
}
