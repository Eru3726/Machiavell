using UnityEngine;

public class RedCrystal : MonoBehaviour,IDamageable
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy redCrystal;

    private bool isChaseing;

    private float waitCounter;

    [SerializeField, Tooltip("プレイヤー")]
    private Transform target;

    private Vector2 dir;

    public AudioClip talisCrystalTakendmg;
    public AudioClip talisCrystalShot;
    AudioSource audioSource;

    [SerializeField]
    private GameObject blast;

    [SerializeField, Tooltip("ドロップアイテム")]
    private GameObject drop;
    public int Health => _health;

    int _health = 10;

    void Start()
    {
        //DataBase参照
        _health = redCrystal.enemyMaxHp;

        waitCounter = 0;

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //プレイヤーが近くにいないとき
        if (!isChaseing)
        {
            if (Vector3.Distance(transform.position, target.transform.position) < redCrystal.enemyRangeToChase)
            {
                isChaseing = true;
            }
        }
        //プレイヤーが近くにいるとき
        else
        {
            if (waitCounter > 0)
            {
                waitCounter -= Time.deltaTime;
            }
            else
            {
                Shot();

                isChaseing = false;
                waitCounter = redCrystal.enemyWaitTime;
            }
        }
    }

    /// <summary>
    /// 攻撃関数
    /// </summary>
    public void Shot()
    {
        Instantiate(blast, transform.position, Quaternion.FromToRotation(Vector2.up, dir));
        audioSource.PlayOneShot(talisCrystalShot);
    }

    /// <summary>
    /// ダメージを受けたときの関数
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        if (damage - redCrystal.enemyDefensePower <= 0) _health -= 1;
        else _health -= damage - redCrystal.enemyDefensePower;
        audioSource.PlayOneShot(talisCrystalTakendmg);

        if (_health <= 0)
        {
            Destroy(gameObject);
            Instantiate(drop, transform.position, Quaternion.identity);
            GameData.playerexp += redCrystal.enemyExp;
            Debug.Log("RedCrystalを倒した");
            Debug.Log(redCrystal.enemyExp + "の経験値を手に入れた");
        }
    }
}
