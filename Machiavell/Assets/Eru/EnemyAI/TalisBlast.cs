using UnityEngine;

public class TalisBlast : MonoBehaviour
{
    [SerializeField, Tooltip("DataBase")]
    private Enemy talis;

    public float attackDamage;

    private float deleteTime;

    void Start()
    {
        //DataBase参照
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
            //プレイヤーへのダメージなどのプログラムはここに
            Debug.Log("ターリスブラストがプレイヤーにダメージ");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag != "Crystal" && collision.gameObject.tag != "Laser")
        {
            //Destroy(gameObject);
        }
    }
}
