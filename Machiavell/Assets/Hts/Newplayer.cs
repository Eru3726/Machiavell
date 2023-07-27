using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Newplayer : MonoBehaviour
{
    public Read readClass;
    public Save saveClass;
    public GameObject playerdieeffect;
    float bukuiHP;
    public float maxHp;
    public float maxst;
    public float hp;
    public float stamina;
    public float DEF;
    public float ATK;
    public float LUCK;
    public float hpnow;
    public float staminaheal;
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
    public static float speed;
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
    Animator animator;    //アニメーター
    AudioSource audioSource;
    public AudioClip hitDamage;
    public AudioClip behavior;

    //移動スピードと点滅の間隔
    [SerializeField] float flashInterval;
    //点滅させるときのループカウント
    [SerializeField] int loopCount;
    //点滅させるためのSpriteRenderer
    SpriteRenderer sp;
    //当たったかどうかのフラグ
    bool isHit;
    //プレイヤーの状態用列挙型（ノーマル、ダメージ、無敵の3種類）

    private bool right = false;
    private bool left = false;
    private bool deadF = false;
    private bool deadF2 = false;
    enum STATE
    {
        NOMAL,
        DAMAGED,
        MUTEKI
    }
    //STATE型の変数
    STATE state;

    void Start()
    {
        speed = 0;

        deadF = false;
        deadF2 = false;

        audioSource = GetComponent<AudioSource>();

        readClass.enabled = true;
        //GameDateから数値を受け取る
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
            bukiHP = GameData.weaponHp1;
            bukiST = GameData.weaponStamina1;
            bukiDEF = GameData.weaponGuard1;
            bukiLUC = GameData.weaponLuck1;
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
            bukiHP = GameData.weaponHp2;
            bukiST = GameData.weaponStamina2;
            bukiDEF = GameData.weaponGuard2;
            bukiLUC = GameData.weaponLuck2;
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
            bukiHP = GameData.weaponHp3;
            bukiST = GameData.weaponStamina3;
            bukiDEF = GameData.weaponGuard3;
            bukiLUC = GameData.weaponLuck3;
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
            bukiHP = GameData.weaponHp4;
            bukiST = GameData.weaponStamina4;
            bukiDEF = GameData.weaponGuard4;
            bukiLUC = GameData.weaponLuck4;
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
            bukiHP = GameData.weaponHp5;
            bukiST = GameData.weaponStamina5;
            bukiDEF = GameData.weaponGuard5;
            bukiLUC = GameData.weaponLuck5;
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
            bukiHP = GameData.weaponHp6;
            bukiST = GameData.weaponStamina6;
            bukiDEF = GameData.weaponGuard6;
            bukiLUC = GameData.weaponLuck6;
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
            bukiHP = GameData.weaponHp7;
            bukiST = GameData.weaponStamina7;
            bukiDEF = GameData.weaponGuard7;
            bukiLUC = GameData.weaponLuck7;
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
            bukiHP = GameData.weaponHp8;
            bukiST = GameData.weaponStamina8;
            bukiDEF = GameData.weaponGuard8;
            bukiLUC = GameData.weaponLuck8;
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
            bukiHP = GameData.weaponHp9;
            bukiST = GameData.weaponStamina9;
            bukiDEF = GameData.weaponGuard9;
            bukiLUC = GameData.weaponLuck9;
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
            bukiHP = GameData.weaponHp10;
            bukiST = GameData.weaponStamina10;
            bukiDEF = GameData.weaponGuard10;
            bukiLUC = GameData.weaponLuck10;
            weponHP = bukiHP;
            weponST = bukiST;
            weponDEF = bukiDEF;
            weponLUC = bukiLUC;

            bukuiHP = weponHP;
            maxst = ST + weponST;
            DEF = def + weponDEF;
            LUCK = luck + weponLUC;
        }

        maxHp = hp + bukuiHP;
        hp = HPNOW;

        //HPとSTの現在地を参照する
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

        rb2d.constraints = RigidbodyConstraints2D.None;
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        image.fillAmount = hp / maxHp;
        image1.fillAmount = (float)stamina / (float)maxst;
        if (hp <= 0 && !deadF2)
        {
            deadF = true;
            deadF2 = true;
        }
        if (deadF)
        {
            deadF = false;

            rb2d.constraints = RigidbodyConstraints2D.FreezeAll;

            if (GameData.soubi == 1)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 2)
            {
                GameData.inventoryWeapon1 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 3)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon1 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 4)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon1 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 5)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon1 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 6)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon1 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 7)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon1 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 8)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon1 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 9)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon1 = 999;
                GameData.inventoryWeapon10 = 999;
            }
            else if (GameData.soubi == 10)
            {
                GameData.inventoryWeapon2 = 999;
                GameData.inventoryWeapon3 = 999;
                GameData.inventoryWeapon4 = 999;
                GameData.inventoryWeapon5 = 999;
                GameData.inventoryWeapon6 = 999;
                GameData.inventoryWeapon7 = 999;
                GameData.inventoryWeapon8 = 999;
                GameData.inventoryWeapon9 = 999;
                GameData.inventoryWeapon1 = 999;
            }
            StartCoroutine(dead());
        }
        if(!deadF2)
        {
            if (right == true)
            {
                //if (speed == 0)
                //{
                //    StopCoroutine("SpeedUp");
                //    Debug.Log("ダッシュ終了");
                //    animator.ResetTrigger("kaihi");
                //    right = false;
                //    left = false;
                //    speed = 0;
                //    this.rb2d.constraints = RigidbodyConstraints2D.None;
                //    this.rb2d.freezeRotation = true;
                //    inputSpeed = Minspeed;
                //    gameObject.layer = LayerMask.NameToLayer("Collision");
                //}
                this.animator.ResetTrigger("attack");
                damegi.SetActive(false);
                //trueのときのみアニメーションを再生する
                animator.SetBool("run", true);
                speed = inputSpeed;
                transform.localScale = new Vector3(2, 2, 2);
            }
            if (left == true)
            {
                //if (speed == 0)
                //{
                //    StopCoroutine("SpeedUp");
                //    animator.ResetTrigger("kaihi");
                //    right = false;
                //    left = false;
                //    speed = 0;
                //    this.rb2d.constraints = RigidbodyConstraints2D.None;
                //    this.rb2d.freezeRotation = true;
                //    inputSpeed = Minspeed;
                //    gameObject.layer = LayerMask.NameToLayer("Collision");
                //}
                this.animator.ResetTrigger("attack");
                damegi.SetActive(false);
                animator.SetBool("run", true);
                speed = inputSpeed * -1;
                transform.localScale = new Vector3(-2, 2, 2);
            }
            if (Input.GetKeyDown(GameData.healkey) && GameData.healpotion >= 1)
            {
                GameData.healpotion -= 1;
                hp += 20;
            }
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

                //if (Input.GetKeyDown(KeyCode.P))
                //{
                //    GameData.playerhpnow = (int)hp;
                //    saveClass.enabled = true;
                //    readClass.enabled = true;
                //    Debug.Log("セーブができました");
                //}
                //A,Dが押された場合
                if (Input.GetKey(GameData.rightkey) && blowFlag == false && stop == 0)
                {
                    this.animator.ResetTrigger("attack");
                    damegi.SetActive(false);
                    //trueのときのみアニメーションを再生する
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
                    //falseのときアニメーションを変更する
                    animator.SetBool("run", false);
                    if (right == false && left == false)
                    {
                        speed = 0;
                    }
                }

                if (stamina >= 30 && Input.GetKey(GameData.dashkey) && time <= 0 && Input.GetKey(GameData.rightkey) && dameg1 == 0)
                {
                    StopCoroutine("Attack");
                    this.tag = "Player";
                    damegi.SetActive(false);
                    Debug.Log("freezeof");
                    var rb = gameObject.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.None;
                    rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                    stop = 0;
                    this.animator.ResetTrigger("attack");
                    damegi.SetActive(false);
                    time = 1;
                    stamina += -30;
                    //ゲージを減少させる
                    //image1.fillAmount -= 0.1f;
                    right = true;
                    StartCoroutine("SpeedUp");
                }
                else if (stamina >= 30 && Input.GetKey(GameData.dashkey) && time <= 0 && Input.GetKey(GameData.leftkey) && dameg1 == 0)
                {
                    StopCoroutine("Attack");
                    this.tag = "Player";
                    damegi.SetActive(false);
                    Debug.Log("freezeof");
                    var rb = gameObject.GetComponent<Rigidbody2D>();
                    rb.constraints = RigidbodyConstraints2D.None;
                    rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                    stop = 0;
                    this.animator.ResetTrigger("attack");
                    damegi.SetActive(false);
                    time = 1;
                    stamina += -30;
                    //ゲージを減少させる
                    //image1.fillAmount -= 0.1f;
                    left = true;
                    StartCoroutine("SpeedUp");
                }

                if (time >= 0)
                {
                    time -= Time.deltaTime; //毎秒1の時間減少
                }

                //Spaceが押された場合
                if (Input.GetKeyDown(GameData.jumpkey) && jumpcout < 2 && stop == 0)
                {
                    this.animator.ResetTrigger("attack");
                    damegi.SetActive(false);
                    //カウントが2未満のときのみジャンプができる
                    //this.animator.SetTrigger("Jump up");
                    jump = 1;
                    Jump();
                    jumpcout++; //飛ぶたびにカウントを1増やす
                }

                if (rb2d.velocity.y > 0 && jump == 1)
                {
                    this.animator.ResetTrigger("Ground");
                    this.animator.SetTrigger("Jump up");
                    //Debug.Log("↑");
                }
                else if (rb2d.velocity.y < 0 && jump == 1)
                {
                    this.animator.ResetTrigger("Jump up");
                    this.animator.SetTrigger("Jump Down");
                    //Debug.Log("↓");
                    jump = 0;
                }

                if (stamina <= maxst)
                {
                    stamina += Time.deltaTime * staminaheal; //毎秒１のスタミナ回復
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
                //if (Input.GetKeyDown(GameData.attackkey) && speed == 0 && jumpcout <= 0 && dameg1 == 0)
                if (Input.GetKeyDown(GameData.attackkey) && speed == 0 && dameg1 == 0 && stop == 0)
                {
                    stop = 1;
                    Debug.Log("attack");
                    this.animator.ResetTrigger("Jump up");
                    this.animator.ResetTrigger("Jump Down");
                    this.animator.ResetTrigger("kaihi");
                    this.animator.SetTrigger("attack");
                    StartCoroutine("Attack");
                }
            }
        }
    }
    IEnumerator SpeedUp()
    {
        //this.animator.ResetTrigger("Jump Down");
        //this.animator.SetTrigger("kaihi");
        animator.Play("kaihi");
        if (jumpcout >= 1)
        {
            //一定時間だけ速度を上げ無敵にする
            inputSpeed = (Input.GetKey(GameData.dashkey)) ? Maxspeed : Minspeed;
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionY;
            this.rb2d.freezeRotation = true;
            gameObject.layer = LayerMask.NameToLayer("Player");
            Debug.Log("ダッシュ中");
            yield return new WaitForSeconds(0.2f); //0.5秒後に処理をする
            Debug.Log("ダッシュ終わり");
            animator.Play("stand");
            right = false;
            left = false;
            speed = 0;
            Debug.Log("freezeof");
            this.rb2d.constraints = RigidbodyConstraints2D.None;
            this.rb2d.freezeRotation = true;
            inputSpeed = Minspeed;
            gameObject.layer = LayerMask.NameToLayer("Collision");
        }

        if (jumpcout == 0)
        {
            //一定時間だけ速度を上げ無敵にする
            inputSpeed = (Input.GetKey(GameData.dashkey)) ? Maxspeed : Minspeed;
            gameObject.layer = LayerMask.NameToLayer("Player");
            Debug.Log("ダッシュ中");
            yield return new WaitForSeconds(0.2f); //0.5秒後に処理をする
            Debug.Log("ダッシュ終わり");
            animator.Play("stand");
            right = false;
            left = false;
            speed = 0;
            inputSpeed = Minspeed;
            gameObject.layer = LayerMask.NameToLayer("Collision");
        }
    }
    IEnumerator Attack()
    {
        if (dameg1 != 1)
        {

            Debug.Log("freeze");
            var rb = gameObject.GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            yield return new WaitForSeconds(0.5f); //0.5秒後に処理をする
            if (dameg1 == 1)
            {
                Debug.Log("attackbreak");
                //Debug.Log("freezeof");
                //rb.constraints = RigidbodyConstraints2D.None;
                //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                yield break;
            }
            damegi.SetActive(true);
            this.tag = "Attack";
            audioSource.PlayOneShot(behavior);
            yield return new WaitForSeconds(0.8f); //0.8秒後に処理をする
            //animator.Play("stand");
            this.tag = "Player";
            damegi.SetActive(false);
            stop = 0;
            Debug.Log("freezeof");
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }

    void FixedUpdate()
    {
        // キャラクターを移動 Vextor2(x軸スピード、y軸スピード(元のまま))
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }

    void Jump()
    {
        //this.animator.SetTrigger("Jump Triger");
        //rb2d.AddForce(Vector2.up * jumpingPower); //ジャンプ力の判定
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpingPower);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!deadF2)
        {
            if (collision.gameObject.CompareTag("grand"))
            {
                //ジャンプして着地したらアニメーションも終わる
                Debug.Log("banana");
                this.animator.SetTrigger("Ground");
                //jumpcout = 0;　//地面に触れたら値を0に戻す
                Debug.Log("地面接触");
            }

            if (collision.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                Debug.Log("衝突");
                //Hitしていたら処理を行わない
                if (isHit)
                {
                    return;
                }
                damegi.SetActive(false);
                enemy = collision.gameObject.transform;

                //コルーチンを開始
                //Debug.Log("freezeof");
                //var rb = gameObject.GetComponent<Rigidbody2D>();
                //rb.constraints = RigidbodyConstraints2D.None;
                //rb.constraints = RigidbodyConstraints2D.FreezeRotation;

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
                if (enemyatk > DEF)
                {
                    enemyatk -= DEF;
                    hp -= enemyatk;
                }
                else if (enemyatk <= DEF)
                {
                    hp -= 1;
                }
                Debug.Log(enemyatk);

                StartCoroutine(_hit());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!deadF2)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                Debug.Log("貫通");
                //Hitしていたら処理を行わない
                if (isHit)
                {
                    return;
                }

                enemy = collision.gameObject.transform;

                //コルーチンを開始
                //Debug.Log("freezeof");
                //var rb = gameObject.GetComponent<Rigidbody2D>();
                //rb.constraints = RigidbodyConstraints2D.None;
                //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
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
    }

    //点滅させる処理
    IEnumerator _hit()
    {
        StopCoroutine(Attack());
        blowFlag2 = false;
        dameg1 = 1;
        stop = 0;
        damegi.SetActive(false);
        this.animator.ResetTrigger("attack");
        this.animator.SetTrigger("dameg");

        audioSource.PlayOneShot(hitDamage);

        Debug.Log("bock");
        var rb = gameObject.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

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

        //ゲージを減少させる
        image.fillAmount = hp / maxHp;
        Dameg = 0;

        gameObject.layer = LayerMask.NameToLayer("Player");
        //当たりフラグをtrueに変更（当たっている状態）
        isHit = true;

        //点滅ループ開始
        for (int i = 0; i < loopCount; i++)
        {
            //flashInterval待ってから
            yield return new WaitForSeconds(flashInterval);
            //spriteRendererをオフ
            sp.enabled = false;

            //flashInterval待ってから
            yield return new WaitForSeconds(flashInterval);
            //spriteRendererをオン
            sp.enabled = true;
        }
        gameObject.layer = LayerMask.NameToLayer("Collision");
        //点滅ループが抜けたら当たりフラグをfalse(当たってない状態)
        isHit = false;
        yield return new WaitForSeconds(0.1f); //0.1秒後に処理をする
        blowFlag2 = true;
        dameg1 = 0;
    }
    IEnumerator dead()
    {
        Instantiate(playerdieeffect, new Vector3(gameObject.transform.position.x,gameObject.transform.position.y -1.5f,gameObject.transform.position.z), Quaternion.Euler(-90,0,0));
        yield return new WaitForSeconds(3.5f);
        GameData.playerhpnow = (int)maxHp;
        GameData.save = false;
        saveClass.enabled = true;
        deadF2 = false;
        SceneManager.LoadScene("titlescene");
        yield break;
    }
}