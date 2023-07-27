using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nukeruyuka : MonoBehaviour
{
    KeyCode downcode;
    private PlatformEffector2D _platformEffector2D;
    void Start()
    {
        downcode = GameData.downkey;
        _platformEffector2D = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float STOP;
        //STOP = Playe.stop;
        STOP = Newplayer.stop;

        if (Input.GetKeyDown(downcode) && STOP == 0)
        {
                _platformEffector2D.rotationalOffset = 180f;
        }
        if (Input.GetKeyUp(downcode) && STOP == 0)
        {
            Invoke(nameof(modoru), 0.2f);
        }
    }

    void modoru()
    {
        _platformEffector2D.rotationalOffset = 0f;
    }
}
