using UnityEngine;

public class RedCrystal : MonoBehaviour,IDamageable
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy redCrystal;

    private bool isChaseing;

    private float waitCounter;

    [SerializeField, Tooltip("�v���C���[")]
    private Transform target;

    private Vector2 dir;

    public AudioClip talisCrystalTakendmg;
    public AudioClip talisCrystalShot;
    AudioSource audioSource;

    [SerializeField]
    private GameObject blast;

    [SerializeField, Tooltip("�h���b�v�A�C�e��")]
    private GameObject drop;
    public int Health => _health;

    int _health = 10;

    void Start()
    {
        //DataBase�Q��
        _health = redCrystal.enemyMaxHp;

        waitCounter = 0;

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //�v���C���[���߂��ɂ��Ȃ��Ƃ�
        if (!isChaseing)
        {
            if (Vector3.Distance(transform.position, target.transform.position) < redCrystal.enemyRangeToChase)
            {
                isChaseing = true;
            }
        }
        //�v���C���[���߂��ɂ���Ƃ�
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
    /// �U���֐�
    /// </summary>
    public void Shot()
    {
        Instantiate(blast, transform.position, Quaternion.FromToRotation(Vector2.up, dir));
        audioSource.PlayOneShot(talisCrystalShot);
    }

    /// <summary>
    /// �_���[�W���󂯂��Ƃ��̊֐�
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
            Debug.Log("RedCrystal��|����");
            Debug.Log(redCrystal.enemyExp + "�̌o���l����ɓ��ꂽ");
        }
    }
}
