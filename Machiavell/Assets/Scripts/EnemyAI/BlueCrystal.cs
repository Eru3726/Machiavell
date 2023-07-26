using UnityEngine;

public class BlueCrystal : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy blueCrystal;

    [SerializeField]
    private bool isChaseing;

    private float waitCounter;

    [SerializeField, Tooltip("�v���C���[")]
    private Transform target;

    private int currentHealth;

    private Vector2 dir;

    [SerializeField]
    private GameObject laser;

    [SerializeField, Tooltip("�h���b�v�A�C�e��")]
    private GameObject drop;

    public AudioClip talisCrystalShot;
    public AudioClip talisCrystalTakendmg;
    AudioSource audioSource;

    void Start()
    {
        //DataBase�Q��
        currentHealth = blueCrystal.enemyMaxHp;

        waitCounter = 0;

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //�v���C���[���߂��ɂ��Ȃ��Ƃ�
        if (!isChaseing)
        {
            if (Vector3.Distance(transform.position, target.transform.position) < blueCrystal.enemyRangeToChase)
            {
                isChaseing = true;
            }
        }
        //�v���C���[���߂��ɂ���Ƃ�
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
    /// �U���֐�
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
    /// �_���[�W����
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            audioSource.PlayOneShot(talisCrystalTakendmg);
            TakeDamage(GameData.playeroffence);
            Debug.Log("�u���[�N���X�^����" + GameData.playerdeffence + "�_���[�W���󂯂�");
        }
    }

    /// <summary>
    /// �_���[�W���󂯂��Ƃ��̊֐�
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        if (damage - blueCrystal.enemyDefensePower <= 0)
        {
            currentHealth -= 1;
        }
        else
        {
            currentHealth -= damage - blueCrystal.enemyDefensePower;
        }

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(drop, transform.position, Quaternion.identity);
            GameData.playerexp += blueCrystal.enemyExp;
            Debug.Log("BlueCrystal��|����");
            Debug.Log(blueCrystal.enemyExp + "�̌o���l����ɓ��ꂽ");
        }
    }
}
