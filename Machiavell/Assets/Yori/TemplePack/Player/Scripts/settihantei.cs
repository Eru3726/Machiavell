using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settihantei : MonoBehaviour
{
    GameObject Player;
    Playe Playe;
    Newplayer newplaye;
    void Start()
    {
        Player = GameObject.Find("player");
        Playe = Player.GetComponent<Playe>();
        newplaye = Player.GetComponent<Newplayer>();
    }
    void Update()
    {
        if (gameObject.layer != Player.layer)
        gameObject.layer = Player.layer;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("down");
        if (collision.gameObject.CompareTag("grand"))
        {
            //Playe.jumpcout = 0; //�n�ʂɐG�ꂽ��l��0�ɖ߂�
            newplaye.jumpcout = 0;
        }
    }
}
