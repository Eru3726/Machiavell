using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camer : MonoBehaviour
{

    public GameObject player;

    // Use this for initialization
    void Start()
    {
        // Player�̕����̓J�������ǂ����������I�u�W�F�N�g�̖��O�������
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
    }
}