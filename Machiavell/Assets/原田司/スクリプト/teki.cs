using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teki : MonoBehaviour
{
    public float DEF = 2;
    public float HP = 10;
    public float Dameg;

    float Dameg2;

    public GameObject player;

    private Rigidbody2D rb2d;
    BoxCollider2D bc2d;

    //“GƒvƒŒƒnƒu
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    { 

    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.CompareTag("Attack"))
        {
            Dameg2 = Dameg;
            Dameg2 -= DEF;

            if (Dameg2 > 0) { HP -= Dameg2; }
            else if (Dameg2 <= 0) { HP -= 0; }
        }

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
