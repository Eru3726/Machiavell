using System.Collections;
using UnityEngine;

public class Talis : MonoBehaviour, IDamageable
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy talis;

    [SerializeField, Tooltip("TalisShot")]
    private TalisShot tstl, tstr, tsbl, tsbr;

    private bool isRotation,stopFlag;

    [SerializeField]
    private bool isDamage;

    private Transform myTransform;

    private float moveCounter;

    [SerializeField, Tooltip("プレイヤー")]
    private Transform target;
    public int Health => _health;

    int _health = 10;

    private Vector2 moveDir;

    private Animator anim;

    private Rigidbody2D rb;

    private Vector3 startPos;

    private bool blowFlag = false;

    private bool flag = false;

    [SerializeField, Tooltip("ドロップアイテム")]
    private GameObject drop;

    public AudioClip talisCrystalShot;
    public AudioClip talisCrystalTakendmg;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();

        startPos = gameObject.transform.position;

        //DataBase参照
        _health = talis.enemyMaxHp;

        moveCounter = talis.enemyWalkTime;
        isDamage = false;
        isRotation = false;
        stopFlag = true;

        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private IEnumerator Pattern1()
    {
        anim.SetBool("OP", false);      // 閉じる

        // 1秒間待つ
        yield return new WaitForSeconds(1f);

        isDamage = false;

        anim.SetBool("Rotation", true); //回転を始める

        isRotation = true;

        moveDir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        moveDir.Normalize();

        stopFlag = false;

        while (moveCounter >= 0)
        {
            moveCounter -= 1;

            rb.velocity = moveDir * talis.enemyMoveSpeed;

            // 1秒間待つ
            yield return new WaitForSeconds(1);
        }

        stopFlag = true;

        moveCounter = talis.enemyWalkTime;

        anim.SetBool("Rotation", false);    //回転を止める

        isRotation = false;

        // 1秒間待つ
        yield return new WaitForSeconds(1);

        if (Vector3.Distance(transform.position, target.transform.position) < talis.enemyRangeToChase)
        {
            StartCoroutine(Pattern2());
        }
        else
        {
            flag = false;
        }
    }


    private IEnumerator Pattern2()
    {
        anim.SetBool("OP", true);       //開く

        // 0.5秒間待つ
        yield return new WaitForSeconds(0.5f);

        isDamage = true;

        // 0.5秒間待つ
        yield return new WaitForSeconds(0.5f);

        tstl.Shot();
        tstr.Shot();
        tsbl.Shot();
        tsbr.Shot();
        audioSource.PlayOneShot(talisCrystalShot);
        // 1秒間待つ
        yield return new WaitForSeconds(1f);

        anim.SetBool("OP", false);      // 閉じる

        // 0.5秒間待つ
        yield return new WaitForSeconds(1f);

        isDamage = false;

        // 0.5秒間待つ
        yield return new WaitForSeconds(0.5f);

        flag = false;
    }

    void Update()
    {
        if (isRotation)
        {
            myTransform.Rotate(myTransform.rotation.x, myTransform.rotation.y, Random.Range(5, 11));
        }

        if (blowFlag)
        {
            rb.velocity *= 0.9f;
            if (rb.velocity.x <= 1f && rb.velocity.x >= -1f && rb.velocity.y <= 1f && rb.velocity.y >= -1f)
            {
                rb.velocity = Vector2.zero;
                blowFlag = false;
            }
        }
        else
        {
            if (stopFlag)
            {
                rb.velocity = Vector2.zero;
            }

            //エリア外に行かないようにする

            float dist = Vector3.Distance(target.transform.position, startPos);
            if (dist > talis.enemyAria)
            {
                anim.SetBool("OP", false);      // 閉じる

                isDamage = false;

                anim.SetBool("Rotation", true); //回転を始める
                isRotation = true;

                if (startPos.x - 1f <= gameObject.transform.position.x && startPos.x + 1f >= gameObject.transform.position.x && startPos.y - 1f <= gameObject.transform.position.y && startPos.y + 1f >= gameObject.transform.position.y)
                {
                    rb.velocity = Vector2.zero;

                    anim.SetBool("Rotation", false);    //回転を止める
                    isRotation = false;
                }
                else
                {
                    moveDir = startPos - this.transform.position;
                    moveDir.Normalize();

                    rb.velocity = moveDir * talis.enemyMoveSpeed;
                }
            }
            else if(!flag)
            {
                flag = true;
                StartCoroutine(Pattern1());
            }
        }
    }

    /// <summary>
    /// ダメージを受けたときの関数
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        if (isDamage)
        {
            if (damage <= 0)
            {
                _health -= 1;
                Debug.Log("ターリスが1ダメージを受けた");
            }
            else
            {
                _health -= damage;
                Debug.Log("ターリスが" + damage + "ダメージを受けた");
            }

            audioSource.PlayOneShot(talisCrystalTakendmg);
            Vector2 dir = transform.position - target.transform.position;
            dir.Normalize();

            rb.AddForce(dir * talis.enemyKnockBackPower, ForceMode2D.Impulse);
            blowFlag = true;
        }
        else Debug.Log("ターリスはダメージを受けなかった");

        if (_health <= 0)
        {
            Destroy(gameObject);
            Instantiate(drop, transform.position, Quaternion.identity);
            GameData.playerexp += talis.enemyExp;
            Debug.Log("Talisを倒した");
            Debug.Log(talis.enemyExp + "の経験値を手に入れた");
        }
    }
}
