using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetkey : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void rightreset()
    {
        GameData.rightkey = KeyCode.D;
        GameData.righttx = "D";
    }
    public void leftreset()
    {
        GameData.leftkey = KeyCode.A;
        GameData.lefttx = "A";
    }
    public void downreset()
    {
        GameData.downkey = KeyCode.S;
        GameData.downtx = "S";
    }
    public void jumpreset()
    {
        GameData.jumpkey = KeyCode.Space;
        GameData.jumptx = "Space";
    }
    public void attackreset()
    {
        GameData.attackkey = KeyCode.Mouse0;
        GameData.attacktx = "Mouse0";
    }
    public void dashreset()
    {
        GameData.dashkey = KeyCode.LeftShift;
        GameData.dashtx = "LeftShift";
    }
    
    public void menureset()
    {
        GameData.healkey = KeyCode.H;
        GameData.healtx = "H";
    }
    public void interactreset()
    {
        GameData.interactkey = KeyCode.E;
        GameData.interacttx = "E";
    }
    public void allreset()
    {
        GameData.rightkey = KeyCode.D;
        GameData.righttx = "D";
        GameData.leftkey = KeyCode.A;
        GameData.lefttx = "A";
        GameData.downkey = KeyCode.S;
        GameData.downtx = "S";
        GameData.jumpkey = KeyCode.Space;
        GameData.jumptx = "Space";
        GameData.attackkey = KeyCode.Mouse0;
        GameData.attacktx = "Mouse0";
        GameData.dashkey = KeyCode.LeftShift;
        GameData.dashtx = "LeftShift";
        GameData.healkey = KeyCode.H;
        GameData.healtx = "H";
        GameData.interactkey = KeyCode.E;
        GameData.interacttx = "E";
    }
}
