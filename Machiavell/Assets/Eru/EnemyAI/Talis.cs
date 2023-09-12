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

    [SerializeField, Tooltip("�v���C���[")]
    private Transform target;
    public int Health => _health;

    int _health = 10;

    private Vector2 moveDir;

    private Animator anim;

    private Rigidbody2D rb;

    private Vector3 startPos;

    private bool blowFlag = false;

    private bool flag = false;

    [SerializeField, Tooltip("�h���b�v�A�C�e��")]
    private GameObject drop;

    public AudioClip talisCrystalShot;
    public AudioClip talisCrystalTakendmg;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();

        startPos = gameObject.transform.position;

        //DataBase�Q��
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
        anim.SetBool("OP", false);      // ����

        // 1�b�ԑ҂�
        yield return new WaitForSeconds(1f);

        isDamage = false;

        anim.SetBool("Rotation", true); //��]���n�߂�

        isRotation = true;

        moveDir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        moveDir.Normalize();

        stopFlag = false;

        while (moveCounter >= 0)
        {
            moveCounter -= 1;

            rb.velocity = moveDir * talis.enemyMoveSpeed;

            // 1�b�ԑ҂�
            yield return new WaitForSeconds(1);
        }

        stopFlag = true;

        moveCounter = talis.enemyWalkTime;

        anim.SetBool("Rotation", false);    //��]���~�߂�

        isRotation = false;

        // 1�b�ԑ҂�
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
        anim.SetBool("OP", true);       //�J��

        // 0.5�b�ԑ҂�
        yield return new WaitForSeconds(0.5f);

        isDamage = true;

        // 0.5�b�ԑ҂�
        yield return new WaitForSeconds(0.5f);

        tstl.Shot();
        tstr.Shot();
        tsbl.Shot();
        tsbr.Shot();
        audioSource.PlayOneShot(talisCrystalShot);
        // 1�b�ԑ҂�
        yield return new WaitForSeconds(1f);

        anim.SetBool("OP", false);      // ����

        // 0.5�b�ԑ҂�
        yield return new WaitForSeconds(1f);

        isDamage = false;

        // 0.5�b�ԑ҂�
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

            //�G���A�O�ɍs���Ȃ��悤�ɂ���

            float dist = Vector3.Distance(target.transform.position, startPos);
            if (dist > talis.enemyAria)
            {
                anim.SetBool("OP", false);      // ����

                isDamage = false;

                anim.SetBool("Rotation", true); //��]���n�߂�
                isRotation = true;

                if (startPos.x - 1f <= gameObject.transform.position.x && startPos.x + 1f >= gameObject.transform.position.x && startPos.y - 1f <= gameObject.transform.position.y && startPos.y + 1f >= gameObject.transform.position.y)
                {
                    rb.velocity = Vector2.zero;

                    anim.SetBool("Rotation", false);    //��]���~�߂�
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
    /// �_���[�W���󂯂��Ƃ��̊֐�
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        if (isDamage)
        {
            if (damage <= 0)
            {
                _health -= 1;
                Debug.Log("�^�[���X��1�_���[�W���󂯂�");
            }
            else
            {
                _health -= damage;
                Debug.Log("�^�[���X��" + damage + "�_���[�W���󂯂�");
            }

            audioSource.PlayOneShot(talisCrystalTakendmg);
            Vector2 dir = transform.position - target.transform.position;
            dir.Normalize();

            rb.AddForce(dir * talis.enemyKnockBackPower, ForceMode2D.Impulse);
            blowFlag = true;
        }
        else Debug.Log("�^�[���X�̓_���[�W���󂯂Ȃ�����");

        if (_health <= 0)
        {
            Destroy(gameObject);
            Instantiate(drop, transform.position, Quaternion.identity);
            GameData.playerexp += talis.enemyExp;
            Debug.Log("Talis��|����");
            Debug.Log(talis.enemyExp + "�̌o���l����ɓ��ꂽ");
        }
    }
}
