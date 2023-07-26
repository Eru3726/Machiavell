using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playertext : MonoBehaviour
{
    public Text PLV;
    public Text PHP;
    public Text PST;
    public Text POC;
    public Text PDC;
    public Text PLK;
    public Text PSP;
    void Start()
    {
        
    }

    void Update()
    {
        if (PLV)
        PLV.text = "LV   " +GameData.playerlevel.ToString();
        if (PHP)
        PHP.text = "HP " +GameData.playerhp.ToString();
        if (PST)
        PST.text = "ST " + GameData.playerstamina.ToString();
        if (POC)
        POC.text = "ATK  "+GameData.playeroffence.ToString();
        if (PDC)
        PDC.text = "DEF  "+GameData.playerdeffence.ToString();
        if (PLK)
        PLK.text = "LUK  "+GameData.playerluck.ToString();
        if (PSP)
        PSP.text = "SP   "+GameData.playerstatuspoint.ToString();
    }
}
