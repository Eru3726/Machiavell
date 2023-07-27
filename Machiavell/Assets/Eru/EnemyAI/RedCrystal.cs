using UnityEngine;

public class RedCrystal : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy redCrystal;

    private bool isChaseing;

    private float waitCounter;

    [SerializeField, Tooltip("プレイヤー")]
    private Transform target;

    private int currentHealth;

    private Vector2 dir;

    public AudioClip talisCrystalTakendmg;
    public AudioClip talisCrystalShot;
    AudioSource audioSource;

    [SerializeField]
    private GameObject blast;

    [SerializeField, Tooltip("ドロップアイテム")]
    private GameObject drop;

    void Start()
    {
        //DataBase参照
        currentHealth = redCrystal.enemyMaxHp;

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
    /// ダメージ判定
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            audioSource.PlayOneShot(talisCrystalTakendmg);
            TakeDamage(GameData.playeroffence);
            Debug.Log("レッドクリスタルが" + GameData.playerdeffence + "ダメージを受けた");
        }
    }

    /// <summary>
    /// ダメージを受けたときの関数
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        if (damage - redCrystal.enemyDefensePower <= 0)
        {
            currentHealth -= 1;
        }
        else
        {
            currentHealth -= damage - redCrystal.enemyDefensePower;
        }

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(drop, transform.position, Quaternion.identity);
            GameData.playerexp += redCrystal.enemyExp;
            Debug.Log("RedCrystalを倒した");
            Debug.Log(redCrystal.enemyExp + "の経験値を手に入れた");
        }
    }
}
