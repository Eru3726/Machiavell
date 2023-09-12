using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Transform myTransform;

    private int index = 1;
    private bool nonePlayer = true;
    [SerializeField]
    private bool dashFlg = false;

    private float time;

    private GameObject player = null;

    private enum MODE_TYPE
    {
        NORMAL,
        SLOWFAST,
        POISON,
    }
    [SerializeField, Header("�]���r���[�h")]
    private MODE_TYPE modeType = MODE_TYPE.NORMAL;

    [SerializeField,Header("�ړ����x")]
    private float speed;

    [SerializeField, Header("��������")]
    private float walkTime = 2f;

    [SerializeField, Header("�ǔ���̃��C�ݒ�")]
    private RayLine wallChk = new RayLine();

    [SerializeField, Header("������̃��C�ݒ�")]
    private RayLine groundChk = new RayLine();

    [SerializeField, Header("�v���C���[���m�̃��C�ݒ�")]
    private RayCircle playerChk = new RayCircle();

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();

        time = walkTime;
    }

    void Update()
    {
        if (modeType == MODE_TYPE.NORMAL) NormalMode();
        else if (modeType == MODE_TYPE.SLOWFAST) SlowFastMode();
        else if (modeType == MODE_TYPE.POISON) PoisonMode();


        //�v���C���[���m
        if (playerChk.CircleChk() != null)
        {
            player = playerChk.CircleChk();
            nonePlayer = false;
        }
        else
        {
            player = null;
            nonePlayer = true;
        }
    }

    private void NormalMode()
    {
        //�v���C���[�����Ȃ��Ƃ�
        if (nonePlayer)
        {
            time -= Time.deltaTime;

            if (wallChk.LineChk() || !groundChk.LineChk() || time <= 0) DirChange();

            rb2d.velocity = new Vector2(speed * index, rb2d.velocity.y);
        }
        //�v���C���[������Ƃ�
        else
        {
            if (player == null) return;
            Vector2 moveDir = new Vector2(player.transform.position.x - myTransform.position.x, rb2d.velocity.y).normalized;
            if (moveDir.x > 0)
            {
                myTransform.localScale = new Vector3(Mathf.Abs(myTransform.localScale.x), myTransform.localScale.y, myTransform.localScale.z);
                index = Mathf.Abs(index);
            }
            else
            {
                myTransform.localScale = new Vector3(-Mathf.Abs(myTransform.localScale.x), myTransform.localScale.y, myTransform.localScale.z);
                index = -Mathf.Abs(index);
            }
            time = walkTime / 2;
            rb2d.velocity = new Vector2(speed * moveDir.x, rb2d.velocity.y);
            if (wallChk.LineChk() || !groundChk.LineChk()) rb2d.velocity = Vector2.zero;
        }
    }

    private void SlowFastMode()
    {
        time -= Time.deltaTime;

        //�v���C���[�����Ȃ��Ƃ�
        if (nonePlayer && !dashFlg)
        {
            if (wallChk.LineChk() || !groundChk.LineChk() || time <= 0) DirChange();

            rb2d.velocity = new Vector2(speed * index, rb2d.velocity.y);
        }
        //�v���C���[������Ƃ�
        else
        {
            Vector2 moveDir = new Vector2();
            if (player != null)
            {
                moveDir = new Vector2(player.transform.position.x - myTransform.position.x, rb2d.velocity.y).normalized;
                if (moveDir.x > 0)
                {
                    myTransform.localScale = new Vector3(Mathf.Abs(myTransform.localScale.x), myTransform.localScale.y, myTransform.localScale.z);
                    index = Mathf.Abs(index);
                }
                else
                {
                    myTransform.localScale = new Vector3(-Mathf.Abs(myTransform.localScale.x), myTransform.localScale.y, myTransform.localScale.z);
                    index = -Mathf.Abs(index);
                }
            }

            if (time <= 0 && !dashFlg)
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(speed * 2 * moveDir.x, rb2d.velocity.y), ForceMode2D.Impulse);
                dashFlg = true;
                time = walkTime / 2;
            }
            else if (dashFlg)
            {
                if (time <= 0f)
                {
                    time = walkTime;
                    dashFlg = false;
                }
            }
            else rb2d.velocity = new Vector2(speed * moveDir.x, rb2d.velocity.y);

            if (wallChk.LineChk() || !groundChk.LineChk()) rb2d.velocity = Vector2.zero;
        }
    }

    private void PoisonMode()
    {

    }

    /// <summary>
    /// �����ύX
    /// </summary>
    private void DirChange()
    {
        float scale = myTransform.localScale.x;
        scale *= -1;
        myTransform.localScale = new Vector3(scale, myTransform.localScale.y, myTransform.localScale.z);
        time = walkTime;
        index *= -1;
    }
}
