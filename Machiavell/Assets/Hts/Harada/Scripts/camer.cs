using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camer : MonoBehaviour
{

    public GameObject player;

    // Use this for initialization
    void Start()
    {
        // Playerの部分はカメラが追いかけたいオブジェクトの名前をいれる
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
    }
}