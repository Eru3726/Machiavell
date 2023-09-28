using UnityEngine;

public class BlueCrystalLaser : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy crystal;

    public float attackDamage;

    private float deleteTime;

    void Start()
    {
        //DataBase参照
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
            //プレイヤーへのダメージなどのプログラムはここに
            Debug.Log("クリスタルレーザーがプレイヤーにダメージ");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag != "Crystal" && collision.gameObject.tag != "Laser")
        {
            //Destroy(gameObject);
        }
    }
}
