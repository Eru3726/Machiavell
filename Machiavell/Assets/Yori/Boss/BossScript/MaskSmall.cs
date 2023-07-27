using UnityEngine;

public class MaskSmall : MonoBehaviour
{
    [SerializeField, Header("Archange")]
    BOSS_AI boss;

    private Vector2 pos;
    private float speed = 4;

    void Start()
    {
        pos = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.tpStart)
        {
            boss.eyeMask.transform.localScale = new Vector2(0, 0);
            pos.x -= speed * Time.deltaTime;
            pos.y -= speed * Time.deltaTime;
            this.transform.localScale = pos;
            if (pos.x < 0 && pos.y < 0)
            {
                boss.tpStart = false;
            }
        }
        if (boss.tpEnd)
        {
            pos.x += speed * Time.deltaTime * 5;
            pos.y += speed * Time.deltaTime * 5;
            this.transform.localScale = pos;
            if (pos.x >= boss.bMfirst.x && pos.y >= boss.bMfirst.y)
            {
                boss.eyeMask.transform.localScale = boss.eMfirst;
                boss.tpEnd = false;
            }
        }
    }
}
