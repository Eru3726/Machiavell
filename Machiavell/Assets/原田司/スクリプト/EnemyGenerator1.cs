using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator1 : MonoBehaviour
{
    float teki;
    float count;

    //�G�v���n�u
    public GameObject enemyPrefab;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�o�ߎ��Ԃ��������ԂɂȂ����Ƃ�(�������Ԃ��傫���Ȃ����Ƃ�)
        if (teki == 0)
        {
            teki = 1;
            //enemy���C���X�^���X������(��������)
            enemy = Instantiate(enemyPrefab);
            //���������G�̍��W�����肷��(����X=7,Y=-2.5,Z=0�̈ʒu�ɏo��)
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
        yield return new WaitForSeconds(3.0f); //3�b��ɏ���������
        teki = 0;
        count = 0;
    }
}
