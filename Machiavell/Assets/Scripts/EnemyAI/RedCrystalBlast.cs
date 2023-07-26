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
        //DataBase参照
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
            //プレイヤーへのダメージなどのプログラムはここに
            Debug.Log("レッドクリスタルブラストがプレイヤーにダメージ");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag != "Crystal" && collision.gameObject.tag != "Laser")
        {
            //Destroy(gameObject);
        }
    }
}
