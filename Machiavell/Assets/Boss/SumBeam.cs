using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumBeam : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy weekSum;

    public float attackDamage;

    private float deleteTime;

    void Start()
    {
        //DataBase参照
        attackDamage = weekSum.enemyOffensivePower;
        deleteTime = weekSum.enemyWalkTime;
    }

    private void Update()
    {
        deleteTime -= Time.deltaTime;

        if (deleteTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //プレイヤーへのダメージなどのプログラムはここに
            Debug.Log("サモビームがプレイヤーにダメージ");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "grand" || collision.gameObject.tag == "Attack")
        {
            //Destroy(gameObject);
        }
    }
}
