using UnityEngine;

public class MoveLeftRight
{
    private LayerMask StageLayer = 1 << 18;

    public enum MOVE_TYPE
    {
        STOP,
        RIGHT,
        LEFT,
    }
    public MOVE_TYPE move = MOVE_TYPE.RIGHT;

    public float MoveChk(Transform transform, float speed)
    {
        if (!GroundChk(transform) || WallChk(transform)) speed = ChgDIrection(transform, speed);

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

        // Physics2D.Linecastを使い、ベクトルとStageLayerが接触していたらTrueを返す
        return Physics2D.Linecast(startposition, endposition, StageLayer);
    }

    private bool WallChk(Transform transform)
    {
        Vector3 scale = transform.localScale;

        Vector3 startposition = transform.position + transform.right * 0.3f * scale.x;

        Vector3 endposition = startposition + transform.right * 0.3f * scale.x;

        Debug.DrawLine(startposition, endposition, Color.blue);

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

        return speed;
    }
}
