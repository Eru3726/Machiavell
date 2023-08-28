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
        // transform.localScale�̐����ɂ����Enemy��x�����ɔ��]����
        Vector3 scale = transform.localScale;
        // �n�_�����Enemy�̐i�s�����ɏo��悤��startposition�����߂�
        Vector3 startposition = transform.position + transform.right * 0.5f * scale.x;
        // startpostion���瑫���܂ł��I�_�Ƃ���
        Vector3 endposition = startposition - transform.up * 0.55f;

        // Debug�p�Ɏn�_�ƏI�_��\������
        Debug.DrawLine(startposition, endposition, Color.red);

        // Physics2D.Linecast���g���A�x�N�g����StageLayer���ڐG���Ă�����True��Ԃ�
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

    // �����]��������
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
