using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playe : MonoBehaviour
{
    public Read readClass;
    public Save saveClass;

    float bukuiHP;
    public float maxHp;
    public float maxst;
    public float hp;
    public float stamina;
    public float DEF;
    public float ATK;
    public float LUCK;
    public float hpnow;
    public float Bock;

    public static int dameg1;

    int jump;

    [SerializeField]
    private bool blowFlag, blowFlag2;

    public float Dameg;

    public Image image;
    public Image image1;

    private Rigidbody2D rb2d;
    BoxCollider2D bc2d;

    private float x_val;
    private float speed;
    private float enemyATK;

    public static float kougeki;

    public float time;
    public int jumpcout = 0;
    public float inputSpeed;
    public float Maxspeed;
    public float Minspeed;
    public float jumpingPower;
    public float BockX1;
    public float BockY1;
    public float BockX2;
    public float BockY2;

    public static float stop = 0;
    private float enemyatk;

    //public GameObject graund;
    public GameObject damegi;
    public BossPlayer boss;
    private Transform enemy;

    //KeyCode rightcode;
    //KeyCode leftcode;
    //KeyCode jumpcode;
    //KeyCode dashcode;
    //KeyCode attackcode;
    //KeyCode menucode;
    Animator animator;    //�A�j���[�^�[
    AudioSource audioSource;
    public AudioClip hitDamage;
    public AudioClip behavior;

    //�ړ��X�s�[�h�Ɠ_�ł̊Ԋu
    [SerializeField] float flashInterval;
    //�_�ł�����Ƃ��̃��[�v�J�E���g
    [SerializeField] int loopCount;
    //�_�ł����邽�߂�SpriteRenderer
    SpriteRenderer sp;
    //�����������ǂ����̃t���O
    bool isHit;
    //�v���C���[�̏�ԗp�񋓌^�i�m�[�}���A�_���[�W�A���G��3��ށj
    enum STATE
    {
        NOMAL,
        DAMAGED,
        MUTEKI
    }
    //STATE�^�̕ϐ�
    STATE state;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        readClass.enabled = true;
        //GameDate���琔�l���󂯎��
        float HP;
        HP = GameData.playerhp;
        float ST;
        ST = GameData.playerstamina;
        float atk;
        atk = GameData.playeroffence;
        float def;
        def = GameData.playerdeffence;
        float luck;
        luck = GameData.playerluck;
        float HPNOW;
        HPNOW = GameData.playerhpnow;
        Debug.Log("HPNOW" + HPNOW);
        float buki;
        buki = GameData.soubi;
        float bukiHP;
        float bukiST;
        float bukiDEF;
        float bukiLUC;

        float weponHP;
        float weponST;
        float weponDEF;
        float weponLUC;

        if (buki == 1)
        {
            bukiHP = GameData.weaponHp[0];
            bukiST = GameData.weaponStamina[0];
            bukiDEF = GameData.weaponGuard[0];
            bukiLUC = GameData.weaponLuck[0];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 2)
        {
            bukiHP = GameData.weaponHp[1];
            bukiST = GameData.weaponStamina[1];
            bukiDEF = GameData.weaponGuard[1];
            bukiLUC = GameData.weaponLuck[1];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 3)
        {
            bukiHP = GameData.weaponHp[2];
            bukiST = GameData.weaponStamina[2];
            bukiDEF = GameData.weaponGuard[2];
            bukiLUC = GameData.weaponLuck[2];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 4)
        {
            bukiHP = GameData.weaponHp[3];
            bukiST = GameData.weaponStamina[3];
            bukiDEF = GameData.weaponGuard[3];
            bukiLUC = GameData.weaponLuck[3];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 5)
        {
            bukiHP = GameData.weaponHp[4];
            bukiST = GameData.weaponStamina[4];
            bukiDEF = GameData.weaponGuard[4];
            bukiLUC = GameData.weaponLuck[4];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 6)
        {
            bukiHP = GameData.weaponHp[5];
            bukiST = GameData.weaponStamina[5];
            bukiDEF = GameData.weaponGuard[5];
            bukiLUC = GameData.weaponLuck[5];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 7)
        {
            bukiHP = GameData.weaponHp[6];
            bukiST = GameData.weaponStamina[6];
            bukiDEF = GameData.weaponGuard[6];
            bukiLUC = GameData.weaponLuck[6];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 8)
        {
            bukiHP = GameData.weaponHp[7];
            bukiST = GameData.weaponStamina[7];
            bukiDEF = GameData.weaponGuard[7];
            bukiLUC = GameData.weaponLuck[7];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 9)
        {
            bukiHP = GameData.weaponHp[8];
            bukiST = GameData.weaponStamina[8];
            bukiDEF = GameData.weaponGuard[8];
            bukiLUC = GameData.weaponLuck[8];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }
        else if (buki == 10)
        {
            bukiHP = GameData.weaponHp[9];
            bukiST = GameData.weaponStamina[9];
            bukiDEF = GameData.weaponGuard[9];
            bukiLUC = GameData.weaponLuck[9];
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }

        maxHp = HP + bukuiHP;
        hp = HPNOW;

        //HP��ST�̌��ݒn���Q�Ƃ���
        //maxHp = HP;
        //hp = GameData.playerhpnow;
        //hp = HPNOW;
        //maxst = ST;
        stamina = maxst;
        ATK = atk;
        //DEF = def;
        //LUCK = luck;

        rb2d = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        bc2d = GetComponent<BoxCollider2D>();
        sp = GetComponent<SpriteRenderer>();
        //rightcode = GameData.rightkey;
        //leftcode = GameData.leftkey;
        //jumpcode = GameData.jumpkey;
        //dashcode = GameData.dashkey;
        //attackcode = GameData.attackkey;
        //menucode = GameData.healkey;
        Debug.Log("hpnow" + hp);
    }

    void Update()
    {
        image.fillAmount = hp / maxHp;

        if (blowFlag && blowFlag2)
        {
            rb2d.velocity *= 0.9f;
            if (rb2d.velocity.x <= 1f && rb2d.velocity.x >= -1f)
            {
                rb2d.velocity = Vector2.zero;
                blowFlag = false;
            }
        }
        else
        {
            if (Mathf.Approximately(Time.timeScale, 0f))
            {
                return;
            }
            if (!boss.Bossroom)
            {
                return;
            }
            //float jumpcount;
            //jumpcount = settihantei.jumpcout;

            if (Input.GetKeyDown(KeyCode.P))
            {
                GameData.playerhpnow = (int)hp;
                saveClass.enabled = true;
                readClass.enabled = true;
                Debug.Log("�Z�[�u���ł��܂���");
            }
            //A,D�������ꂽ�ꍇ
            if (Input.GetKey(GameData.rightkey) && blowFlag == false && stop == 0)
            {
                this.animator.ResetTrigger("attack");
                damegi.SetActive(false);
                //true�̂Ƃ��̂݃A�j���[�V�������Đ�����
                animator.SetBool("run", true);
                speed = inputSpeed;
                transform.localScale = new Vector3(2, 2, 2);
            }
            else if (Input.GetKey(GameData.leftkey) && blowFlag == false && stop == 0)
            {
                this.animator.ResetTrigger("attack");
                damegi.SetActive(false);
                animator.SetBool("run", true);
                speed = inputSpeed * -1;
                transform.localScale = new Vector3(-2, 2, 2);
            }
            else
            {
                //false�̂Ƃ��A�j���[�V������ύX����
                animator.SetBool("run", false);
                speed = 0;
            }

            if (stamina >= 10 && Input.GetKeyDown(GameData.dashkey) && time <= 0 && Input.GetKey(GameData.rightkey))
            {
                stop = 0;
                this.animator.ResetTrigger("attack");
                damegi.SetActive(false);
                time = 1;
                stamina += -10;
                //�Q�[�W������������
                image1.fillAmount = (float)stamina / (float)maxst;
                //image1.fillAmount -= 0.1f;
                StartCoroutine("SpeedUp");
            }
            else if (stamina >= 10 && Input.GetKeyDown(GameData.dashkey) && time <= 0 && Input.GetKey(GameData.leftkey))
            {
                stop = 0;
                this.animator.ResetTrigger("attack");
                damegi.SetActive(false);
                time = 1;
                stamina += -10;
                //�Q�[�W������������
                image1.fillAmount = (float)stamina / (float)maxst;
                //image1.fillAmount -= 0.1f;
                StartCoroutine("SpeedUp");
            }

            if (time >= 0)
            {
                time -= Time.deltaTime; //���b1�̎��Ԍ���
            }

            //Space�������ꂽ�ꍇ
            if (Input.GetKeyDown(GameData.jumpkey) && jumpcout < 2 && stop == 0)
            {
                this.animator.ResetTrigger("attack");
                damegi.SetActive(false);
                //�J�E���g��2�����̂Ƃ��̂݃W�����v���ł���
                //this.animator.SetTrigger("Jump up");
                jump = 1;
                Jump();
                jumpcout++; //��Ԃ��тɃJ�E���g��1���₷
            }

            if (rb2d.velocity.y > 0 && jump == 1)
            {
                this.animator.ResetTrigger("Ground");
                this.animator.SetTrigger("Jump up");
                Debug.Log("��");
            }
            else if (rb2d.velocity.y < 0 && jump == 1)
            {
                this.animator.ResetTrigger("Jump up");
                this.animator.SetTrigger("Jump Down");
                Debug.Log("��");
                jump = 0;
            }

            if (stamina <= maxst)
            {
                image1.fillAmount += Time.deltaTime / 100;
                stamina += Time.deltaTime; //���b�P�̃X�^�~�i��
            }

            if (this.rb2d.velocity.y == 0 && speed != 0)
            {
                animator.speed = Mathf.Abs(speed) / 2.0f;
            }
            else
            {
                this.animator.speed = 1.0f;
            }

            if (this.rb2d.velocity.y == 0 && speed == 0)
            {
                animator.speed = 2 / 2.0f;
            }
            else
            {
                this.animator.speed = 1.0f;
            }
            //Debug.Log("dameg1"+dameg1);
            if (Input.GetKeyDown(GameData.attackkey) && speed == 0 && jumpcout <= 0 && dameg1 == 0)
            {
                stop = 1;

                Debug.Log("attack");
                this.animator.SetTrigger("attack");
                StartCoroutine(Attack());
            }
        }
    }
    IEnumerator SpeedUp()
    {
        this.animator.ResetTrigger("Jump Down");
        this.animator.SetTrigger("kaihi");
        if (jumpcout >= 1)
        {
            //��莞�Ԃ������x���グ���G�ɂ���
            inputSpeed = (Input.GetKey(GameData.dashkey)) ? Maxspeed : Minspeed;
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionY;
            this.rb2d.freezeRotation = true;
            gameObject.layer = LayerMask.NameToLayer("Player");
            yield return new WaitForSeconds(0.5f); //0.5�b��ɏ���������
            this.rb2d.constraints = RigidbodyConstraints2D.None;
            this.rb2d.freezeRotation = true;
            inputSpeed = Minspeed;
            gameObject.layer = LayerMask.NameToLayer("Collision");
        }

        if (jumpcout == 0)
        {
            //��莞�Ԃ������x���グ���G�ɂ���
            inputSpeed = (Input.GetKey(GameData.dashkey)) ? Maxspeed : Minspeed;
            gameObject.layer = LayerMask.NameToLayer("Player");
            yield return new WaitForSeconds(0.5f); //0.5�b��ɏ���������
            inputSpeed = Minspeed;
            gameObject.layer = LayerMask.NameToLayer("Collision");
        }
    }
    IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.5f); //0.5�b��ɏ���������
        damegi.SetActive(true);
        this.tag = "Attack";
        audioSource.PlayOneShot(behavior);
        yield return new WaitForSeconds(0.8f); //0.8�b��ɏ���������
        this.tag = "Player";
        damegi.SetActive(false);
        stop = 0;
    }

    void FixedUpdate()
    {
        // �L�����N�^�[���ړ� Vextor2(x���X�s�[�h�Ay���X�s�[�h(���̂܂�))
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }

    void Jump()
    {
        //this.animator.SetTrigger("Jump Triger");
        //rb2d.AddForce(Vector2.up * jumpingPower); //�W�����v�͂̔���
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpingPower);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("grand"))
        {
            //�W�����v���Ē��n������A�j���[�V�������I���
            Debug.Log("banana");
            this.animator.SetTrigger("Ground");
            //jumpcout = 0;�@//�n�ʂɐG�ꂽ��l��0�ɖ߂�
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
            Debug.Log("�Փ�");
            //Hit���Ă����珈�����s��Ȃ�
            if (isHit)
            {
                return;
            }

            enemy = collision.gameObject.transform;

            //�R���[�`�����J�n
            StartCoroutine(_hit());

            speed = 0;
            damegi.SetActive(false);
            this.animator.SetTrigger("dameg");

            if (collision.gameObject.tag == "Angelus")
            {
                enemyatk = collision.gameObject.GetComponent<Angelus>().attackDamage;
            }
            else if (collision.gameObject.tag == "Crystal")
            {
                enemyatk = 1f;
            }

            if (enemyatk >= DEF) { enemyatk -= DEF; hp -= enemyatk; }
            else if (enemyatk <= DEF) { hp -= 1; }
            Debug.Log(enemyatk);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
            Debug.Log("�ђ�");
            //Hit���Ă����珈�����s��Ȃ�
            if (isHit)
            {
                return;
            }

            enemy = collision.gameObject.transform;

            //�R���[�`�����J�n
            StartCoroutine(_hit());

            speed = 0;
            damegi.SetActive(false);
            this.animator.SetTrigger("dameg");


            if (collision.gameObject.tag == "Laser")
            {
                enemyatk = collision.gameObject.GetComponent<BlueCrystalLaser>().attackDamage;
            }
            else if (collision.gameObject.tag == "RedBlast")
            {
                enemyatk = collision.gameObject.GetComponent<RedCrystalBlast>().attackDamage;
            }
            else if (collision.gameObject.tag == "SumBeam")
            {
                enemyatk = collision.gameObject.GetComponent<SumBeam>().attackDamage;
            }
            else if (collision.gameObject.tag == "TalisBlast")
            {
                enemyatk = collision.gameObject.GetComponent<TalisBlast>().attackDamage;
            }

            if (enemyatk >= DEF) { enemyatk -= DEF; hp -= enemyatk; }
            else if (enemyatk <= DEF) { hp -= 1; }
            Debug.Log(enemyatk);
        }
    }

    //�_�ł����鏈��
    IEnumerator _hit()
    {
        stop = 0;
        blowFlag2 = false;
        this.animator.ResetTrigger("attack");
        this.animator.SetTrigger("dameg");
        damegi.SetActive(false);

        audioSource.PlayOneShot(hitDamage);

        dameg1 = 1;
        Debug.Log("bock");

        Vector2 dir = transform.position - enemy.position;

        dir.Normalize();
        Debug.Log(dir);

        if (dir.x < 0)
        {
            transform.localScale = new Vector3(2, 2, 2);
            rb2d.velocity = Vector2.zero;
            Vector2 naname = new Vector2(BockX1, BockY1);
            rb2d.AddForce(naname * Bock);
            blowFlag = true;
        }
        else
        {
            transform.localScale = new Vector3(-2, 2, 2);
            rb2d.velocity = Vector2.zero;
            Vector2 naname = new Vector2(BockX2, BockY2);
            rb2d.AddForce(naname * Bock);
            blowFlag = true;
        }

        //�Q�[�W������������
        image.fillAmount = hp / maxHp;
        Dameg = 0;

        gameObject.layer = LayerMask.NameToLayer("Player");
        //������t���O��true�ɕύX�i�������Ă����ԁj
        isHit = true;

        //�_�Ń��[�v�J�n
        for (int i = 0; i < loopCount; i++)
        {
            //flashInterval�҂��Ă���
            yield return new WaitForSeconds(flashInterval);
            //spriteRenderer���I�t
            sp.enabled = false;

            //flashInterval�҂��Ă���
            yield return new WaitForSeconds(flashInterval);
            //spriteRenderer���I��
            sp.enabled = true;
        }
        gameObject.layer = LayerMask.NameToLayer("Collision");
        //�_�Ń��[�v���������瓖����t���O��false(�������ĂȂ����)
        isHit = false;
        yield return new WaitForSeconds(0.1f); //0.1�b��ɏ���������
        blowFlag2 = true;
        dameg1 = 0;
    }
}