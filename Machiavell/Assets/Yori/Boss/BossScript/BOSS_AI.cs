using Cinemachine;
using System.Collections;
using UnityEngine;

public class BOSS_AI : MonoBehaviour
{
    // 変数
    [SerializeField, Header("行動番号")]
    public int actNo = 0;      // 行動番号
    [SerializeField, Header("メソッド用汎用番号")]
    public int methodNo = 0;   // メソッド用汎用番号

    [SerializeField, Header("登場待機")]
    private float appWait = 6;

    [SerializeField, Header("テレポートするまでの時間")]
    private float teleAppWait = 3;

    [SerializeField, Header("召喚待機")]
    private float summonWait = 6;

    [SerializeField, Header("ビーム発射待機")]
    private float beamShotWait = 3;

    [SerializeField, Header("ビーム待機")]
    private float beamWait = 5;

    [SerializeField, Header("タックル待機")]
    private float tackleWait = 3;

    [SerializeField, Header("タックル予備動作")]
    private float tacklePWait = 3;

    [SerializeField, Header("次のタックルまでの時間")]
    private float nextTackleWait = 0.5f;

    [SerializeField, Header("リング待機")]
    private float waveWait = 5;

    [SerializeField, Header("リング発射待機")]
    private float waveShotWait = 7;

    [SerializeField, Header("波状攻撃の隙")]
    private float waveChance = 4;

    [SerializeField, Header("神の杖待機")]
    private float lodWait = 5;

    [SerializeField, Header("テレポート待機")]
    private float teleportWait = 5;

    [SerializeField, Header("テレポート終了待機")]
    private float teleportEndWait = 5;

    [SerializeField, Header("召喚半径")]
    private float r;

    [SerializeField, Header("タックルのスピード")]
    private float tackleSpeed = 2;

    [SerializeField, Header("Algens_summon")]
    private GameObject algens_summon;

    [SerializeField, Header("ドロップアイテム")]
    private GameObject drop;

    [SerializeField, Header("点滅するやつ")]
    private GameObject warning;

    [SerializeField, Header("ビームPre")]
    GameObject Beam;

    [SerializeField, Header("わっかPre")]
    GameObject waveRing;

    [SerializeField, Header("神の杖Pre")]
    GameObject lod;

    [SerializeField, Header("神の杖予測線Pre")]
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

    [SerializeField, Header("ボスの防御判定1")]
    public CircleCollider2D defColi1;
    [SerializeField, Header("ボスの防御判定オブジェクト1")]
    public GameObject defobj1;
    [SerializeField, Header("ボスの防御判定2")]
    public CircleCollider2D defColi2;
    [SerializeField, Header("ボスの防御判定オブジェクト2")]
    public GameObject defobj2;

    [SerializeField, Header("パーティクル")]
    Parthikuru particle;

    [SerializeField, Header("神の杖の時のフェイド")]
    CanvasGroup fadeLod;

    [SerializeField, Header("攻撃された時の揺れ")]
    Shaking shake;

    [SerializeField, Header("死ぬ演出の時間")]
    private float dieTime;

    [SerializeField, Header("死ぬときのえふぇくと")]
    GameObject dieEffect;

    [SerializeField, Header("ボスの目ん玉")]
    GameObject bossEye;

    private int currentHealth;

    // タックルする際のターゲットを見る奴
    GameObject target;
    private int count;

    //親オブジェクト
    private GameObject parent;
    //子オブジェクト
    private GameObject child;

    // 召喚する数
    public int summonNum = 5;

    public GameObject camer;

    // 右にいるかいないか確認
    public bool rightFlg = false;
    public bool midFlg = false;
    // タックルしたかの確認
    public bool tackleFlg = false;

    bool hitFlag = true;

    // オフ波動のフラグ
    public bool waveFlg = false;

    // 死んだときのフラグ
    public bool dieFlg = false;

    private CircleCollider2D circleCol;

    private Vector2 pos;
    private Vector2 scalePos;

    // ボスの左右のポジション
    private float LRx = 16;
    private float LRy = -0.2f;

    private float cameraSize = 12;
    CinemachineVirtualCamera cinem;

    Rigidbody2D rb;
    // 列挙体：行動番号
    enum ActNo
    {
        App,        // 登場
        Summon,     // 召喚
        Beam,       // ビーム
        Tackle,     // タックル
        Wave,       // off波動
        Godlod,    // 神の杖
        Die,        // 死亡
        //Wait,       // 待機
        Teleport,   // 移動
        Num         // 総数
    }

    // デリゲード
    // 関数を型にするためのもの
    private delegate void ActFunc();
    // 関数の配列
    private ActFunc[] actFuncTbl;

