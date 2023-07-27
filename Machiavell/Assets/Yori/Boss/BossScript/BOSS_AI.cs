using Cinemachine;
using System.Collections;
using UnityEngine;

public class BOSS_AI : MonoBehaviour
{
    // �ϐ�
    [SerializeField, Header("�s���ԍ�")]
    public int actNo = 0;      // �s���ԍ�
    [SerializeField, Header("���\�b�h�p�ėp�ԍ�")]
    public int methodNo = 0;   // ���\�b�h�p�ėp�ԍ�

    [SerializeField, Header("�o��ҋ@")]
    private float appWait = 6;

    [SerializeField, Header("�e���|�[�g����܂ł̎���")]
    private float teleAppWait = 3;

    [SerializeField, Header("�����ҋ@")]
    private float summonWait = 6;

    [SerializeField, Header("�r�[�����ˑҋ@")]
    private float beamShotWait = 3;

    [SerializeField, Header("�r�[���ҋ@")]
    private float beamWait = 5;

    [SerializeField, Header("�^�b�N���ҋ@")]
    private float tackleWait = 3;

    [SerializeField, Header("�^�b�N���\������")]
    private float tacklePWait = 3;

    [SerializeField, Header("���̃^�b�N���܂ł̎���")]
    private float nextTackleWait = 0.5f;

    [SerializeField, Header("�����O�ҋ@")]
    private float waveWait = 5;

    [SerializeField, Header("�����O���ˑҋ@")]
    private float waveShotWait = 7;

    [SerializeField, Header("�g��U���̌�")]
    private float waveChance = 4;

    [SerializeField, Header("�_�̏�ҋ@")]
    private float lodWait = 5;

    [SerializeField, Header("�e���|�[�g�ҋ@")]
    private float teleportWait = 5;

    [SerializeField, Header("�e���|�[�g�I���ҋ@")]
    private float teleportEndWait = 5;

    [SerializeField, Header("�������a")]
    private float r;

    [SerializeField, Header("�^�b�N���̃X�s�[�h")]
    private float tackleSpeed = 2;

    [SerializeField, Header("Algens_summon")]
    private GameObject algens_summon;

    [SerializeField, Header("�h���b�v�A�C�e��")]
    private GameObject drop;

    [SerializeField, Header("�_�ł�����")]
    private GameObject warning;

    [SerializeField, Header("�r�[��Pre")]
    GameObject Beam;

    [SerializeField, Header("�����Pre")]
    GameObject waveRing;

    [SerializeField, Header("�_�̏�Pre")]
    GameObject lod;

    [SerializeField, Header("�_�̏�\����Pre")]
    GameObject Plinelod;

    [SerializeField, Header("DataBase")]
    private Enemy Archange;
    public float attackDamage;

    public AudioClip archangeTakendmgSE;
    public AudioClip archangeTeleportSE;
    public AudioClip archangeTackleSE;
    public AudioClip archangeBeamShotSE;
    AudioSource audioSource;

    [SerializeField, Header("BigMask")]
    GameObject bigMask;
    public Vector2 bMfirst;

    [SerializeField, Header("EyeMask")]
    public GameObject eyeMask;
    public Vector2 eMfirst;

    [SerializeField, Header("�{�X�̖h�䔻��1")]
    public CircleCollider2D defColi1;
    [SerializeField, Header("�{�X�̖h�䔻��I�u�W�F�N�g1")]
    public GameObject defobj1;
    [SerializeField, Header("�{�X�̖h�䔻��2")]
    public CircleCollider2D defColi2;
    [SerializeField, Header("�{�X�̖h�䔻��I�u�W�F�N�g2")]
    public GameObject defobj2;

    [SerializeField, Header("�p�[�e�B�N��")]
    Parthikuru particle;

    [SerializeField, Header("�_�̏�̎��̃t�F�C�h")]
    CanvasGroup fadeLod;

    [SerializeField, Header("�U�����ꂽ���̗h��")]
    Shaking shake;

    [SerializeField, Header("���ʉ��o�̎���")]
    private float dieTime;

    [SerializeField, Header("���ʂƂ��̂��ӂ�����")]
    GameObject dieEffect;

    [SerializeField, Header("�{�X�̖ڂ��")]
    GameObject bossEye;

    private int currentHealth;

    // �^�b�N������ۂ̃^�[�Q�b�g������z
    GameObject target;
    private int count;

    //�e�I�u�W�F�N�g
    private GameObject parent;
    //�q�I�u�W�F�N�g
    private GameObject child;

