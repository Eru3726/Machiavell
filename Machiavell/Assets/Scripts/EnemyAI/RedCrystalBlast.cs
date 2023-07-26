using UnityEngine;

public class RedCrystalBlast : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy redCrystal;

    private Transform target;

    public float attackDamage;

    private float deleteTime;

    private Vector2 dir;

    void Start()
    {
        //DataBase�Q��
        attackDamage = redCrystal.enemyOffensivePower;
        deleteTime = redCrystal.enemyWalkTime;
    }

    private void Update()
    {
        if (target == null)
        {
            target = GameObject.Find("player").transform;
        }
        else
        {
            deleteTime -= Time.deltaTime;

            dir = target.transform.position - transform.position;
            dir.Normalize();

            Rigidbody2D brb = gameObject.GetComponent<Rigidbody2D>();
            brb.velocity = dir * redCrystal.enemyMoveSpeed;

            transform.rotation = Quaternion.FromToRotation(Vector2.up, dir);

            if (deleteTime <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            Destroy(gameObject); 
        }

        if (collision.gameObject.tag == "Player")
        {
            //�v���C���[�ւ̃_���[�W�Ȃǂ̃v���O�����͂�����
            Debug.Log("���b�h�N���X�^���u���X�g���v���C���[�Ƀ_���[�W");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag != "Crystal" && collision.gameObject.tag != "Laser")
        {
            //Destroy(gameObject);
        }
    }
}
