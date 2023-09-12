using UnityEngine;

public class BlueCrystal : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy blueCrystal;

    [SerializeField]
    private bool isChaseing;

    private float waitCounter;

    [SerializeField, Tooltip("プレイヤー")]
    private Transform target;

    public int Health => _health;

    int _health = 10;

    private Vector2 dir;

    [SerializeField]
    private GameObject laser;

    [SerializeField, Tooltip("ドロップアイテム")]
    private GameObject drop;

    public AudioClip talisCrystalShot;
    public AudioClip talisCrystalTakendmg;
    AudioSource audioSource;

    void Start()
    {
        //DataBase参照
        _health = blueCrystal.enemyMaxHp;

        waitCounter = 0;

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //プレイヤーが近くにいないとき
        if (!isChaseing)
        {
            if (Vector3.Distance(transform.position, target.transform.position) < blueCrystal.enemyRangeToChase)
            {
                isChaseing = true;
            }
        }
        //プレイヤーが近くにいるとき
        else
        {
            if(waitCounter > 0)
            {
                waitCounter -= Time.deltaTime;
            }
            else
            {
                Shot();

                isChaseing = false;
                waitCounter = blueCrystal.enemyWaitTime;
            }
        }
    }

    /// <summary>
    /// 攻撃関数
    /// </summary>
    public void Shot()
    {
        audioSource.PlayOneShot(talisCrystalShot);
        dir = target.transform.position - transform.position;
        dir.Normalize();

        GameObject ler = (GameObject)Instantiate(laser, transform.position, Quaternion.FromToRotation(Vector2.up, dir));
        Rigidbody2D lrb = ler.GetComponent<Rigidbody2D>();
        lrb.velocity = dir * blueCrystal.enemyMoveSpeed;
    }

    /// <summary>
    /// ダメージを受けたときの関数
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        if (damage - blueCrystal.enemyDefensePower <= 0) _health -= 1;
        else _health -= damage - blueCrystal.enemyDefensePower;
        audioSource.PlayOneShot(talisCrystalTakendmg);

        if (_health <= 0)
        {
            Destroy(gameObject);
            Instantiate(drop, transform.position, Quaternion.identity);
            GameData.playerexp += blueCrystal.enemyExp;
            Debug.Log("BlueCrystalを倒した");
            Debug.Log(blueCrystal.enemyExp + "の経験値を手に入れた");
        }
    }
}