    // �������鐔
    public int summonNum = 5;

    public GameObject camer;

    // �E�ɂ��邩���Ȃ����m�F
    public bool rightFlg = false;
    public bool midFlg = false;
    // �^�b�N���������̊m�F
    public bool tackleFlg = false;

    bool hitFlag = true;

    // �I�t�g���̃t���O
    public bool waveFlg = false;

    // ���񂾂Ƃ��̃t���O
    public bool dieFlg = false;

    private CircleCollider2D circleCol;

    private Vector2 pos;
    private Vector2 scalePos;

    // �{�X�̍��E�̃|�W�V����
    private float LRx = 16;
    private float LRy = -0.2f;

    private float cameraSize = 12;
    CinemachineVirtualCamera cinem;

    Rigidbody2D rb;
    // �񋓑́F�s���ԍ�
    enum ActNo
    {
        App,        // �o��
        Summon,     // ����
        Beam,       // �r�[��
        Tackle,     // �^�b�N��
        Wave,       // off�g��
        Godlod,    // �_�̏�
        Die,        // ���S
        //Wait,       // �ҋ@
        Teleport,   // �ړ�
        Num         // ����
    }

    // �f���Q�[�h
    // �֐����^�ɂ��邽�߂̂���
    private delegate void ActFunc();
    // �֐��̔z��
    private ActFunc[] actFuncTbl;

    // HP��������
    private bool halfHp = false;

    // HP���l���̈ꂩ
    private bool quarterHp = false;

    public bool beamReady = false;
    public bool beamEnd = false;
    public bool tpStart = false;
    public bool tpEnd = false;
    private bool seFlg = false;

    float timer0 = 0;                   // �ėp�^�C�}�[
    int rand;                           // ����

    void Start()
    {
        // �֐��z����m��
        actFuncTbl = new ActFunc[(int)ActNo.Num];
        actFuncTbl[(int)ActNo.App] = ActApp;
        actFuncTbl[(int)ActNo.Summon] = ActSummon;
        actFuncTbl[(int)ActNo.Beam] = ActBeam;
        actFuncTbl[(int)ActNo.Tackle] = ActTackle;
        actFuncTbl[(int)ActNo.Wave] = ActWave;
        actFuncTbl[(int)ActNo.Godlod] = ActGodlod;
        actFuncTbl[(int)ActNo.Die] = ActDie;
        //actFuncTbl[(int)ActNo.Wait] = ActWait;
        actFuncTbl[(int)ActNo.Teleport] = ActTeleport;

        // �o�ꂩ��X�^�[�g����
        actNo = (int)ActNo.App;

        //�J�����̏����擾����
        cinem = camer.GetComponent<CinemachineVirtualCamera>();

        currentHealth = Archange.enemyMaxHp;
        attackDamage = Archange.enemyOffensivePower;

        audioSource = GetComponent<AudioSource>();

        target = GameObject.Find("player");

        bMfirst = bigMask.transform.localScale;
        eMfirst = eyeMask.transform.localScale;

        circleCol = GetComponent<CircleCollider2D>();
        defColi1 = defobj1.GetComponent<CircleCollider2D>();
        defColi2 = defobj2.GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �֐��z���p�����֐��̌Ăяo��
        actFuncTbl[actNo]();

        if (currentHealth <= Archange.enemyMaxHp / 2)
        {
            if (!halfHp)
            {
                fadeLod.alpha = 0;
                Debug.Log(currentHealth);
                methodNo = 0;
                actNo = 1;
                halfHp = true;
            }
        }

        if (currentHealth <= Archange.enemyMaxHp / 4)
        {
            if (!quarterHp)
            {
                fadeLod.alpha = 0;
                methodNo = 0;
                actNo = 4;
                quarterHp = true;
            }
        }
    }

