using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    private GameObject playerObject;
    private Vector3 PlayerPosition;
    private Vector3 EnemyPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");

        PlayerPosition = playerObject.transform.position;
        EnemyPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = playerObject.transform.position;
        EnemyPosition = transform.position;

        EnemyPosition.x += (PlayerPosition.x - EnemyPosition.x) * 0.01f;
        EnemyPosition.y += (PlayerPosition.y - EnemyPosition.y) * 0.01f;
        transform.position = EnemyPosition;
    }
}