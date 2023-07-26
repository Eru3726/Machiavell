using UnityEngine;

public class WeekSummon : MonoBehaviour
{
    // âÒì]é≤
    [SerializeField] private Vector3 _axis = Vector3.up;

    // â~â^ìÆé¸ä˙
    [SerializeField] private float _period = 2;

    [SerializeField, Tooltip("DataBase")]
    private Enemy weekSummon;

    private bool isChaseing;

    private float waitTime, waitCounter, rangeToChase;

    private Transform target;

    private int currentHealth;

    private Vector2 dir;

    private float speed;

    private BOSS_AI boss;

    [SerializeField]
    private GameObject laser;


    private void Start()
    {
        target = GameObject.Find("player").transform;
        GameObject obj = GameObject.Find("Archange");
        boss = obj.GetComponent<BOSS_AI>();

        //DataBaseéQè∆
        currentHealth = weekSummon.enemyMaxHp;

        waitCounter = 2;
    }
    private void Update()
    {
        var tr = transform;
        // âÒì]ÇÃÉNÉHÅ[É^ÉjÉIÉìçÏê¨
        var angleAxis = Quaternion.AngleAxis(360 / _period * Time.deltaTime, _axis);

        // â~â^ìÆÇÃà íuåvéZ
        var pos = tr.position;

        Vector3 anotherTransform1 = GameObject.Find("Archange").transform.position;

        pos -= anotherTransform1;
        pos = angleAxis * pos;
        pos += anotherTransform1;
        tr.position = pos;

        if (boss.actNo == 7 || boss.actNo == 3)
        {
            return;
        }

        if (waitCounter > 0)
        {
            waitCounter -= Time.deltaTime;
        }
        else
        {
            Shot();

            waitCounter = weekSummon.enemyWaitTime;
        }
        if (boss.waveFlg)
        {
            Destroy(gameObject);
        }
        if (boss.dieFlg)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// çUåÇä÷êî
    /// </summary>
    public void Shot()
    {
        dir = target.transform.position - transform.position;
        dir.Normalize();

        GameObject ler = (GameObject)Instantiate(laser, transform.position, Quaternion.FromToRotation(Vector2.up, dir));
        Rigidbody2D lrb = ler.GetComponent<Rigidbody2D>();
        lrb.velocity = dir * weekSummon.enemyChaseSpeed;
    }


    /// <summary>
    /// É_ÉÅÅ[ÉWÇéÛÇØÇΩÇ∆Ç´ÇÃä÷êî
    /// </summary>
    /// <param name="damage"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Attack"))
        {
            Destroy(gameObject);
            boss.summonNum++;
        }
    }
}
