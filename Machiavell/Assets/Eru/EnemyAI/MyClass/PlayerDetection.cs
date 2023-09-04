using UnityEngine;

[System.Serializable]
public class PlayerDetection
{
    [Header("プレイヤーのレイヤー")]
    public LayerMask PlayerLayer;

    private bool chk = false;

    public enum Chk_TYPE
    {
        NONE,
        QUARTER,
        HALF,
        FULL,
    }
    [Header("チェック内容")]
    public Chk_TYPE chkType = Chk_TYPE.NONE;

    public bool PlayerChk(Transform transform)
    {
        chk = false;
        if (chkType != Chk_TYPE.NONE)
        {
            QuarterChk(transform);
        }
        return chk;
    }

    private void QuarterChk(Transform transform)
    {
        Vector3 scale = transform.localScale;

        Vector3 startposition = transform.position;

        Vector3 endposition = startposition + transform.right * 0.3f * scale.x;

        Debug.DrawLine(startposition, endposition, Color.blue);

        chk = Physics2D.Linecast(startposition, endposition, PlayerLayer);

    }
}
