using UnityEngine;

public class TalisBlast : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy talis;

    public float attackDamage;

    private float deleteTime;

    void Start()
    {
        //DataBase�Q��
        attackDamage = talis.enemyOffensivePower;
        deleteTime = talis.enemyWalkTime;
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
            Debug.Log("�^�[���X�u���X�g���v���C���[�Ƀ_���[�W");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag != "Crystal" && collision.gameObject.tag != "Laser")
        {
            //Destroy(gameObject);
        }
    }
}
