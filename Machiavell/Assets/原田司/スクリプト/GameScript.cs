using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public float stamina;

    KeyCode dashcode;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        dashcode = GameData.dashkey;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(dashcode) && stamina >= 10)
        {
            stamina += -10;
            image.fillAmount -= 0.1f;
        }
        else
        {
            image.fillAmount += Time.deltaTime / 100;
        }

        if (stamina <= 100)
        {
            stamina += Time.deltaTime;　//毎秒１のスタミナ回復
        }
    }
}
