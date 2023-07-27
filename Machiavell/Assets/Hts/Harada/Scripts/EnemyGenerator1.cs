using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator1 : MonoBehaviour
{
    float teki;
    float count;

    //敵プレハブ
    public GameObject enemyPrefab;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (teki == 0)
        {
            teki = 1;
            //enemyをインスタンス化する(生成する)
            enemy = Instantiate(enemyPrefab);
            //生成した敵の座標を決定する(現状X=7,Y=-2.5,Z=0の位置に出力)
            enemy.transform.position = new Vector3(3, 3, 0);
        }

        if (enemy == null && count == 0)
        {
            StartCoroutine(seisei());
        }
    }
    IEnumerator seisei()
    {
        count = 1;
        yield return new WaitForSeconds(3.0f); //3秒後に処理をする
        teki = 0;
        count = 0;
    }
}
