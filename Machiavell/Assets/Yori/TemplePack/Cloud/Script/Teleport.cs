using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private Vector3 pos;
    public GameObject player;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            // ��ɔ��ł���
            pos = other.gameObject.transform.position;
            pos.y += 65;
            other.gameObject.transform.position = pos;

            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            // ���x���O�ɂ���B
            rb.velocity = Vector3.zero;
        }
        //if (other.CompareTag("Player"))
        //{
        //    // ��ɔ��ł���
        //    pos = other.gameObject.transform.position;
        //    pos.y += 65;
        //    other.gameObject.transform.position = pos;

        //    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        //    // ���x���O�ɂ���B
        //    rb.velocity = Vector3.zero;
        //}
    }
}
