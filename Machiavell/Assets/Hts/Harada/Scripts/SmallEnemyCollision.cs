using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemyCollision : MonoBehaviour
{
    private GameObject playerObject;
    private Vector3 PlayerPosition;
    private Vector3 EnemyPosition;
    public float speed;

    private SpriteRenderer sr = null;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");

        PlayerPosition = playerObject.transform.position;
        EnemyPosition = transform.position;

        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = playerObject.transform.position;
        EnemyPosition = transform.position;

        //ƒJƒƒ‰‚ÉŽÊ‚Á‚½‚çˆÚ“®ŠJŽn
        if (sr.isVisible)
        {
            if (PlayerPosition.x > EnemyPosition.x)
            {
                EnemyPosition.x = EnemyPosition.x + speed;
            }
            else if (PlayerPosition.x < EnemyPosition.x)
            {
                EnemyPosition.x = EnemyPosition.x - speed;
            }

            if (PlayerPosition.y > EnemyPosition.y)
            {
                EnemyPosition.y = EnemyPosition.y + speed;
            }
            else if (PlayerPosition.y < EnemyPosition.y)
            {
                EnemyPosition.y = EnemyPosition.y - speed;
            }
        }
        transform.position = EnemyPosition;
    }
}