using UnityEngine;

public class Angelus : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy angelus;

    private Rigidbody2D rb;
    //private Animator angelusAnim;

    private float waitCounter, moveCounter;

    private Vector2 moveDir;

    [SerializeField, Tooltip("プレイヤーを追いかける判定")]
    private bool chase = true;

    [SerializeField]
    private bool isChaseing;

    [SerializeField, Tooltip("プレイヤー")]
    private Transform target;

    private Vector3 startPos;

    public float attackDamage;

    private int currentHealth;

    private bool blowFlag = false;

    [SerializeField, Tooltip("ドロップアイテム")]
    private GameObject drop;

    public AudioClip angelusTakendmg;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        startPos = gameObject.transform.position;

        audioSource = GetComponent<AudioSource>();

        //DataBase参照
        attackDamage = angelus.enemyOffensivePower;
        currentHealth = angelus.enemyMaxHp;

        waitCounter = angelus.enemyWaitTime;
    }

    void Update()
    {
        if (blowFlag)
        {
            rb.velocity *= 0.9f;
            if (rb.velocity.x <= 1f && rb.velocity.x >= -1f && rb.velocity.y <= 1f && rb.velocity.y >= -1f)
            {
                blowFlag = false;
            }
            return;
        }

        if (chase)
        {
            //プレイヤーを追いかけていないとき
            if (!isChaseing)
            {
                //動いていないとき
                if (waitCounter > 0)
                {
                    waitCounter -= Time.deltaTime;
                    rb.velocity = Vector2.zero;

                    if (waitCounter <= 0)
                    {
                        moveCounter = angelus.enemyWalkTime;

                        moveDir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));

                        if (moveDir.x <= 0)
                        {
                            transform.localScale = new Vector3(4f, transform.localScale.y, transform.localScale.z);  //右向き
                        }
                        else
                        {
                            transform.localScale = new Vector3(-4f, transform.localScale.y, transform.localScale.z);  //左向き
                        }

                        moveDir.Normalize();
                    }
                }
                //動いているとき
                else
                {
                    moveCounter -= Time.deltaTime;

                    rb.velocity = moveDir * angelus.enemyMoveSpeed;

                    if (moveCounter <= 0)
                    {
                        waitCounter = angelus.enemyWaitTime;
                    }
                }

                if (chase)
                {
                    if (Vector3.Distance(transform.position, target.transform.position) < angelus.enemyRangeToChase)
                    {
                        isChaseing = true;
                    }
                }
            }
            //プレイヤーを追いかけているとき
            else
            {
                if (waitCounter > 0)
                {
                    waitCounter -= Time.deltaTime;
                    rb.velocity = Vector2.zero;
                }
                else
                {
                    moveDir = target.transform.position - transform.position;
                    moveDir.Normalize();

                    rb.velocity = moveDir * angelus.enemyChaseSpeed;

                    if (moveDir.x <= 0)
                    {
                        transform.localScale = new Vector3(4f, transform.localScale.y, transform.localScale.z);  //右向き
                    }
                    else
                    {
                        transform.localScale = new Vector3(-4f, transform.localScale.y, transform.localScale.z);  //左向き
                    }
                }

                if (Vector3.Distance(transform.position, target.transform.position) > angelus.enemyRangeToChase)
                {
                    isChaseing = false;

                    waitCounter = angelus.enemyWaitTime;
                }
            }
        }

        //エリア外に行かないようにする

        float dist = Vector3.Distance(target.transform.position, startPos);
        if (dist > angelus.enemyAria)
        {
            chase = false;

            if (startPos.x - 1f <= gameObject.transform.position.x && startPos.x + 1f >= gameObject.transform.position.x && startPos.y - 1f <= gameObject.transform.position.y && startPos.y + 1f >= gameObject.transform.position.y)
            {
                rb.velocity = Vector2.zero;
            }
            else
            {
                moveDir = startPos - this.transform.position;
                moveDir.Normalize();

                rb.velocity = moveDir * angelus.enemyChaseSpeed;

                if (moveDir.x <= 0)
                {
                    transform.localScale = new Vector3(4f, transform.localScale.y, transform.localScale.z);  //右向き
                }
                else
                {
                    transform.localScale = new Vector3(-4f, transform.localScale.y, transform.localScale.z);  //左向き
                }
            }
        }
        else
        {
            chase = true;
        }
    }


    /// <summary>
    /// 攻撃関数
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            TakeDamage(GameData.playerdeffence);
            Debug.Log("アンゲルスが" + GameData.playerdeffence + "ダメージを受けた");
            audioSource.PlayOneShot(angelusTakendmg);
            Vector2 dir = transform.position - target.transform.position;
            dir.Normalize();
            rb.velocity = Vector2.zero;
            rb.AddForce(dir * angelus.enemyKnockBackPower, ForceMode2D.Impulse);
            blowFlag = true;
        }

        if (collision.gameObject.tag == "Player")
        {
            if (isChaseing)
            {
                //プレイヤーへのダメージなどのプログラムはここに
                Debug.Log("アンゲルスがプレイヤーにダメージ");

                waitCounter = angelus.enemyWaitAfterHitting;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            TakeDamage(GameData.playerdeffence);
            Debug.Log("アンゲルスが" + GameData.playerdeffence + "ダメージを受けた");
            audioSource.PlayOneShot(angelusTakendmg);
            Vector2 dir = transform.position - target.transform.position;
            dir.Normalize();
            rb.velocity = Vector2.zero;
            rb.AddForce(dir * angelus.enemyKnockBackPower, ForceMode2D.Impulse);
            blowFlag = true;
        }

        if (collision.gameObject.tag == "Player")
        {
            if (isChaseing)
            {
                //プレイヤーへのダメージなどのプログラムはここに
                Debug.Log("アンゲルスがプレイヤーにダメージ");

                waitCounter = angelus.enemyWaitAfterHitting;
            }
        }
    }

    /// <summary>
    /// ダメージを受けたときの関数
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        if (damage - angelus.enemyDefensePower <= 0)
        {
            currentHealth -= 1;
        }
        else
        {
            currentHealth -= damage - angelus.enemyDefensePower;
        }

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(drop, transform.position, Quaternion.identity);
            GameData.playerexp += angelus.enemyExp;
            Debug.Log("Angelusを倒した");
            Debug.Log(angelus.enemyExp + "の経験値を手に入れた");
        }
    }
}
