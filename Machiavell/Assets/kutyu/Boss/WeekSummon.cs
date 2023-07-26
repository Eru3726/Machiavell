using UnityEngine;

public class WeekSummon : MonoBehaviour
{
    // ��]��
    [SerializeField] private Vector3 _axis = Vector3.up;

    // �~�^������
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

        //DataBase�Q��
        currentHealth = weekSummon.enemyMaxHp;

        waitCounter = 2;
    }
    private void Update()
    {
        var tr = transform;
        // ��]�̃N�H�[�^�j�I���쐬
        var angleAxis = Quaternion.AngleAxis(360 / _period * Time.deltaTime, _axis);

        // �~�^���̈ʒu�v�Z
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
    /// �U���֐�
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
    /// �_���[�W���󂯂��Ƃ��̊֐�
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