    // �o��
    void ActApp()
    {
        // ���\�b�h�ԍ����g���������̕���
        switch (methodNo)
        {
            case 0:
                // �o�ꏈ��������
                Debug.Log("�o��");
                circleCol.enabled = false;
                timer0 = appWait;
                //timer0 = 3; // �^�C�}�[�ݒ�

                ++methodNo; // ���̏�����
                break;
            case 1:
                // �^�C�}�[�҂�����
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    if (cinem.m_Lens.OrthographicSize >= cameraSize)
                    {
                        cinem.m_Lens.OrthographicSize -= 0.2f;
                    }
                    else
                    {
                        cinem.m_Lens.OrthographicSize = 12;
                        timer0 = teleAppWait;
                        methodNo++;  // ���\�b�h�ԍ���0��
                    }
                }
                break;
            case 2:
                // �^�C�}�[�҂�����
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    actNo = (int)ActNo.Teleport;
                    methodNo = 0;   // ���\�b�h�ԍ���0��
                }
                break;
        }
    }
    // �G������
    void ActSummon()
    {
        // ���\�b�h�ԍ����g���������̕���
        switch (methodNo)
        {
            case 0:
                // ��������������
                Debug.Log("����");
                timer0 = summonWait;
                ++methodNo; // ���̏�����
                break;
            case 1:
                // ��������
                if (halfHp)
                {
                    if (summonNum == 5)
                    {
                        StartCoroutine(Summon());
                        methodNo++;
                    }
                }
                else
                {
                    actNo = (int)ActNo.Godlod; // �_�̏񏈗���
                    methodNo = 0;            // ���\�b�h�ԍ���0��
                }
                break;
            case 2:
                //����������
                break;
            case 3:
                // �^�C�}�[�҂�����
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {

                    rand = Random.Range(1, 10);
                    if (rand >= 6)
                    {
                        actNo = (int)ActNo.Tackle; // �^�b�N��������
                        methodNo = 0;   // ���\�b�h�ԍ���0��

                    }
                    else
                    {
                        actNo = (int)ActNo.Beam; // �r�[��������
                        methodNo = 0;            // ���\�b�h�ԍ���0��
                    }
                }

                break;
        }
    }
    // �r�[��
    void ActBeam()
    {
        // ���\�b�h�ԍ����g���������̕���
        switch (methodNo)
        {
            case 0:
                beamReady = true;
                // �r�[������������
                Debug.Log("�r�[��");
                timer0 = beamShotWait;
                //timer0 = 3; // �^�C�}�[�ݒ�
                ++methodNo; // ���̏�����
                break;
            case 1:
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    if (midFlg)
                    {
                        if (rightFlg)
                        {
                            Instantiate(Beam, new Vector2(0, -2.6f), Quaternion.Euler(0, 0, 45));
                            audioSource.PlayOneShot(archangeBeamShotSE);
                        }
                        else
                        {
                            Instantiate(Beam, new Vector2(0, -2.6f), Quaternion.Euler(0, 0, 135));
                            audioSource.PlayOneShot(archangeBeamShotSE);
                        }
                    }
                    else if (rightFlg)
                    {
                        Instantiate(Beam, new Vector2(LRx, LRy - 2.6f), Quaternion.Euler(0, 0, 45));
                        audioSource.PlayOneShot(archangeBeamShotSE);
                    }
                    else
                    {
                        Instantiate(Beam, new Vector2(-LRx, LRy - 2.6f), Quaternion.Euler(0, 0, 135));
                        audioSource.PlayOneShot(archangeBeamShotSE);
                    }
                    methodNo++;
                    timer0 = beamWait;
                }
                break;
            case 2:
                // �r�[�������҂�
                break;
            case 3:
                // �^�C�}�[�҂�����
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    rand = Random.Range(1, 10);
                    if (rand >= 3)
                    {
                        actNo = (int)ActNo.Tackle; // �^�b�N��������
                        methodNo = 0;              // ���\�b�h�ԍ���0��

                    }
                    else if (rand <= 7)
                    {
                        actNo = (int)ActNo.Godlod; // �_�̏񏈗���
                        methodNo = 0;              // ���\�b�h�ԍ���0��
                    }
                    else
                    {
                        actNo = (int)ActNo.Wave;  //�g��������
                        methodNo = 0;             // ���\�b�h�ԍ���0��
                    }
                }
                break;
        }
    }
    // �^�b�N��
    void ActTackle()
    {
        // ���\�b�h�ԍ����g���������̕���
        switch (methodNo)
        {
            case 0:
                // �^�b�N������������
                Debug.Log("�^�b�N��");
                timer0 = tackleWait;
                tpStart = true;
                particle.tp = true;
                circleCol.enabled = false;
                defColi1.enabled = false;
                defColi2.enabled = false;
                audioSource.PlayOneShot(archangeTeleportSE);
                eyeMask.transform.localScale = new Vector2(0, 0);
                ++methodNo; // ���̏�����
                break;
            case 1:
                // �^�C�}�[�҂�����
                timer0 -= Time.deltaTime;
                if (!tpStart)
                {
                    Instantiate(warning, new Vector2(target.transform.position.x, target.transform.position.y), Quaternion.identity);
                    timer0 = tacklePWait;
                    particle.tp = true;
                    tpEnd = true;
                    ++methodNo; // ���̏�����
                }
                break;
            case 2:
                circleCol.enabled = true;
                if (rightFlg)
                {
                    pos = this.gameObject.transform.position;
                    pos.x = 45;
                    pos.y = target.transform.position.y;
                    this.gameObject.transform.position = pos;
                }
                else
                {
                    pos = this.gameObject.transform.position;
                    pos.x = -45;
                    pos.y = target.transform.position.y;
                    this.gameObject.transform.position = pos;
                }
                if (tackleFlg)
                {
                    ++count;
                    timer0 = nextTackleWait;
                    ++methodNo;
                    seFlg = true;
                }
                break;
            case 3:
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {

                    pos = this.transform.position;
                    if (rightFlg)
                    {
                        if (seFlg)
                        {
                            audioSource.PlayOneShot(archangeTackleSE);
                            seFlg = false;
                        }
                        pos = this.transform.position;
                        pos.x -= tackleSpeed;
                        this.transform.position = pos;

                        if (pos.x <= -45)
                        {
                            if (count >= 2)
                            {
                                ++methodNo;
                            }
                            else
                            {
                                methodNo = 0;
                            }
                            rightFlg = false;
                            tackleFlg = false;
                        }
                    }
                    else
                    {
                        if (seFlg)
                        {
                            audioSource.PlayOneShot(archangeTackleSE);
                            seFlg = false;
                        }
                        pos = this.transform.position;
                        pos.x += tackleSpeed;
                        this.transform.position = pos;

                        if (pos.x >= 45)
                        {
                            if (count >= 2)
                            {
                                ++methodNo;
                            }
                            else
                            {
                                methodNo = 0;
                            }
                            rightFlg = true;
                            tackleFlg = false;
                        }
                    }
                }
                break;
            case 4:
                defColi1.enabled = true;
                defColi2.enabled = true;
                count = 0;
                actNo = (int)ActNo.Teleport; // �ړ�������
                methodNo = 0;              // ���\�b�h�ԍ���0��
                break;
        }
    }
    // off�g��
    void ActWave()
    {
        // ���\�b�h�ԍ����g���������̕���
        switch (methodNo)
        {
            case 0:
                // off�g������������
                Debug.Log("off�g��");
                timer0 = waveShotWait;
                tpStart = true;
                particle.tp = true;
                circleCol.enabled = false;
                waveFlg = true;
                audioSource.PlayOneShot(archangeTeleportSE);
                eyeMask.transform.localScale = new Vector2(0, 0);
                ++methodNo; // ���̏�����
                break;
            case 1:
                if (!tpStart)
                {
                    pos = this.gameObject.transform.position;
                    pos.x = 0;
                    pos.y = 45;
                    this.gameObject.transform.position = pos;
                    ++methodNo; // ���̏�����
                }
                break;
            case 2:
                if (quarterHp)
                {
                    if (cinem.m_Lens.OrthographicSize <= 15)
                    {
                        cinem.m_Lens.OrthographicSize += 0.4f;
                    }
                    pos = this.gameObject.transform.position;
                    pos.x = 0;
                    pos.y = 0;
                    this.gameObject.transform.position = pos;
                    tpEnd = true;
                    particle.tp = true;
                    methodNo++;
                }

                else
                {
                    actNo = (int)ActNo.Teleport; // �ړ�������
                    methodNo = 0;   // ���\�b�h�ԍ���0��
                }
                break;
            case 3:
                if (!tpEnd)
                {
                    StartCoroutine("RingWave");
                    timer0 = waveWait;
                    ++methodNo;
                }
                break;
            case 4:
                timer0 -= Time.deltaTime;

                if (timer0 < 0)
                {
                    timer0 = waveChance;
                    ++methodNo;
                }
                break;
            case 5:
                if (cinem.m_Lens.OrthographicSize >= cameraSize)
                {
                    cinem.m_Lens.OrthographicSize -= 0.2f;
                }
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    waveFlg = true;
                    actNo = (int)ActNo.Teleport; // �ړ�������
                    methodNo = 0;   // ���\�b�h�ԍ���0��
                }
                break;
        }
    }
    // �_�̏�
    void ActGodlod()
    {
        switch (methodNo)
        {
            case 0:
                // �_�̏񏈗�������
                Debug.Log("�_�̏�");
                tpStart = true;
                particle.tp = true;
                audioSource.PlayOneShot(archangeTeleportSE);
                eyeMask.transform.localScale = new Vector2(0, 0);
                ++methodNo; // ���̏�����
                break;
            case 1:
                if (!tpStart)
                {
                    pos = this.gameObject.transform.position;
                    pos.x = 0;
                    pos.y = 45;
                    this.gameObject.transform.position = pos;
                    ++methodNo; // ���̏�����
                }
                break;
            case 2:
                pos = this.gameObject.transform.position;
                pos.x = 0;
                pos.y = 0;
                this.gameObject.transform.position = pos;
                tpEnd = true;
                particle.tp = true;
                methodNo++;
                break;
            case 3:
                // �_�̏񏈗�
                if (!tpEnd)
                {
                    StartCoroutine(createLod());
                    methodNo++;
                }
                break;
            case 4:
                // �����҂�
                break;
            case 5:
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    midFlg = true;
                    rand = Random.Range(1, 11);
                    if (rand >= 5)
                    {
                        actNo = (int)ActNo.Tackle; // �^�b�N��������
                        methodNo = 0;   // ���\�b�h�ԍ���0��

                    }
                    else
                    {
                        actNo = (int)ActNo.Beam; // �r�[��������
                        methodNo = 0;            // ���\�b�h�ԍ���0��
                    }
                }
                break;
        }
    }

    // �ҋ@
    //void ActWait()
    //{
    //    // ���\�b�h�ԍ����g���������̕���
    //    switch (methodNo)
    //    {
    //        case 0:
    //            //�ҋ@����������
    //            Debug.Log("�ҋ@");
    //            Camera came = GetComponent<Camera>();
    //            timer0 = 3; // �^�C�}�[�ݒ�
    //            ++methodNo; // ���̏�����
    //            break;
    //        case 1:

    //            if (temp.m_Lens.OrthographicSize>=9)
    //            {
    //                temp.m_Lens.OrthographicSize -= 0.2f;
    //            }
    //            // �^�C�}�[�҂�����
    //            timer0 -= Time.deltaTime;
    //            if (timer0 < 0)
    //            {
    //                timer0 -= Time.deltaTime;
    //                actNo = (int)ActNo.Teleport; // �ړ�������
    //                methodNo = 0;              // ���\�b�h�ԍ���0��
    //            }
    //            break;
    //    }
    //}

    void ActTeleport()�@// ���E�Ƀ����_���Ńe���|�[�g����
    {
        rand = Random.Range(1, 11);
        switch (methodNo)
        {
            case 0:
                Debug.Log("�e���|�[�g");
                tpStart = true;
                particle.tp = true;
                methodNo++;
                circleCol.enabled = false;
                midFlg = false;
                eyeMask.transform.localScale = new Vector2(0, 0);
                audioSource.PlayOneShot(archangeTeleportSE);
                break;
            case 1:
                if (!tpStart)
                {
                    pos = this.gameObject.transform.position;
                    pos.x = 0;
                    pos.y = 45;
                    this.gameObject.transform.position = pos;

                    rand = Random.Range(1, 11);
                    timer0 = teleportWait;
                    ++methodNo; // ���̏�����  
                }

                break;
            case 2:
                // �^�C�}�[�҂�����
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    if (rand >= 5)
                    {
                        // �E�Ƀe���|�[�g
                        pos = this.gameObject.transform.position;
                        pos.x = LRx;
                        pos.y = LRy;
                        this.gameObject.transform.position = pos;
                        rightFlg = true;
                        tpEnd = true;
                        particle.tp = true;
                        rand = Random.Range(1, 10);
                        timer0 = teleportEndWait;
                        methodNo++;
                    }
                    else
                    {
                        // ���Ƀe���|�[�g
                        pos = this.gameObject.transform.position;
                        pos.x = -LRx;
                        pos.y = LRy;
                        this.gameObject.transform.position = pos;
                        rightFlg = false;
                        tpEnd = true;
                        particle.tp = true;
                        rand = Random.Range(1, 7);
                        timer0 = teleportEndWait;
                        methodNo++;
                    }
                }
                break;
            case 3:
                if (!tpEnd)
                {
                    eyeMask.transform.localScale = eMfirst;
                    timer0 -= Time.deltaTime;
                    if (timer0 < 0)
                    {
                        circleCol.enabled = true;
                        if (rand >= 3)
                        {
                            actNo = (int)ActNo.Godlod; // �_�̏񏈗���
                            methodNo = 0;            // ���\�b�h�ԍ���0��
                        }
                        else if (rand <= 6)
                        {
                            actNo = (int)ActNo.Beam; // �r�[��������
                            methodNo = 0;            // ���\�b�h�ԍ���0��
                        }
                        else
                        {
                            actNo = (int)ActNo.Summon; // ����������
                            methodNo = 0;   // ���\�b�h�ԍ���0��
                        }
                    }
                }

                break;
        }
    }

    // ���S
    void ActDie()
    {

        switch (methodNo)
        {
            case 0:
                Debug.Log("���S");
                shake.Shake(1.5f, dieTime);
                timer0 = dieTime;
                methodNo++;
                dieFlg = true;
                Destroy(bossEye);
                break;
            case 1:
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    Instantiate(dieEffect, this.transform.position, Quaternion.identity);
                    methodNo++;
                }
                break;
            case 2:
                cinem.m_Lens.OrthographicSize = 12;
                Instantiate(drop, new Vector2(0, 0), Quaternion.identity);
                Destroy(gameObject);
                break;
        }
    }

    IEnumerator Summon()
    {

        for (int i = 0; i < 5; i++)
        {
            parent = GameObject.Find("Archange");
            child = (GameObject)Instantiate(algens_summon, new Vector2(parent.transform.position.x + r, 0), Quaternion.identity);
            child.transform.parent = parent.transform;
            summonNum--;

            yield return new WaitForSeconds(0.4f);
        }
        methodNo++;
        yield break;
    }
    IEnumerator RingWave()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(waveRing, new Vector2(0, 0), Quaternion.identity);

            yield return new WaitForSeconds(1.5f);
        }
        yield break;
    }

    IEnumerator createLod()
    {
        for (int i = 0; i < 4; i++)
        {
            int rand_ = Random.Range(-25, 26);
            Instantiate(Plinelod, new Vector2(rand_, 18), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
            Instantiate(lod, new Vector2(rand_, 18), Quaternion.identity);
            audioSource.PlayOneShot(archangeBeamShotSE);
            yield return new WaitForSeconds(0.4f);
        }
        Vector2 targetLod = target.transform.position;
        Instantiate(Plinelod, new Vector2(targetLod.x, 18), Quaternion.identity);
        yield return new WaitForSeconds(0.8f);
        Instantiate(lod, new Vector2(targetLod.x, 18), Quaternion.identity);
        audioSource.PlayOneShot(archangeBeamShotSE);
        timer0 = lodWait;
        methodNo++;
        yield break;
    }
    IEnumerator hitBlink()
    {
        hitFlag = false;
        shake.Shake(0.5f, 0.2f);
        for (int i = 0; i < 4; i++)
        {
            bigMask.transform.localScale = new Vector2(0, 0);
            eyeMask.transform.localScale = new Vector2(0, 0);
            yield return new WaitForSeconds(0.1f);
            bigMask.transform.localScale = bMfirst;
            eyeMask.transform.localScale = eMfirst;
            yield return new WaitForSeconds(0.1f);
        }
        hitFlag = true;
        yield break;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            if (summonNum != 5)
            {
                return;
            }
            if (tackleFlg)
            {
                return;
            }
            if (!hitFlag)
            {
                return;
            }
            else
            {
                StartCoroutine(hitBlink());
                audioSource.PlayOneShot(archangeTakendmgSE);
                TakeDamage(GameData.playeroffence);
                Debug.Log("�A���J���W����" + GameData.playeroffence + "�_���[�W���󂯂�");
            }
        }

        if (collision.gameObject.tag == "Player")
        {
            //�v���C���[�ւ̃_���[�W�Ȃǂ̃v���O�����͂�����
            Debug.Log("�A���J���W�����v���C���[�Ƀ_���[�W");
        }
    }

    public void TakeDamage(int damage)
    {
        if (damage - Archange.enemyDefensePower <= 0)
        {
            currentHealth -= 1;
        }
        else
        {
            currentHealth -= damage - Archange.enemyDefensePower;
        }

        if (currentHealth <= 0)
        {
            if (dieFlg)
            {
                return;
            }
            actNo = (int)ActNo.Die;
            methodNo = 0;
            GameData.playerexp += Archange.enemyExp;
            Debug.Log("Archange��|����");
            Debug.Log(Archange.enemyExp + "�̌o���l����ɓ��ꂽ");
        }
    }
}