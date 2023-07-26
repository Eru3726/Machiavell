using UnityEngine;

public class BlueCrystalLaser : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy crystal;

    public float attackDamage;

    private float deleteTime;

    void Start()
    {
        //DataBase�Q��
        attackDamage = crystal.enemyOffensivePower;
        deleteTime = crystal.enemyWalkTime;
    }

    private void Update()
    {
        deleteTime -= Time.deltaTime;

        if(deleteTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //�v���C���[�ւ̃_���[�W�Ȃǂ̃v���O�����͂�����
            Debug.Log("�N���X�^�����[�U�[���v���C���[�Ƀ_���[�W");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag != "Crystal" && collision.gameObject.tag != "Laser")
        {
            //Destroy(gameObject);
        }
    }
}