    // HPが半分か
    private bool halfHp = false;

    // HPが四分の一か
    private bool quarterHp = false;

    public bool beamReady = false;
    public bool beamEnd = false;
    public bool tpStart = false;
    public bool tpEnd = false;
    private bool seFlg = false;

    float timer0 = 0;                   // 汎用タイマー
    int rand;                           // 乱数

    void Start()
    {
        // 関数配列を確保
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

        // 登場からスタートする
        actNo = (int)ActNo.App;

        //カメラの情報を取得する
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
        // 関数配列を用いた関数の呼び出し
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

    // 登場
    void ActApp()
    {
        // メソッド番号を使った処理の分岐
        switch (methodNo)
        {
            case 0:
                // 登場処理初期化
                Debug.Log("登場");
                circleCol.enabled = false;
                timer0 = appWait;
                //timer0 = 3; // タイマー設定

                ++methodNo; // 次の処理へ
                break;
            case 1:
                // タイマー待ち処理
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
                        methodNo++;  // メソッド番号を0に
                    }
                }
                break;
            case 2:
                // タイマー待ち処理
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    actNo = (int)ActNo.Teleport;
                    methodNo = 0;   // メソッド番号を0に
                }
                break;
        }
    }
    // 雑魚召喚
    void ActSummon()
    {
        // メソッド番号を使った処理の分岐
        switch (methodNo)
        {
            case 0:
                // 召喚処理初期化
                Debug.Log("召喚");
                timer0 = summonWait;
                ++methodNo; // 次の処理へ
                break;
            case 1:
                // 召喚処理
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
                    actNo = (int)ActNo.Godlod; // 神の杖処理へ
                    methodNo = 0;            // メソッド番号を0に
                }
                break;
            case 2:
                //召喚処理中
                break;
            case 3:
                // タイマー待ち処理
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {

                    rand = Random.Range(1, 10);
                    if (rand >= 6)
                    {
                        actNo = (int)ActNo.Tackle; // タックル処理へ
                        methodNo = 0;   // メソッド番号を0に

                    }
                    else
                    {
                        actNo = (int)ActNo.Beam; // ビーム処理へ
                        methodNo = 0;            // メソッド番号を0に
                    }
                }

                break;
        }
    }
    // ビーム
    void ActBeam()
    {
        // メソッド番号を使った処理の分岐
        switch (methodNo)
        {
            case 0:
                beamReady = true;
                // ビーム処理初期化
                Debug.Log("ビーム");
                timer0 = beamShotWait;
                //timer0 = 3; // タイマー設定
                ++methodNo; // 次の処理へ
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
                // ビーム処理待ち
                break;
            case 3:
                // タイマー待ち処理
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    rand = Random.Range(1, 10);
                    if (rand >= 3)
                    {
                        actNo = (int)ActNo.Tackle; // タックル処理へ
                        methodNo = 0;              // メソッド番号を0に

                    }
                    else if (rand <= 7)
                    {
                        actNo = (int)ActNo.Godlod; // 神の杖処理へ
                        methodNo = 0;              // メソッド番号を0に
                    }
                    else
                    {
                        actNo = (int)ActNo.Wave;  //波動処理へ
                        methodNo = 0;             // メソッド番号を0に
                    }
                }
                break;
        }
    }
    // タックル
    void ActTackle()
    {
        // メソッド番号を使った処理の分岐
        switch (methodNo)
        {
            case 0:
                // タックル処理初期化
                Debug.Log("タックル");
                timer0 = tackleWait;
                tpStart = true;
                particle.tp = true;
                circleCol.enabled = false;
                defColi1.enabled = false;
                defColi2.enabled = false;
                audioSource.PlayOneShot(archangeTeleportSE);
                eyeMask.transform.localScale = new Vector2(0, 0);
                ++methodNo; // 次の処理へ
                break;
            case 1:
                // タイマー待ち処理
                timer0 -= Time.deltaTime;
                if (!tpStart)
                {
                    Instantiate(warning, new Vector2(target.transform.position.x, target.transform.position.y), Quaternion.identity);
                    timer0 = tacklePWait;
                    particle.tp = true;
                    tpEnd = true;
                    ++methodNo; // 次の処理へ
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
                actNo = (int)ActNo.Teleport; // 移動処理へ
                methodNo = 0;              // メソッド番号を0に
                break;
        }
    }
    // off波動
    void ActWave()
    {
        // メソッド番号を使った処理の分岐
        switch (methodNo)
        {
            case 0:
                // off波動処理初期化
                Debug.Log("off波動");
                timer0 = waveShotWait;
                tpStart = true;
                particle.tp = true;
                circleCol.enabled = false;
                waveFlg = true;
                audioSource.PlayOneShot(archangeTeleportSE);
                eyeMask.transform.localScale = new Vector2(0, 0);
                ++methodNo; // 次の処理へ
                break;
            case 1:
                if (!tpStart)
                {
                    pos = this.gameObject.transform.position;
                    pos.x = 0;
                    pos.y = 45;
                    this.gameObject.transform.position = pos;
                    ++methodNo; // 次の処理へ
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
                    actNo = (int)ActNo.Teleport; // 移動処理へ
                    methodNo = 0;   // メソッド番号を0に
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
                    actNo = (int)ActNo.Teleport; // 移動処理へ
                    methodNo = 0;   // メソッド番号を0に
                }
                break;
        }
    }
    // 神の杖
    void ActGodlod()
    {
        switch (methodNo)
        {
            case 0:
                // 神の杖処理初期化
                Debug.Log("神の杖");
                tpStart = true;
                particle.tp = true;
                audioSource.PlayOneShot(archangeTeleportSE);
                eyeMask.transform.localScale = new Vector2(0, 0);
                ++methodNo; // 次の処理へ
                break;
            case 1:
                if (!tpStart)
                {
                    pos = this.gameObject.transform.position;
                    pos.x = 0;
                    pos.y = 45;
                    this.gameObject.transform.position = pos;
                    ++methodNo; // 次の処理へ
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
                // 神の杖処理
                if (!tpEnd)
                {
                    StartCoroutine(createLod());
                    methodNo++;
                }
                break;
            case 4:
                // 処理待ち
                break;
            case 5:
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    midFlg = true;
                    rand = Random.Range(1, 11);
                    if (rand >= 5)
                    {
                        actNo = (int)ActNo.Tackle; // タックル処理へ
                        methodNo = 0;   // メソッド番号を0に

                    }
                    else
                    {
                        actNo = (int)ActNo.Beam; // ビーム処理へ
                        methodNo = 0;            // メソッド番号を0に
                    }
                }
                break;
        }
    }

    // 待機
    //void ActWait()
    //{
    //    // メソッド番号を使った処理の分岐
    //    switch (methodNo)
    //    {
    //        case 0:
    //            //待機処理初期化
    //            Debug.Log("待機");
    //            Camera came = GetComponent<Camera>();
    //            timer0 = 3; // タイマー設定
    //            ++methodNo; // 次の処理へ
    //            break;
    //        case 1:

    //            if (temp.m_Lens.OrthographicSize>=9)
    //            {
    //                temp.m_Lens.OrthographicSize -= 0.2f;
    //            }
    //            // タイマー待ち処理
    //            timer0 -= Time.deltaTime;
    //            if (timer0 < 0)
    //            {
    //                timer0 -= Time.deltaTime;
    //                actNo = (int)ActNo.Teleport; // 移動処理へ
    //                methodNo = 0;              // メソッド番号を0に
    //            }
    //            break;
    //    }
    //}

    void ActTeleport()　// 左右にランダムでテレポートする
    {
        rand = Random.Range(1, 11);
        switch (methodNo)
        {
            case 0:
                Debug.Log("テレポート");
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
                    ++methodNo; // 次の処理へ  
                }

                break;
            case 2:
                // タイマー待ち処理
                timer0 -= Time.deltaTime;
                if (timer0 < 0)
                {
                    if (rand >= 5)
                    {
                        // 右にテレポート
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
                        // 左にテレポート
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
                            actNo = (int)ActNo.Godlod; // 神の杖処理へ
                            methodNo = 0;            // メソッド番号を0に
                        }
                        else if (rand <= 6)
                        {
                            actNo = (int)ActNo.Beam; // ビーム処理へ
                            methodNo = 0;            // メソッド番号を0に
                        }
                        else
                        {
                            actNo = (int)ActNo.Summon; // 召喚処理へ
                            methodNo = 0;   // メソッド番号を0に
                        }
                    }
                }

                break;
        }
    }

    // 死亡
    void ActDie()
    {

        switch (methodNo)
        {
            case 0:
                Debug.Log("死亡");
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
                Debug.Log("アルカンジュが" + GameData.playeroffence + "ダメージを受けた");
            }
        }

        if (collision.gameObject.tag == "Player")
        {
            //プレイヤーへのダメージなどのプログラムはここに
            Debug.Log("アルカンジュがプレイヤーにダメージ");
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
            Debug.Log("Archangeを倒した");
            Debug.Log(Archange.enemyExp + "の経験値を手に入れた");
        }
    }
}