using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionChedk : MonoBehaviour
{
    // 2Dリジッドボディを受け取る変数
    Rigidbody2D rb2D;
    // アニメーション制御のやつ
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // アニメーター（アニメーション制御のやつ）を受け取る
        anim = GetComponent("Animator") as Animator;
        // ここで2Dリジッドボディを受け取る。
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // キャラクターの大きさ。負数にすると反転される
        Vector3 scale = transform.localScale;
        if (rb2D.velocity.x > 1)      // 右方向に動いている
            scale.x = 1;  // 通常方向(スプライトと同じ右向き)
        else if (rb2D.velocity.x < -1) // 左方向に動いている
            scale.x = -1; // 反転
        // 更新
        transform.localScale = scale;

        // ある程度の移動量だったらはばたく
        if (0.1 > rb2D.velocity.magnitude)
            anim.SetBool("Flying", false);
        else
            anim.SetBool("Flying", true);
    }
}
