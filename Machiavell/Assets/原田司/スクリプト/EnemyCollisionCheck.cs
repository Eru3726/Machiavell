using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionChedk : MonoBehaviour
{
    // 2D���W�b�h�{�f�B���󂯎��ϐ�
    Rigidbody2D rb2D;
    // �A�j���[�V��������̂��
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // �A�j���[�^�[�i�A�j���[�V��������̂�j���󂯎��
        anim = GetComponent("Animator") as Animator;
        // ������2D���W�b�h�{�f�B���󂯎��B
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // �L�����N�^�[�̑傫���B�����ɂ���Ɣ��]�����
        Vector3 scale = transform.localScale;
        if (rb2D.velocity.x > 1)      // �E�����ɓ����Ă���
            scale.x = 1;  // �ʏ����(�X�v���C�g�Ɠ����E����)
        else if (rb2D.velocity.x < -1) // �������ɓ����Ă���
            scale.x = -1; // ���]
        // �X�V
        transform.localScale = scale;

        // ������x�̈ړ��ʂ�������͂΂���
        if (0.1 > rb2D.velocity.magnitude)
            anim.SetBool("Flying", false);
        else
            anim.SetBool("Flying", true);
    }
}
