using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    Animator animator;    //アニメーター
    KeyCode attackcode;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        attackcode = GameData.attackkey;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attackcode))
        {
            this.animator.SetTrigger("hand");
        }
    }
}
