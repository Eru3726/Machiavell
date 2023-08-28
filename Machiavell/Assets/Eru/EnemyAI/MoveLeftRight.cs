using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight
{
    private LayerMask StageLayer = LayerMask.NameToLayer("stage");

    public enum MOVE_TYPE
    {
        STOP,
        RIGHT,
        LEFT,
    }
    public MOVE_TYPE move = MOVE_TYPE.RIGHT;

    //private Rigidbody2D rbody2D;

    //[SerializeField]
    //private float speed;
    //private float moveSpeed;

    //[SerializeField]
    //private float turnTime = 2f;

    //private float timer;

    //private void Start()
    //{
    //    rbody2D = GetComponent<Rigidbody2D>();

    //    timer = turnTime;
    //}

    //private void Update()
    //{
    //    地面に触れてなければ方向転換
    //    if (!GroundChk() || WallChk())
    //    {
    //        // 方向転換をする
    //        ChgDIrection();
    //    }
    //}

    public float MoveChk(Transform transform, float speed)
    {
        if (!GroundChk(transform) || WallChk(transform))
        {
            // 方向転換をする
            speed = ChgDIrection(transform, speed);
        }

        return speed;
    }

    private bool GroundChk(Transform transform)
    {
        // transform.localScaleの正負によってEnemyをx方向に反転する
        Vector3 scale = transform.localScale;
        // 始点が常にEnemyの進行方向に出るようにstartpositionを決める
        Vector3 startposition = transform.position + transform.right * 0.5f * scale.x;
        // startpostionから足元までを終点とする
        Vector3 endposition = startposition - transform.up * 0.55f;

        // Debug用に始点と終点を表示する
        Debug.DrawLine(startposition, endposition, Color.red);

        Debug.Log(Physics2D.Linecast(startposition, endposition, StageLayer));

        // Physics2D.Linecastを使い、ベクトルとStageLayerが接触していたらTrueを返す
        return Physics2D.Linecast(startposition, endposition, StageLayer);
    }

    private bool WallChk(Transform transform)
    {
        // transform.localScaleの正負によってEnemyをx方向に反転する
        Vector3 scale = transform.localScale;
        // 始点が常にEnemyの進行方向に出るようにstartpositionを決める
        Vector3 startposition = transform.position + transform.right * 0.3f * scale.x;
        // startpostionから足元までを終点とする
        Vector3 endposition = startposition + transform.right * 0.3f * scale.x;

        // Debug用に始点と終点を表示する
        Debug.DrawLine(startposition, endposition, Color.blue);

        Debug.Log(Physics2D.Linecast(startposition, endposition, StageLayer));

        // Physics2D.Linecastを使い、ベクトルとStageLayerが接触していたらTrueを返す
        return Physics2D.Linecast(startposition, endposition, StageLayer);
    }

    // 方向転換をする
    private float ChgDIrection(Transform transform, float speed)
    {
        if (move == MOVE_TYPE.RIGHT) move = MOVE_TYPE.LEFT;
        else move = MOVE_TYPE.RIGHT;

        float scale = transform.localScale.x;
        if (move == MOVE_TYPE.STOP)
        {
            speed = 0;
        }
        else if (move == MOVE_TYPE.RIGHT)
        {
            scale = Mathf.Abs(scale);
            speed = Mathf.Abs(speed); 
        }
        else if (move == MOVE_TYPE.LEFT)
        {
            scale = -Mathf.Abs(scale);
            speed = -Mathf.Abs(speed);
        }
        transform.localScale = new Vector3(scale, transform.localScale.y, transform.localScale.z);

        //timer = turnTime;

        return speed;
    }

    //private void FixedUpdate()
    //{
    //    timer -= Time.deltaTime;

    //    if (timer <= 0f) ChgDIrection();

    //    Vector3 scale = transform.localScale;
    //    if (move == MOVE_TYPE.STOP)
    //    {
    //        moveSpeed = 0;
    //    }
    //    else if (move == MOVE_TYPE.RIGHT)
    //    {
    //        scale.x = 1; // 右向き
    //        moveSpeed = speed;
    //    }
    //    else if (move == MOVE_TYPE.LEFT)
    //    {
    //        scale.x = -1; // 左向き
    //        moveSpeed = -speed;
    //    }
    //    transform.localScale = scale;

    //    rbody2D.velocity = new Vector2(moveSpeed, rbody2D.velocity.y);
    //}
}
