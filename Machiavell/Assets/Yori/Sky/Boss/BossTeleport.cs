using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTeleport : MonoBehaviour
{
    private Vector3 pos;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name=="player")
        {
            // 上に飛んでいく
            pos = other.gameObject.transform.position;
            pos.y += 45;
            other.gameObject.transform.position = pos;

            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            // 速度を０にする。
            rb.velocity = Vector3.zero;
        }
        //if (other.CompareTag("Attack"))
        //{

        //    // 上に飛んでいく
        //    pos = other.gameObject.transform.position;
        //    pos.y += 45;
        //    other.gameObject.transform.position = pos;

        //    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        //    // 速度を０にする。
        //    rb.velocity = Vector3.zero;
        //}
    }
}
