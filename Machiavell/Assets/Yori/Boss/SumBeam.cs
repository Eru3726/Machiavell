using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumBeam : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy weekSum;

    public float attackDamage;

    private float deleteTime;

    void Start()
    {
        //DataBase�Q��
        attackDamage = weekSum.enemyOffensivePower;
        deleteTime = weekSum.enemyWalkTime;
    }

    private void Update()
    {
        deleteTime -= Time.deltaTime;

        if (deleteTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //�v���C���[�ւ̃_���[�W�Ȃǂ̃v���O�����͂�����
            Debug.Log("�T���r�[�����v���C���[�Ƀ_���[�W");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "grand" || collision.gameObject.tag == "Attack")
        {
            //Destroy(gameObject);
        }
    }
}
